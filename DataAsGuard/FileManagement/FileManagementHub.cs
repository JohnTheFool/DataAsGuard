using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
                    //Retrieve file info from DB
                    String fileInfoquery = "SELECT * FROM fileInfo WHERE fileName = @nameParam";
                    MySqlCommand fileInfocmd = new MySqlCommand(fileInfoquery, con);
                    fileInfocmd.Parameters.AddWithValue("@nameParam", curItem);
                    MySqlDataReader reader = fileInfocmd.ExecuteReader();
                    if (reader.Read())
                    {
                        fileInformation.AppendText("Date Created: " + reader["dateCreated"].ToString());
                        fileInformation.AppendText(Environment.NewLine + "File Owner: " + reader["fileOwner"].ToString());
                        fileInformation.AppendText(Environment.NewLine + "File Description: " + reader["description"].ToString());
                    }
                    reader.Close();
                    //Add in check if permissions below in the future
                    editUserPermButton.Enabled = true;
                    editGroupPermButton.Enabled = true;
                    openFileButton.Enabled = true;
                    deleteFileButton.Enabled = true;
                }
                catch (NullReferenceException)
                {
                    //Do nothing
                }
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            string nameOfFile = fileList.SelectedItem.ToString();
            string fileExtension = Path.GetExtension(nameOfFile);
            string tempFileName = System.IO.Path.GetTempFileName() + "." + fileExtension;
            byte[] fileBytes = new byte[] { 0x0 };
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String fileQuery = "SELECT * FROM fileInfo WHERE fileName = @nameParam";
                MySqlCommand getFilecmd = new MySqlCommand(fileQuery, con);
                getFilecmd.Parameters.AddWithValue("@nameParam", fileList.SelectedItem.ToString());
                MySqlDataReader reader = getFilecmd.ExecuteReader();
                if (reader.Read())
                {
                    fileBytes = (byte[])reader["file"];
                }
                reader.Close();
            }
            File.WriteAllBytes(tempFileName, fileBytes);
            var process = Process.Start(tempFileName);
            process.Exited += (s , ev) => File.Delete(tempFileName);
        }
        private void deleteFileButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete the selected file " + fileList.SelectedItem.ToString() + "?", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //delete from DB
            }
            else if (dialogResult == DialogResult.No)
            {
                //nothing
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
            FileManagement.EditGroupPermissions view = new FileManagement.EditGroupPermissions(fileList.SelectedItem.ToString());
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

        private void fileDoubleClick(object sender, MouseEventArgs e)
        {
            //int index = this.fileList.IndexFromPoint(e.Location);
            //if (index != System.Windows.Forms.ListBox.NoMatches)
            //{
                //For changing back to original file
                //Directory.CreateDirectory(Path.GetDirectoryName(fileName));
                //using (Stream file = File.Create(fileName))
                //{
                //file.Write(buffer, 0, buffer.Length);
                //}

                //Opening the file
                //Process process = new Process();
                //process.StartInfo.FileName = path;
                //process.Start();
                //using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
                //{
                //    byte[] buffer;
                //    con.Open();
                //    string curItem = fileList.SelectedItem.ToString();
                //    //Retrieve group info from DB
                //    String groupInfoquery = "SELECT * FROM fileInfo WHERE fileLock = @nameParam";
                //    MySqlCommand groupInfocmd = new MySqlCommand(groupInfoquery, con);
                //    groupInfocmd.Parameters.AddWithValue("@nameParam", curItem);
                //    MySqlDataReader reader = groupInfocmd.ExecuteReader();
                //    if (reader.Read())
                //    {
                //        buffer = (byte[])reader["file"];
                //        if (reader["fileLock"].ToString() == "1")
                //        {
                //            MessageBox.Show("File is in use!");
                //        }
                //        else
                //        {
                            
                //            Directory.CreateDirectory(Path.GetDirectoryName(reader["fileName"].ToString()));
                //            using (Stream file = File.Create(reader["fileName"].ToString()))

                //            {
                //                file.Write(buffer, 0, buffer.Length);
                //            }
                //            var applicationWord = new Microsoft.Office.Interop.Word.Application();
                //            applicationWord.Visible = true;
                //            applicationWord.Documents.Open(file);
                //        }
                //    }
                //    reader.Close();
                //}

            //}
        }
    }
}
