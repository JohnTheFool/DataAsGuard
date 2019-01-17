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
        public EditGroup(String groupEdited)
        {
            InitializeComponent();
            groupName_Text.Text = groupEdited;
            originalGroupName = groupEdited;
        }

        private void EditGroup_Load(object sender, EventArgs e)
        {
            LoadUsersIntoMembersList();
            LoadUsersIntoList();
        }

        private void updateGroupButton_Click(object sender, EventArgs e)
        {
            if (InsertGroupMembersIntoDatabase() && UpdateGroupInfoIntoDatabase() && RemoveGroupMembersFromDB())
            {
                MessageBox.Show("Group successfully updated.");
            }

            EditGroup refresh = new EditGroup(groupName_Text.Text);
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
                    for (int i = 0; i < groupMembers.Items.Count; i++)
                    {
                        if (reader["fullName"].ToString() == groupMembers.Items[i].ToString())
                        {
                            continue;
                        }
                    }
                    userList.Items.Add(reader["fullName"].ToString());
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
                        continue;
                    }
                    reader2.Close();

                    String getGroupIDQuery = "SELECT * FROM groupInfo WHERE groupName = @nameParam";
                    MySqlCommand getGroupcmd = new MySqlCommand(getGroupIDQuery, con);
                    getGroupcmd.Parameters.AddWithValue("@nameParam", this.groupName_Text.Text);
                    MySqlDataReader reader3 = getUsercmd.ExecuteReader();
                    if (reader3.Read())
                    {
                        groupID = Convert.ToInt32(reader["groupID"]);
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
                    getUsercmd.Parameters.AddWithValue("@fullNameParam", groupMembers.Items[i].ToString());
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

                    if (userExists)
                    {
                    String executeQuery = "DELETE FROM groupUsers WHERE groupName = @nameParam AND userID = @userParam)";
                    MySqlCommand myCommand = new MySqlCommand(executeQuery, con);
                    checkUserCmd.Parameters.AddWithValue("@nameParam", this.groupName_Text.Text);
                    checkUserCmd.Parameters.AddWithValue("@userParam", userID);
                    myCommand.ExecuteNonQuery();
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
                String executeQuery = "UPDATE groupInfo SET groupDesc = @groupDescParam, groupName = @groupNameParam WHERE groupName = @originalGroupParam)";
                MySqlCommand myCommand = new MySqlCommand(executeQuery, con);
                myCommand.Parameters.AddWithValue("@originalGroupParam", originalGroupName);
                myCommand.Parameters.AddWithValue("@groupNameParam", this.groupName_Text.Text);
                myCommand.Parameters.AddWithValue("@groupDescParam", this.groupDescription_Text.Text);
                myCommand.ExecuteNonQuery();
                con.Close();
                success = true;
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

        private void moveToGroupButton_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(userList, groupMembers);
        }

        private void removeFromGroupButton_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(groupMembers, userList);
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
