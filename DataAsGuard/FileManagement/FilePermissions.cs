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
    public partial class FilePermissions : Form
    {
        public FilePermissions()
        {
            InitializeComponent();
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

        private void editPermissionsButton_Click(object sender, EventArgs e)
        {

        }

        private void addPermission_Click(object sender, EventArgs e)
        {

        }

        private void deleteFileButton_Click(object sender, EventArgs e)
        {

        }

        private void manageGroupsButton_Click(object sender, EventArgs e)
        {
            FileManagement.ViewGroups view = new FileManagement.ViewGroups();
            view.Show();
            Hide();
        }
    }
}
