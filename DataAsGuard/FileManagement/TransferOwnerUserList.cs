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
    public partial class TransferOwnerUserList : Form
    {
        string fileParam = "";
        DBLogger dblog = new DBLogger();
        FileManagementHub formToClose;
        public TransferOwnerUserList(string fileName, FileManagementHub obj)
        {
            InitializeComponent();
            fileParam = fileName;
            formToClose = obj;
        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            transferOwnershipButton.Enabled = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            formToClose.Hide();
            FileManagementHub newForm = new FileManagementHub();
            newForm.Show();
        }

        private void transferOwnershipButton_Click(object sender, EventArgs e)
        {
            string newOwnerName = userList.SelectedItem.ToString();
            int newOwnerID = 0;
            Boolean success = false;
            int fileID = 0;
            DialogResult result = MessageBox.Show("Ownership of the file will be transferred to " + newOwnerName + ", all of your permissions will be removed and transferred to " + newOwnerName+ ". Continue?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
                {
                    con.Open();
                    String getUserIDQuery = "SELECT * FROM Userinfo WHERE fullName = @nameParam";
                    MySqlCommand getUserIdCMD = new MySqlCommand(getUserIDQuery, con);
                    getUserIdCMD.Parameters.AddWithValue("@nameParam", newOwnerName);
                    MySqlDataReader reader = getUserIdCMD.ExecuteReader();
                    if (reader.Read())
                    {
                        newOwnerID = Convert.ToInt32(reader["userid"]);
                    }
                    reader.Close();

                    String getFileIDQuery = "SELECT * FROM fileInfo WHERE fileName = @fileParam";
                    MySqlCommand getFileIDCmd = new MySqlCommand(getFileIDQuery, con);
                    getFileIDCmd.Parameters.AddWithValue("@fileParam", fileParam);
                    MySqlDataReader reader2 = getFileIDCmd.ExecuteReader();
                    if (reader2.Read())
                    {
                        fileID = Convert.ToInt32(reader2["fileID"]);
                    }
                    reader2.Close();

                    String updateOwnerQuery = "UPDATE fileInfo SET fileOwner = @nameParam, fileOwnerID = @IDParam WHERE fileName = @fileParam";
                    MySqlCommand updateOwnerCmd = new MySqlCommand(updateOwnerQuery, con);
                    updateOwnerCmd.Parameters.AddWithValue("@nameParam", newOwnerName);
                    updateOwnerCmd.Parameters.AddWithValue("@IDParam", newOwnerID);
                    updateOwnerCmd.Parameters.AddWithValue("@fileParam", fileParam);
                    updateOwnerCmd.ExecuteNonQuery();

                    String deleteOwnerPerms = "DELETE FROM userFilePermissions WHERE fileID = @fileParam AND userID = @idParam";
                    MySqlCommand deleteOwnercmd = new MySqlCommand(deleteOwnerPerms, con);
                    deleteOwnercmd.Parameters.AddWithValue("@fileParam", fileID);
                    deleteOwnercmd.Parameters.AddWithValue("@idParam", Logininfo.userid);
                    deleteOwnercmd.ExecuteNonQuery();

                    String deleteNewOwnerPerms = "DELETE FROM userFilePermissions WHERE fileID = @fileParam AND userID = @idParam";
                    MySqlCommand deleteNewOwnercmd = new MySqlCommand(deleteNewOwnerPerms, con);
                    deleteNewOwnercmd.Parameters.AddWithValue("@fileParam", fileID);
                    deleteNewOwnercmd.Parameters.AddWithValue("@idParam", newOwnerID);
                    deleteNewOwnercmd.ExecuteNonQuery();

                    String newOwnerPerms = "INSERT INTO userFilePermissions VALUES (@fileParam, @idParam, 1, 1, 1)";
                    MySqlCommand newOwnerPermCmd = new MySqlCommand(newOwnerPerms, con);
                    newOwnerPermCmd.Parameters.AddWithValue("@fileParam", fileID);
                    newOwnerPermCmd.Parameters.AddWithValue("@idParam", newOwnerID);
                    newOwnerPermCmd.ExecuteNonQuery();

                    success = true;
                    con.Close();
                }

                if (success)
                {
                    MessageBox.Show("Successfully transferred ownership of file.");
                    dblog.fileLog("Transferred file ownership to '" + newOwnerName + "'. ID: " + newOwnerID + ".", "FileChanges", Logininfo.userid.ToString(), Logininfo.email.ToString(), fileID.ToString());
                    Hide();
                    formToClose.Hide();
                    FileManagementHub newForm = new FileManagementHub();
                    newForm.Show();
                }
            }
        }

        private void TransferOwnerUserList_Load(object sender, EventArgs e)
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
    }
}
