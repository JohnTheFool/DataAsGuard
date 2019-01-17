﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAsGuard.CSClass;
using MySql.Data.MySqlClient;

namespace DataAsGuard.FileManagement
{
    public partial class CreateNewGroup : Form
    {
        //MySqlDataAdapter adapter;
        DataTable table = new DataTable();

        public CreateNewGroup()
        {
            InitializeComponent();
        }

        private void CreateNewGroup_Load(object sender, EventArgs e)
        {
            LoadUsersIntoList();
        }

        private void createGroupButton_Click(object sender, EventArgs e)
        {
            if (CheckIfGroupExists())
            {
                System.Windows.Forms.MessageBox.Show("Group name already exists, please enter another name.");
            }

            else
            {
                if (InsertGroupInfoIntoDatabase() && InsertGroupMembersIntoDatabase())
                {
                    System.Windows.Forms.MessageBox.Show("Successfully created group.");
                    Hide();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Failed to create group, please try again.");
                    Hide();
                }
            }

        }

        private void LoadUsersIntoList()
        {
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM da_schema.Userinfo";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    userList.Items.Add(reader["fullName"].ToString());
                }
                reader.Close();
                con.Close();
            }
        }

        private Boolean InsertGroupInfoIntoDatabase()
        {
            string fullName = "";
            Boolean success = false;
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String nameQuery = "SELECT * FROM Userinfo WHERE userid = @idParam";
                MySqlCommand nameCmd = new MySqlCommand(nameQuery, con);
                nameCmd.Parameters.AddWithValue("@idParam", Logininfo.userid);
                MySqlDataReader reader = nameCmd.ExecuteReader();
                if (reader.Read())
                {
                    fullName = reader["fullName"].ToString();
                }
                reader.Close();
                String executeQuery = "INSERT INTO groupInfo(groupName, groupDescription, groupCreator, groupCreatorID, dateCreated) VALUES (@groupNameParam, @groupDescParam, @creatorParam, @creatorIDParam, @dateParam)";
                MySqlCommand myCommand = new MySqlCommand(executeQuery, con);
                myCommand.Parameters.AddWithValue("@groupNameParam", this.groupName_Text.Text);
                myCommand.Parameters.AddWithValue("@groupDescParam", this.groupDescription_Text.Text);
                myCommand.Parameters.AddWithValue("@creatorParam", fullName);
                myCommand.Parameters.AddWithValue("@creatorIDParam", Logininfo.userid); 
                myCommand.Parameters.AddWithValue("@dateParam", DateTime.Now);
                myCommand.ExecuteNonQuery();
                con.Close();
                success = true;
            }
            return success;
        }

        private Boolean CheckIfGroupExists()
        {
            Boolean groupExists = false;
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String checkQuery = "SELECT * FROM groupInfo WHERE (groupName = @nameParam)";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, con);
                checkCommand.Parameters.AddWithValue("@nameParam", this.groupName_Text.Text);
                MySqlDataReader reader = checkCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    groupExists = true;
                }
                con.Close();
            }
            return groupExists;
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

                    String getGroupIDQuery = "SELECT * FROM groupInfo WHERE groupName = @nameParam";
                    MySqlCommand getGroupcmd = new MySqlCommand(getGroupIDQuery, con);
                    getUsercmd.Parameters.AddWithValue("@nameParam", this.groupName_Text.Text);
                    MySqlDataReader reader2 = getUsercmd.ExecuteReader();
                    if (reader2.Read())
                    {
                        groupID = Convert.ToInt32(reader["groupID"]);
                    }
                    reader2.Close();

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

        private void ProfileButton_Click(object sender, EventArgs e)
        {

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

        }

    }
}
