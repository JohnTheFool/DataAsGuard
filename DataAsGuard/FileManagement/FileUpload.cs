using DataAsGuard.CSClass;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAsGuard.FileManagement
{
    public partial class FileUpload : Form
    {
        String fileSourcePath;
        String fileOriginalName;
        byte[] fileBytes = null;

        public FileUpload()
        {
            InitializeComponent();
        }

        private Boolean InsertFileInfoToDB()
        {
            Boolean success = false;
            String ownerName = "";

            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();

                String getUserQuery = "SELECT * FROM Userinfo WHERE userid = @idParam";
                MySqlCommand cmd = new MySqlCommand(getUserQuery, con);
                cmd.Parameters.AddWithValue("@idParam", Logininfo.userid);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ownerName = reader["fullName"].ToString();
                }
                reader.Close();

                if (!CheckIfFileExists(this.fileName.Text))
                { 
                    String executeQuery = "INSERT INTO fileInfo(fileName, fileSize, dateCreated, fileOwnerID, fileOwner, description, file, fileLock) VALUES (@nameParam, @sizeParam, @dateParam, @ownerIDParam, @ownerParam, @descParam, @fileParam, @lockParam)";
                    MySqlCommand myCommand = new MySqlCommand(executeQuery, con);
                    myCommand.Parameters.AddWithValue("@nameParam", this.fileName.Text);
                    myCommand.Parameters.AddWithValue("@sizeParam", this.fileSize.Text);
                    myCommand.Parameters.AddWithValue("@dateParam", DateTime.Now);
                    myCommand.Parameters.AddWithValue("@ownerIDParam", Logininfo.userid);
                    myCommand.Parameters.AddWithValue("@ownerParam", ownerName);
                    myCommand.Parameters.AddWithValue("@descParam", this.fileDescBox.Text);
                    myCommand.Parameters.AddWithValue("@fileParam", fileBytes);
                    myCommand.Parameters.AddWithValue("@lockParam", 0);
                    myCommand.ExecuteNonQuery();
                    con.Close();
                    success = true;
                }
                else
                {
                    MessageBox.Show("File name already exists, please change the name of the file uploaded.");
                }
            }

            return success;
        }
        
        private Boolean CheckIfFileExists(string nameChecked)
        {
            Boolean fileExists = false;
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();

                String getFileQuery = "SELECT * FROM fileInfo WHERE fileName = @nameParam";
                MySqlCommand cmd = new MySqlCommand(getFileQuery, con);
                cmd.Parameters.AddWithValue("@nameParam", nameChecked);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    fileExists = true;
                }
                reader.Close();
            }
            return fileExists;
        }
        private void BrowseButton_click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Word Documents|*.docx|Excel Worksheets|*.xlsx|PowerPoint Presentations|*.pptx|Office Files|*.docx;*.xlsx;*.pptx|All Files|*.*", // allowed file types
                Multiselect = false // allow/deny user to upload more than one file at a time
            };
            if (dialog.ShowDialog() == DialogResult.OK) // if OK clicked
            {
                String path = dialog.FileName; // get name of file
                fileName.Text = dialog.SafeFileName;
                fileOriginalName = dialog.SafeFileName;
                var longSize = new FileInfo(dialog.FileName).Length;
                double size = longSize;
                double KbDivisor = 1024;
                double MbDivisor = 1048576;
                double GbDivisor = 1073741824;
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do something to file
                {
                    fileUploaded.Text = path;
                    if (size < 1024)
                    {
                        fileSize.Text = size.ToString() + "B";
                    }
                    else if (size > 1024 && size < 1048576)
                    {
                        size = size / KbDivisor;
                        size = Math.Round(size, 1);
                        fileSize.Text = size.ToString() + "KB";
                    }
                    else if (size > 1048576 && size < 1073741824)
                    {
                        size = size / MbDivisor;
                        size = Math.Round(size, 1);
                        fileSize.Text = size.ToString() + "MB";
                    }
                    else if (size > 1073741824)
                    {
                        size = size / GbDivisor;
                        size = Math.Round(size, 1);
                        fileSize.Text = size.ToString() + "GB";
                    }
                }
                fileSourcePath = path;

                try
                {
                    fileBytes = File.ReadAllBytes(path);
                }
                catch (IOException)
                {
                    MessageBox.Show("Error file could not be read, please try again.");
                }  
            }
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            if (fileName.Text != fileOriginalName) //If file name is changed
            {
                DialogResult dialogResult = MessageBox.Show("The name of the file has been changed, changing the file extension may result in the file being corrupted, do you want to proceed?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (InsertFileInfoToDB())
                    {
                        MessageBox.Show("File successfully uploaded.");
                    }
                }
                
            }
            else
            {
                if (InsertFileInfoToDB())
                {
                    MessageBox.Show("File successfully uploaded.");
                }
            }

            FileUpload refresh = new FileUpload();
            refresh.Show();
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Home view = new Home();
            view.Show();
            Hide();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Home view = new Home();
            view.Show();
            Hide();
        }
    }
}
