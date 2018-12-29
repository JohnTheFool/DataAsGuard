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
    public partial class FileManagementHub : Form
    {
        public FileManagementHub()
        {
            InitializeComponent();
        }

        private void FileManagementHub_Load(object sender, EventArgs e)
        {

        }

        private void permissionRetrieval()
        {
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {

                con.Open();
                String query = "SELECT * FROM userpermissions";
                MySqlCommand command = new MySqlCommand(query, con);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                    }

                    if (reader != null)
                        reader.Close();
                }

            }
        }

        private void deleteFileButton_Click(object sender, EventArgs e)
        {

        }

        private void manageGroupsButton_Click(object sender, EventArgs e)
        {
            FileManagement.ManageGroups view = new FileManagement.ManageGroups();
            view.Show();
            Hide();
        }

        private void editUserPermButton_Click(object sender, EventArgs e)
        {
            FileManagement.EditUserPermissions view = new FileManagement.EditUserPermissions();
            view.Show();
            Hide();
        }

        private void editGroupPermButton_Click(object sender, EventArgs e)
        {
            FileManagement.EditGroupPermissions view = new FileManagement.EditGroupPermissions();
            view.Show();
            Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Home view = new Home();
            view.Show();
            Hide();
        }
    }
}
