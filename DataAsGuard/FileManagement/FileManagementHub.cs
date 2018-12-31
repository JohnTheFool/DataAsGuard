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
            LoadFileInfoFromDB();
        }

        private void LoadFileInfoFromDB()
        {
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM da_schema.fileInfo";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    fileList.Items.Add(reader["fileName"].ToString());
                }
                reader.Close();
                con.Close();
            }
        }

        private void fileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileInformation.Clear();
            permissionGrid.Rows.Clear();
            permissionGrid.Refresh();
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                try
                {
                    string curItem = fileList.SelectedItem.ToString();
                    //Retrieve group info from DB
                    String groupInfoquery = "SELECT * FROM fileInfo WHERE fileName = @nameParam";
                    MySqlCommand groupInfocmd = new MySqlCommand(groupInfoquery, con);
                    groupInfocmd.Parameters.AddWithValue("@nameParam", curItem);
                    MySqlDataReader reader = groupInfocmd.ExecuteReader();
                    if (reader.Read())
                    {
                        fileInformation.AppendText("Date Created: " + reader["dateCreated"].ToString());
                        fileInformation.AppendText(Environment.NewLine + "File Owner: " + reader["fileOwner"].ToString());
                        fileInformation.AppendText(Environment.NewLine + "File Description: " + reader["description"].ToString());
                    }
                    reader.Close();
                    editUserPermButton.Enabled = true;
                    editGroupPermButton.Enabled = true;
                }
                catch (NullReferenceException)
                {
                    //Do nothing
                }
            }
        }
        private void deleteFileButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete the selected file (name here)?", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void manageGroupsButton_Click(object sender, EventArgs e)
        {
            FileManagement.ManageGroups view = new FileManagement.ManageGroups();
            view.Show();
            Hide();
        }

        private void editUserPermButton_Click(object sender, EventArgs e)
        {
            FileManagement.EditUserPermissions view = new FileManagement.EditUserPermissions(fileList.SelectedItem.ToString());
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

        private void permissionGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
