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
        public TransferOwnerUserList(string fileName)
        {
            InitializeComponent();
            fileParam = fileName;
        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            transferOwnershipButton.Enabled = true;
        }

        private void transferOwnershipButton_Click(object sender, EventArgs e)
        {
            string newOwnerName = userList.SelectedItem.ToString();
            int newOwnerID = 0;
            Boolean success = false;

            DialogResult result = MessageBox.Show("Ownership of the file will be transferred to " + newOwnerName + ". Continue?", "Warning", MessageBoxButtons.YesNo);
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

                    String updateOwnerQuery = "UPDATE fileInfo SET fileOwner = @nameParam, fileOwnerID = @IDParam WHERE fileName = @fileParam";
                    MySqlCommand updateOwnerCmd = new MySqlCommand(updateOwnerQuery, con);
                    updateOwnerCmd.Parameters.AddWithValue("@nameParam", newOwnerName);
                    updateOwnerCmd.Parameters.AddWithValue("@IDParam", newOwnerID);
                    updateOwnerCmd.Parameters.AddWithValue("@fileParam", fileParam);
                    updateOwnerCmd.ExecuteNonQuery();
                    success = true;
                    con.Close();
                }

                if (success)
                {
                    MessageBox.Show("Successfully transferred ownership of file.");
                    Hide();
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
