using DataAsGuard.CSClass;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAsGuard.FileManagement
{
    public partial class ManageGroups : Form
    {
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();
        int groupCreatorID = 0;

        public ManageGroups()
        {
            InitializeComponent();
        }

        private void ManageGroups_Load(object sender, EventArgs e)
        {
            editGroupButton.Enabled = false;
            deleteGroupButton.Enabled = false;
            //Load all groups from MySql
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                adapter = new MySqlDataAdapter("SELECT * FROM da_schema.groupInfo", con);
                adapter.Fill(table);
                groupList.DataSource = table;
                groupList.DisplayMember = "groupName";
                groupList.ValueMember = "groupName";
                con.Close();
            }
        }

        private void groupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupInformation.Clear();
            membersList.Items.Clear();
            deleteGroupButton.Enabled = false;
            editGroupButton.Enabled = false;
            transferOwnershipButton.Enabled = false;

            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                string curItem = groupList.SelectedValue.ToString();
                //Retrieve group info from DB
                String groupInfoquery = "SELECT * FROM groupInfo WHERE groupName = @nameParam";
                MySqlCommand groupInfocmd = new MySqlCommand(groupInfoquery, con);
                groupInfocmd.Parameters.AddWithValue("@nameParam", curItem);
                MySqlDataReader reader = groupInfocmd.ExecuteReader();
                if (reader.Read())
                {
                    groupInformation.AppendText("Date Created: " + reader["dateCreated"].ToString());
                    groupInformation.AppendText(Environment.NewLine + "Group Creator: " + reader["groupCreator"].ToString());
                    groupInformation.AppendText(Environment.NewLine + "Group Description: " + reader["groupDescription"].ToString());
                    groupCreatorID = Convert.ToInt32(reader["groupCreatorID"]);
                }
                reader.Close();

                //Retrieve group members from DB
                String getGroupMembersquery = "SELECT * FROM groupUsers WHERE groupName = @nameParam";
                MySqlCommand groupMemberscmd = new MySqlCommand(getGroupMembersquery, con);
                groupMemberscmd.Parameters.AddWithValue("@nameParam", curItem);
                MySqlDataReader reader2 = groupMemberscmd.ExecuteReader();
                while (reader2.Read())
                {
                    membersList.Items.Add(reader2["userFullName"].ToString());
                }
                reader2.Close();

                if (Logininfo.userid == groupCreatorID.ToString())
                {
                    deleteGroupButton.Enabled = true;
                    editGroupButton.Enabled = true;
                }
                con.Close();
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Home view = new Home();
            view.Show();
            Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            FileManagementHub view = new FileManagementHub();
            view.Show();
            Hide();
        }

        private void createGroupButton_Click(object sender, EventArgs e)
        {
            CreateNewGroup createNewGroup = new CreateNewGroup();
            createNewGroup.Show();
            createNewGroup.FormClosed += createNewGroup_FormClosed;
        }

        private void createNewGroup_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManageGroups view = new ManageGroups();
            view.Show();
            Hide();
        }

        private void editGroupButton_Click(object sender, EventArgs e)
        {
            EditGroup view = new EditGroup(groupList.SelectedValue.ToString());
            view.Show();
            view.FormClosed += editGroup_FormClosed;
        }

        private void editGroup_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManageGroups view = new ManageGroups();
            view.Show();
            Hide();
        }

        private void deleteGroupButton_Click(object sender, EventArgs e)
        {
            int groupID = 0;
            DialogResult result = MessageBox.Show("All file permissions related to this group will be removed and those users will not be able to access those files anymore. Continue?", "Warning", MessageBoxButtons.YesNo);
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                if (result == DialogResult.Yes)
                {
                    con.Open();
                    string curItem = groupList.SelectedValue.ToString();

                    String getGroupIDQuery = "SELECT * FROM groupInfo WHERE groupName = @nameParam";
                    MySqlCommand getGroupcmd = new MySqlCommand(getGroupIDQuery, con);
                    getGroupcmd.Parameters.AddWithValue("@nameParam", curItem);
                    MySqlDataReader reader = getGroupcmd.ExecuteReader();
                    if (reader.Read())
                    {
                        groupID = Convert.ToInt32(reader["groupID"]);
                    }
                    reader.Close();

                    String deletePermissionsQuery = "DELETE FROM groupFilePermissions WHERE groupID = @idParam";
                    MySqlCommand deletePermsCmd = new MySqlCommand(deletePermissionsQuery, con);
                    deletePermsCmd.Parameters.AddWithValue("@idParam", groupID);
                    deletePermsCmd.ExecuteNonQuery();


                    String deleteMembersQuery = "DELETE FROM groupUsers WHERE groupName = @nameParam";
                    MySqlCommand deleteMembersCmd = new MySqlCommand(deleteMembersQuery, con);
                    deleteMembersCmd.Parameters.AddWithValue("@nameParam", curItem);
                    deleteMembersCmd.ExecuteNonQuery();

                    String deletegroupQuery = "DELETE FROM groupInfo WHERE groupName = @nameParam";
                    MySqlCommand deleteGroupCmd = new MySqlCommand(deletegroupQuery, con);
                    deleteGroupCmd.Parameters.AddWithValue("@nameParam", curItem);
                    deleteGroupCmd.ExecuteNonQuery();

                    con.Close();
                }
            }
            ManageGroups view = new ManageGroups();
            view.Show();
            Hide();
        }

        private void transferOwnershipButton_Click(object sender, EventArgs e)
        {
            string curItem = membersList.SelectedItem.ToString();
            int newCreatorID = 0;
            Boolean success = false;
            DialogResult result = MessageBox.Show("Ownership of the group will be transferred to " + curItem + ". Continue?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
                {
                    con.Open();
                    String getUserIDQuery = "SELECT * FROM Userinfo WHERE fullName = @nameParam";
                    MySqlCommand getUserIdCMD = new MySqlCommand(getUserIDQuery, con);
                    getUserIdCMD.Parameters.AddWithValue("@nameParam", curItem);
                    MySqlDataReader reader = getUserIdCMD.ExecuteReader();
                    if (reader.Read())
                    {
                        newCreatorID = Convert.ToInt32(reader["userid"]);
                    }
                    reader.Close();
                    String updateOwnerQuery = "UPDATE groupInfo SET groupCreator = @nameParam, groupCreatorID = @IDParam WHERE groupName = @groupParam";
                    MySqlCommand updateOwnerCmd = new MySqlCommand(updateOwnerQuery, con);
                    updateOwnerCmd.Parameters.AddWithValue("@nameParam", curItem);
                    updateOwnerCmd.Parameters.AddWithValue("@IDParam", newCreatorID);
                    updateOwnerCmd.Parameters.AddWithValue("@groupParam", groupList.SelectedValue.ToString());
                    updateOwnerCmd.ExecuteNonQuery();

                    success = true;
                    con.Close();
                }

                if (success)
                {
                    MessageBox.Show("Successfully transferred ownership of group.");
                    ManageGroups view = new ManageGroups();
                    view.Show();
                    Hide();
                }
            }
        }

        private void membersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            transferOwnershipButton.Enabled = false;

            if (Logininfo.userid == groupCreatorID.ToString())
            {
                transferOwnershipButton.Enabled = true;
            }
        }
    }
}
