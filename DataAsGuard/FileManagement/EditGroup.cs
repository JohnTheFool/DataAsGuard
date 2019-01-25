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
    public partial class EditGroup : Form
    {
        String originalGroupName = null;
        DBLogger dblog = new DBLogger();
        ManageGroups formToClose;
        String ownerName = "";

        public EditGroup(String groupEdited, ManageGroups obj)
        {
            InitializeComponent();
            groupName_Text.Text = groupEdited;
            originalGroupName = groupEdited;
            formToClose = obj;
        }

        private void EditGroup_Load(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM groupInfo WHERE groupName = @nameParam";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("nameParam", groupName_Text.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ownerName = reader["groupCreator"].ToString();
                    groupDescription_Text.Text = reader["groupDescription"].ToString();
                }
                reader.Close();
                con.Close();
            }

            LoadUsersIntoMembersList();
            LoadUsersIntoList();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            formToClose.Hide();
            ManageGroups newForm = new ManageGroups();
            newForm.Show();
        }
        private void updateGroupButton_Click(object sender, EventArgs e)
        {
            if (InsertGroupMembersIntoDatabase() && UpdateGroupInfoIntoDatabase() && RemoveGroupMembersFromDB())
            {
                MessageBox.Show("Group successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            EditGroup refresh = new EditGroup(groupName_Text.Text, formToClose);
            refresh.Show();
            Hide();
        }

        private void LoadUsersIntoMembersList()
        {
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM groupUsers WHERE groupName = @nameParam";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("nameParam", groupName_Text.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    groupMembers.Items.Add(reader["userFullName"].ToString());
                }
                reader.Close();
                con.Close();
            }
        }

        private void LoadUsersIntoList()
        {
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM Userinfo";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    userList.Items.Add(reader["fullName"].ToString());
                    for (int i = 0; i < groupMembers.Items.Count; i++)
                    {
                        if (reader["fullName"].ToString() == groupMembers.Items[i].ToString())
                        {
                            userList.Items.RemoveAt(userList.Items.Count - 1);
                        }
                    }
                }
                reader.Close();
                con.Close();
            }
        }

        private Boolean InsertGroupMembersIntoDatabase()
        {
            Boolean success = false;
            int userID = 0;
            int groupID = 0;
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                for (int i = 0; i < groupMembers.Items.Count; i++)
                {
                    Boolean skip = false;

                    String getUserIDQuery = "SELECT * FROM Userinfo WHERE fullName = @fullNameParam";
                    MySqlCommand getUsercmd = new MySqlCommand(getUserIDQuery, con);
                    getUsercmd.Parameters.AddWithValue("@fullNameParam", groupMembers.Items[i].ToString());
                    MySqlDataReader reader = getUsercmd.ExecuteReader();
                    if (reader.Read())
                    {
                        String stringuserID = reader["userid"].ToString();
                        userID = Convert.ToInt32(stringuserID);
                    }
                    reader.Close();

                    String checkIfUserAlrInGroupQuery = "SELECT * FROM groupUsers where groupName = @nameParam AND userID = @userParam";
                    MySqlCommand checkUserCmd = new MySqlCommand(checkIfUserAlrInGroupQuery, con);
                    checkUserCmd.Parameters.AddWithValue("@nameParam", this.groupName_Text.Text);
                    checkUserCmd.Parameters.AddWithValue("@userParam", userID);
                    MySqlDataReader reader2 = checkUserCmd.ExecuteReader();
                    if (reader2.Read())
                    {
                        //If user is already in group, skip inserting into DB
                        skip = true;
                    }
                    reader2.Close();

                    if (skip)
                    {
                        continue;
                    }

                    String getGroupIDQuery = "SELECT * FROM groupInfo WHERE groupName = @nameParam";
                    MySqlCommand getGroupcmd = new MySqlCommand(getGroupIDQuery, con);
                    getGroupcmd.Parameters.AddWithValue("@nameParam", this.groupName_Text.Text);
                    MySqlDataReader reader3 = getGroupcmd.ExecuteReader();
                    if (reader3.Read())
                    {
                        groupID = Convert.ToInt32(reader3["groupID"]);
                    }
                    reader3.Close();

                    String executeQuery = "INSERT INTO groupUsers(groupName, groupID, userID, userFullName, dateJoined) VALUES (@groupNameParam, @groupIDParam, @userIDParam, @nameParam, @dateParam)";
                    MySqlCommand myCommand = new MySqlCommand(executeQuery, con);
                    myCommand.Parameters.AddWithValue("@groupNameParam", this.groupName_Text.Text);
                    myCommand.Parameters.AddWithValue("@userIDParam", userID);
                    myCommand.Parameters.AddWithValue("@groupIDParam", groupID);
                    myCommand.Parameters.AddWithValue("@nameParam", groupMembers.Items[i].ToString());
                    myCommand.Parameters.AddWithValue("@dateParam", DateTime.Now);
                    myCommand.ExecuteNonQuery();

                    dblog.Log("Member  '" + groupMembers.Items[i].ToString() + "' added to " + this.groupName_Text.Text + ".", "GroupChanges", Logininfo.userid.ToString(), Logininfo.email.ToString());

                }
                success = true;
                con.Close();
            }
            return success;
        }

        private Boolean RemoveGroupMembersFromDB()
        {
            Boolean success = false;
            int userID = 0;
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                for (int i = 0; i < userList.Items.Count; i++)
                {
                    Boolean userExists = false;
                    String getUserIDQuery = "SELECT * FROM Userinfo WHERE fullName = @fullNameParam";
                    MySqlCommand getUsercmd = new MySqlCommand(getUserIDQuery, con);
                    getUsercmd.Parameters.AddWithValue("@fullNameParam", userList.Items[i].ToString());
                    MySqlDataReader reader = getUsercmd.ExecuteReader();
                    if (reader.Read())
                    {
                        String stringuserID = reader["userid"].ToString();
                        userID = Convert.ToInt32(stringuserID);
                    }
                    reader.Close();

                    String checkIfUserinListQuery = "SELECT * FROM groupUsers where groupName = @nameParam AND userID = @userParam";
                    MySqlCommand checkUserCmd = new MySqlCommand(checkIfUserinListQuery, con);
                    checkUserCmd.Parameters.AddWithValue("@nameParam", this.groupName_Text.Text);
                    checkUserCmd.Parameters.AddWithValue("@userParam", userID);
                    MySqlDataReader reader2 = checkUserCmd.ExecuteReader();
                    if (reader2.Read())
                    {
                        userExists = true;
                    }
                    reader2.Close();

                    if (userExists)
                    {
                        String executeQuery = "DELETE FROM groupUsers WHERE groupName = @nameParam AND userID = @userParam";
                        MySqlCommand myCommand = new MySqlCommand(executeQuery, con);
                        myCommand.Parameters.AddWithValue("@nameParam", this.groupName_Text.Text);
                        myCommand.Parameters.AddWithValue("@userParam", userID);
                        myCommand.ExecuteNonQuery();
                        dblog.Log("Member '" + userList.Items[i].ToString() + "' removed from "+ this.groupName_Text.Text+".", "GroupChanges", Logininfo.userid.ToString(), Logininfo.email.ToString());
                    }
                }
                success = true;
                con.Close();
            }
            return success;
        }

        private Boolean UpdateGroupInfoIntoDatabase()
        {
            Boolean success = false;
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String executeQuery = "UPDATE groupInfo SET groupDescription = @groupDescParam, groupName = @groupNameParam WHERE groupName = @originalGroupParam";
                MySqlCommand myCommand = new MySqlCommand(executeQuery, con);
                myCommand.Parameters.AddWithValue("@originalGroupParam", originalGroupName);
                myCommand.Parameters.AddWithValue("@groupNameParam", this.groupName_Text.Text);
                myCommand.Parameters.AddWithValue("@groupDescParam", this.groupDescription_Text.Text);
                myCommand.ExecuteNonQuery();
                con.Close();
                success = true;

                dblog.Log("Group information of " + this.groupName_Text.Text + " has been updated.", "GroupChanges", Logininfo.userid.ToString(), Logininfo.email.ToString());
            }

            return success;
        }

        private void MoveListBoxItems(ListBox source, ListBox destination)
        {
            ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
            foreach (var item in sourceItems)
            {
                destination.Items.Add(item);
            }
            while (source.SelectedItems.Count > 0)
            {
                source.Items.Remove(source.SelectedItems[0]);
            }
        }

        private void MoveListBoxItemsCheckOwner(ListBox source, ListBox destination)
        {
            Boolean ownerInGroup = false;
            ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
            for (int i = 0; i < source.SelectedItems.Count; i++)
            {
                if (source.SelectedItems[i].ToString() == ownerName)
                {
                    MessageBox.Show("The creator of the group cannot be removed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ownerInGroup = true;
                    break;
                }
                else
                    destination.Items.Add(source.SelectedItems[i].ToString());
            }
            if (!ownerInGroup)
            {
                while (source.SelectedItems.Count > 0)
                {
                    source.Items.Remove(source.SelectedItems[0]);
                }
            }
        }

        private void moveToGroupButton_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(userList, groupMembers);
        }

        private void removeFromGroupButton_Click(object sender, EventArgs e)
        {
            MoveListBoxItemsCheckOwner(groupMembers, userList);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            FileManagement.FileManagementHub view = new FileManagement.FileManagementHub();
            view.Show();
            Hide();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Home view = new Home();
            view.Show();
            Hide();
        }
    }
}
