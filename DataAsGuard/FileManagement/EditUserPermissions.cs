﻿using MySql.Data.MySqlClient;
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
    public partial class EditUserPermissions : Form
    {

        MySqlDataAdapter adapter;
        DataTable table = new DataTable();

        public EditUserPermissions(String fileName)
        {
            InitializeComponent();
            fileEditedLabel.Text = fileName;
        }

        private void EditUserPermissions_Load(object sender, EventArgs e)
        {
            //Load user list
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                adapter = new MySqlDataAdapter("SELECT * FROM da_schema.Userinfo", con);
                adapter.Fill(table);
                userList.DataSource = table;
                userList.DisplayMember = "fullName";
                userList.ValueMember = "userid";
                con.Close();
            }
        }
        private Boolean AddPermissionToDB()
        {
            Boolean success = false;
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();

                int readPermission = 0;
                int editPermission = 0;
                int downloadPermission = 0;
                int fileID = 0;
                int userID = 0;
                if (permissionCheckBox.GetItemCheckState(0) == CheckState.Checked) //Read permission
                {
                    readPermission = 1;
                }

                if (permissionCheckBox.GetItemCheckState(1) == CheckState.Checked) //Edit permission
                {
                    editPermission = 1;
                }

                if (permissionCheckBox.GetItemCheckState(2) == CheckState.Checked) //Download permission
                {
                    downloadPermission = 1;
                }

                String getFileIDQuery = "SELECT * FROM fileInfo WHERE fileName = @fileNameParam";
                MySqlCommand getfileidcmd = new MySqlCommand(getFileIDQuery, con);
                getfileidcmd.Parameters.AddWithValue("@fileNameParam", fileEditedLabel.Text);
                MySqlDataReader reader = getfileidcmd.ExecuteReader();
                if (reader.Read())
                {
                    fileID = Convert.ToInt32(reader["fileID"]);
                }
                reader.Close();

                String getUserIDQuery = "SELECT * FROM Userinfo WHERE fullName = @fullNameParam";
                MySqlCommand getuseridcmd = new MySqlCommand(getUserIDQuery, con);
                getuseridcmd.Parameters.AddWithValue("@fullNameParam", userSelectedLabel.Text);
                MySqlDataReader reader2 = getuseridcmd.ExecuteReader();
                if (reader2.Read())
                {
                    userID = Convert.ToInt32(reader2["userid"]);
                }
                reader2.Close();
                //First time setting permissions
                String executeQuery = "INSERT INTO userFilePermissions(fileID, userID, readPermission, editPermission, downloadPermission) VALUES (@fileIDParam, @userIDParam, @readParam, @editParam, @downloadParam)";
                MySqlCommand myCommand = new MySqlCommand(executeQuery, con);
                myCommand.Parameters.AddWithValue("@fileIDParam", fileID);
                myCommand.Parameters.AddWithValue("@userIDParam", userID);
                myCommand.Parameters.AddWithValue("@readParam", readPermission);
                myCommand.Parameters.AddWithValue("@editParam", editPermission);
                myCommand.Parameters.AddWithValue("@downloadParam", downloadPermission);
                myCommand.ExecuteNonQuery();
                con.Close();
                success = true;
            }
            return success;
        }
        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            userSelectedLabel.Text = null;
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                string curItem = userList.SelectedValue.ToString();
                String query = "SELECT * FROM da_schema.Userinfo WHERE userid = @idParam";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idParam", curItem);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userSelectedLabel.Text = reader["fullName"].ToString();
                }
                reader.Close();
                con.Close();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FileManagementHub view = new FileManagement.FileManagementHub();
            view.Show();
            Hide();
        }

        private void applyPermButton_Click(object sender, EventArgs e)
        {
            AddPermissionToDB();
        }
    }
}
