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
    public partial class EditUserPermissions : Form
    {

        MySqlDataAdapter adapter;
        DataTable table = new DataTable();
        int fileID = 0;
        string fileNameRefer;
        DBLogger dblog = new DBLogger();

        public EditUserPermissions(String fileName)
        {
            InitializeComponent();
            fileEditedLabel.Text = fileName;
            fileNameRefer = fileName;
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

                String getFileIDQuery = "SELECT * FROM fileInfo WHERE fileName = @fileNameParam";
                MySqlCommand getfileidcmd = new MySqlCommand(getFileIDQuery, con);
                getfileidcmd.Parameters.AddWithValue("@fileNameParam", fileNameRefer);
                MySqlDataReader reader = getfileidcmd.ExecuteReader();
                if (reader.Read())
                {
                    fileID = Convert.ToInt32(reader["fileID"]);
                }
                reader.Close();

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
                int userID = 0;

                if (permissionCheckBox.GetItemCheckState(0) == CheckState.Checked)
                {
                    readPermission = 1;
                }

                if (readPermission == 0)
                {
                    if (permissionCheckBox.GetItemCheckState(1) == CheckState.Checked || permissionCheckBox.GetItemCheckState(2) == CheckState.Checked)
                    {
                        MessageBox.Show("Read permission must be applied to apply edit or download permissions. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return success;
                    }
                }

                else if (readPermission == 1)
                {
                    if (permissionCheckBox.GetItemCheckState(1) == CheckState.Checked)
                    {
                        editPermission = 1;
                    }

                    if (permissionCheckBox.GetItemCheckState(2) == CheckState.Checked)
                    {
                        downloadPermission = 1;
                    }
                }

                String getUserIDQuery = "SELECT * FROM Userinfo WHERE fullName = @fullNameParam";
                MySqlCommand getuseridcmd = new MySqlCommand(getUserIDQuery, con);
                getuseridcmd.Parameters.AddWithValue("@fullNameParam", userSelectedLabel.Text);
                MySqlDataReader reader2 = getuseridcmd.ExecuteReader();
                if (reader2.Read())
                {
                    userID = Convert.ToInt32(reader2["userid"]);
                }
                reader2.Close();

                //If user's permission for this file already exists, delete old permission and insert new permission
                Boolean permissionExists = false;
                string getPermissionQuery = "SELECT * FROM userFilePermissions WHERE fileID = @fileIDParam AND userID = @userIDParam";
                MySqlCommand getPermissionCmd = new MySqlCommand(getPermissionQuery, con);
                getPermissionCmd.Parameters.AddWithValue("@fileIDParam", fileID);
                getPermissionCmd.Parameters.AddWithValue("@userIDParam", userID);
                MySqlDataReader reader3 = getPermissionCmd.ExecuteReader();
                if (reader3.Read())
                {
                    permissionExists = true;
                }
                reader3.Close();

                if (permissionExists)
                {
                    string deletePermQuery = "DELETE FROM userFilePermissions WHERE fileID = @fileIDParam AND userID = @userIDParam";
                    MySqlCommand deletePermCmd = new MySqlCommand(deletePermQuery, con);
                    deletePermCmd.Parameters.AddWithValue("@fileIDParam", fileID);
                    deletePermCmd.Parameters.AddWithValue("@userIDParam", userID);
                    deletePermCmd.ExecuteNonQuery();
                }

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
            if (success)
            {
                dblog.fileLog("Edited user permissions for file '" + fileNameRefer + "'.", "FileChanges", Logininfo.userid.ToString(), Logininfo.email.ToString(), fileID.ToString());
            }
            return success;
        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            userSelectedLabel.Text = null;
            int userID = 0;
            permissionCheckBox.SetItemChecked(0, false);
            permissionCheckBox.SetItemChecked(1, false);
            permissionCheckBox.SetItemChecked(2, false);
            applyPermButton.Enabled = true;

            if (userList.SelectedValue.ToString() == Logininfo.userid)
            {
                MessageBox.Show("Permissions of owner cannot be edited.","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                permissionCheckBox.SetItemChecked(0, true);
                permissionCheckBox.SetItemChecked(1, true);
                permissionCheckBox.SetItemChecked(2, true);

                applyPermButton.Enabled = false;
            }

            else
            {
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

                    String getUserIDQuery = "SELECT * FROM Userinfo WHERE fullName = @fullNameParam";
                    MySqlCommand getuseridcmd = new MySqlCommand(getUserIDQuery, con);
                    getuseridcmd.Parameters.AddWithValue("@fullNameParam", userSelectedLabel.Text);
                    MySqlDataReader reader3 = getuseridcmd.ExecuteReader();
                    if (reader3.Read())
                    {
                        userID = Convert.ToInt32(reader3["userid"]);
                    }
                    reader3.Close();

                    //If user's permission for this file already exists, delete old permission and insert new permission
                    string getPermissionQuery = "SELECT * FROM userFilePermissions WHERE fileID = @fileIDParam AND userID = @userIDParam";
                    MySqlCommand getPermissionCmd = new MySqlCommand(getPermissionQuery, con);
                    getPermissionCmd.Parameters.AddWithValue("@fileIDParam", fileID);
                    getPermissionCmd.Parameters.AddWithValue("@userIDParam", userID);
                    MySqlDataReader reader4 = getPermissionCmd.ExecuteReader();
                    if (reader4.Read())
                    {
                        if (Convert.ToInt32(reader4["readPermission"]) == 1)
                        {
                            permissionCheckBox.SetItemChecked(0, true);
                        }
                        if (Convert.ToInt32(reader4["editPermission"]) == 1)
                        {
                            permissionCheckBox.SetItemChecked(1, true);
                        }
                        if (Convert.ToInt32(reader4["downloadPermission"]) == 1)
                        {
                            permissionCheckBox.SetItemChecked(2, true);
                        }
                    }
                    reader4.Close();

                    con.Close();
                }
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
            if (AddPermissionToDB())
            {
                MessageBox.Show("Permissions applied.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
