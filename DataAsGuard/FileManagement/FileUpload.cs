using DataAsGuard.CSClass;
using DataAsGuard.Profiles.Users;
using MySql.Data.MySqlClient;
using nClam;
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
        String path;
        byte[] fileBytes = null;
        DBLogger dblog = new DBLogger();
        string fileID;
        string flag;

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
                    if (fileName.Text.Length < 100)
                    {
                        if (flag == "C")
                        {
                            try
                            {
                                fileBytes = File.ReadAllBytes(path);

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

                                String query = "SELECT * FROM fileInfo where fileName = @fileName AND fileOwnerID=@fileowner;";
                                MySqlCommand command = new MySqlCommand(query, con);
                                command.Parameters.AddWithValue("@fileName", this.fileName.Text);
                                command.Parameters.AddWithValue("@fileowner", Logininfo.userid);
                                using (reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        fileID = reader.GetString(reader.GetOrdinal("fileID"));
                                    }

                                    if (reader != null)
                                        reader.Close();

                                }

                                String executePermQuery = "INSERT INTO userFilePermissions VALUES (@fileParam, @idParam, @readParam, @editParam, @downloadParam)";
                                MySqlCommand myPermCommand = new MySqlCommand(executePermQuery, con);
                                myPermCommand.Parameters.AddWithValue("@fileParam", fileID);
                                myPermCommand.Parameters.AddWithValue("@idParam", Logininfo.userid);
                                myPermCommand.Parameters.AddWithValue("@readParam", 1);
                                myPermCommand.Parameters.AddWithValue("@editParam", 1);
                                myPermCommand.Parameters.AddWithValue("@downloadParam", 1);
                                myPermCommand.ExecuteNonQuery();

                                success = true;

                            }
                            catch (IOException)
                            {
                                //might change this : Desmond
                                //dblog.Log("File cannot be read (" + fileOriginalName + ")", "UploadsFailed", Logininfo.userid, Logininfo.email);
                                MessageBox.Show("Error file could not be read, please try again.");
                            }
                        }
                        else if (flag == "V")
                        {
                            //would like to hide or disable upload but now just show 
                            MessageBox.Show("Virus File Detected!");
                        }
                        else if (flag == "E")
                        {
                            MessageBox.Show("Error has Occurred");
                        }
                        
                    }
                    else //File Name longer than 100
                    {
                        MessageBox.Show("File name cannot be longer than 100 characters.");
                    }
                }
				
                else //File name already exists in database
                {
                    MessageBox.Show("File name already exists, please change the name of the file uploaded.");
                }

                con.Close();
            }

            if (success)
            {
                dblog.fileLog("File '" + this.fileName.Text + "' uploaded to database.", "FileActions", Logininfo.userid.ToString(), Logininfo.email.ToString(), fileID.ToString());
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
            uploadButton.Enabled = false;
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Text|*.txt|JPG|*.jpg|Portable Network Graphics|*.png|MPEG Layer-4 Audio|*.mp4|Word Documents|*.docx|Excel Worksheets|*.xlsx|All Files|*.*", // allowed file types
                Multiselect = false // allow/deny user to upload more than one file at a time
            };
            if (dialog.ShowDialog() == DialogResult.OK) // if OK clicked
            {
                path = dialog.FileName; // get name of file
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
                scantest(path);

                if (flag == "C")
                {
                    try
                    {
                        fileBytes = File.ReadAllBytes(path);
                    }
                    catch (IOException)
                    {
                        //might change this : Desmond
                        //dblog.Log("File cannot be read (" + fileOriginalName + ")", "UploadsFailed", Logininfo.userid, Logininfo.email);
                        MessageBox.Show("Error file could not be read, please try again.");
                    }
                }
                else if (flag == "V")
                {
                    //would like to hide or disable upload but now just show 
                    MessageBox.Show("Virus File Detected!");
                }
                else if(flag == "E")
                {
                    MessageBox.Show("Error has Occurred");
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

                        dblog.fileLog("File Successfully Uploaded", "UploadsSuccess", Logininfo.userid, Logininfo.email, fileID);
                        MessageBox.Show("File successfully uploaded.");
                    }
                }
                
            }
            else //If file name is not changed
            {
                if (InsertFileInfoToDB())
                {
                    dblog.fileLog("File Successfully Uploaded", "UploadsSuccess", Logininfo.userid, Logininfo.email, fileID);
                    MessageBox.Show("File successfully uploaded.");
                }
            }

            FileUpload refresh = new FileUpload();
            refresh.Show();
            this.Close();
        }

        //antivirus
        private async void scantest(string filepath)
        {
            var clam = new ClamClient("13.76.89.213", 3310) {
                MaxStreamSize = 1073741824
            };

            //var scanResult = await clam.ScanFileOnServerAsync("C:\\Users\\Desmond\\Downloads\\TeamViewer_Setup.exe");  //any file you would like!
            var scanResult = await clam.SendAndScanFileAsync(filepath);

            switch (scanResult.Result)
            {
                case ClamScanResults.Clean:
                    Console.WriteLine("The file is clean!");
                    MessageBox.Show("The file is clean");
                    flag = "C";
                    uploadButton.Enabled = true;
                    break;
                case ClamScanResults.VirusDetected:
                    Console.WriteLine("Virus Found!");
                    Console.WriteLine("Virus name: {0}", scanResult.InfectedFiles.First().VirusName);
                    MessageBox.Show("Virus Found! Virus name: " + scanResult.InfectedFiles.First().VirusName);
                    flag = "V";
                    break;
                case ClamScanResults.Error:
                    Console.WriteLine("Woah an error occured! Error: {0}", scanResult.RawResult);
                    MessageBox.Show("Woah an error occured! Error: {0}", scanResult.RawResult);
                    flag = "E";
                    break;
            }
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

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            Profile view = new Profile();
            view.Show();
            Hide();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Profilesettings view = new Profilesettings();
            view.Show();
            Hide();
        }
    }
}
