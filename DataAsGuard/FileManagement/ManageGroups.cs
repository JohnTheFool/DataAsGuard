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

        public ManageGroups()
        {
            InitializeComponent();
        }

        private void ViewGroups_Load(object sender, EventArgs e)
        {
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
                }
                reader.Close();

                //Retrieve group members from DB
                String getGroupMembersquery = "SELECT * FROM groupUsers WHERE groupName = @nameParam";
                MySqlCommand groupMemberscmd = new MySqlCommand(getGroupMembersquery, con);
                groupMemberscmd.Parameters.AddWithValue("@nameParam", curItem);
                MySqlDataReader reader2 = groupMemberscmd.ExecuteReader();
                if (reader2.Read())
                {
                    membersList.Items.Add(reader2["userFullName"].ToString());
                }
                reader2.Close();

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
        }

        private void editGroupButton_Click(object sender, EventArgs e)
        {
            EditGroup view = new EditGroup("groupEdited");
            view.Show();
        }

        private void deleteUserFromGroupButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteGroupButton_Click(object sender, EventArgs e)
        {

        }

        
    }
}
