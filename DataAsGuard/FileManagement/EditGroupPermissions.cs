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
    public partial class EditGroupPermissions : Form
    {
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();
        string fileNameRefer;
        int fileID = 0;
        DBLogger dblog = new DBLogger();

        public EditGroupPermissions(String fileName)
        {
            InitializeComponent();
            fileEditedLabel.Text = fileName;
            fileNameRefer = fileName;
        }

        private void EditGroupPermissions_Load(object sender, EventArgs e)
        {
            //Load user list
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                adapter = new MySqlDataAdapter("SELECT * FROM da_schema.groupInfo", con);
                adapter.Fill(table);
                groupList.DataSource = table;
                groupList.DisplayMember = "groupName";
                groupList.ValueMember = "groupID";

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
                int groupID = 0;

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

                String getUserIDQuery = "SELECT * FROM groupInfo WHERE groupName = @groupNameParam";
                MySqlCommand getgroupidcmd = new MySqlCommand(getUserIDQuery, con);
                getgroupidcmd.Parameters.AddWithValue("@groupNameParam", groupSelectedLabel.Text);
                MySqlDataReader reader2 = getgroupidcmd.ExecuteReader();
                if (reader2.Read())
                {
                    groupID = Convert.ToInt32(reader2["groupID"]);
                }
                reader2.Close();

                //If group's permission for this file already exists, delete old permission and insert new permission
                Boolean permissionExists = false;
                string getPermissionQuery = "SELECT * FROM groupFilePermissions WHERE fileID = @fileIDParam AND groupID = @groupIDParam";
                MySqlCommand getPermissionCmd = new MySqlCommand(getPermissionQuery, con);
                getPermissionCmd.Parameters.AddWithValue("@fileIDParam", fileID);
                getPermissionCmd.Parameters.AddWithValue("@groupIDParam", groupID);
                MySqlDataReader reader3 = getPermissionCmd.ExecuteReader();
                if (reader3.Read())
                {
                    permissionExists = true;
                }
                reader3.Close();

                if (permissionExists)
                {
                    string deletePermQuery = "DELETE FROM groupFilePermissions WHERE fileID = @fileIDParam AND groupID = @groupIDParam";
                    MySqlCommand deletePermCmd = new MySqlCommand(deletePermQuery, con);
                    deletePermCmd.Parameters.AddWithValue("@fileIDParam", fileID);
                    deletePermCmd.Parameters.AddWithValue("@groupIDParam", groupID);
                    deletePermCmd.ExecuteNonQuery();
                }

                String executeQuery = "INSERT INTO groupFilePermissions(fileID, groupID, readPermission, editPermission, downloadPermission) VALUES (@fileIDParam, @groupIDParam, @readParam, @editParam, @downloadParam)";
                MySqlCommand myCommand = new MySqlCommand(executeQuery, con);
                myCommand.Parameters.AddWithValue("@fileIDParam", fileID);
                myCommand.Parameters.AddWithValue("@groupIDParam", groupID);
                myCommand.Parameters.AddWithValue("@readParam", readPermission);
                myCommand.Parameters.AddWithValue("@editParam", editPermission);
                myCommand.Parameters.AddWithValue("@downloadParam", downloadPermission);
                myCommand.ExecuteNonQuery();
                con.Close();
                success = true;
            }
            if (success)
            {
                dblog.fileLog("Edited group permissions for file '" + fileNameRefer + "'.", "FileChanges", Logininfo.userid.ToString(), Logininfo.email.ToString(), fileID.ToString());
            }
            return success;
        }

        private void groupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupSelectedLabel.Text = null;
            int groupID = 0;
            permissionCheckBox.SetItemChecked(0, false);
            permissionCheckBox.SetItemChecked(1, false);
            permissionCheckBox.SetItemChecked(2, false);

            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                string curItem = groupList.SelectedValue.ToString();
                String query = "SELECT * FROM da_schema.groupInfo WHERE groupID = @idParam";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idParam", curItem);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    groupSelectedLabel.Text = reader["groupName"].ToString();
                }
                reader.Close();

                String getGroupIDQuery = "SELECT * FROM groupInfo WHERE groupName = @groupNameParam";
                MySqlCommand getgroupidcmd = new MySqlCommand(getGroupIDQuery, con);
                getgroupidcmd.Parameters.AddWithValue("@groupNameParam", groupSelectedLabel.Text);
                MySqlDataReader reader3 = getgroupidcmd.ExecuteReader();
                if (reader3.Read())
                {
                    groupID = Convert.ToInt32(reader3["groupID"]);
                }
                reader3.Close();

                //If user's permission for this file already exists, delete old permission and insert new permission
                string getPermissionQuery = "SELECT * FROM groupFilePermissions WHERE fileID = @fileIDParam AND groupID = @groupIDParam";
                MySqlCommand getPermissionCmd = new MySqlCommand(getPermissionQuery, con);
                getPermissionCmd.Parameters.AddWithValue("@fileIDParam", fileID);
                getPermissionCmd.Parameters.AddWithValue("@groupIDParam", groupID);
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

        private void homeButton_Click(object sender, EventArgs e)
        {
            Home view = new Home();
            view.Show();
            Hide();
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
                MessageBox.Show("Permissions applied.");
            }
        }
    }
}
