﻿using DataAsGuard.CSClass;
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
        byte[] fileBytes = null;
        DBLogger dblog = new DBLogger();
        string fileID;
        string flag;

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

                String executeQuery = "INSERT INTO fileInfo(fileName, fileSize, dateCreated, fileOwnerID, fileOwner, description, file) VALUES (@nameParam, @sizeParam, @dateParam, @ownerIDParam, @ownerParam, @descParam, @fileParam)";
                
                MySqlCommand myCommand = new MySqlCommand(executeQuery, con);
                myCommand.Parameters.AddWithValue("@nameParam", this.fileName.Text);
                myCommand.Parameters.AddWithValue("@sizeParam", this.fileSize.Text);
                myCommand.Parameters.AddWithValue("@dateParam", DateTime.Now);
                myCommand.Parameters.AddWithValue("@ownerIDParam", Logininfo.userid);
                myCommand.Parameters.AddWithValue("@ownerParam", ownerName);
                myCommand.Parameters.AddWithValue("@descParam", this.fileDescBox.Text);
                myCommand.Parameters.AddWithValue("@fileParam", fileBytes);
                myCommand.ExecuteNonQuery();
                
                String query = "SELECT * FROM fileInfo where fileName = @fileName AND dateCreated = @dateCreated AND fileOwnerID=@fileowner;";
                MySqlCommand command = new MySqlCommand(query, con);
                myCommand.Parameters.AddWithValue("@fileName", this.fileName.Text);
                myCommand.Parameters.AddWithValue("@dateCreated",DateTime.Now);
                myCommand.Parameters.AddWithValue("@fileowner", Logininfo.userid);
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        fileID = reader.GetString(reader.GetOrdinal("fileID"));

                    }

                    if (reader != null)
                        reader.Close();
                }

                con.Close();
                success = true;
            }

            return success;
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
            else
            {
                if (InsertFileInfoToDB())
                {
                    dblog.fileLog("File Successfully Uploaded", "UploadsSuccess", Logininfo.userid, Logininfo.email, fileID);
                    MessageBox.Show("File successfully uploaded.");
                }
            }
        }

        //antivirus
        private async void scantest(string filepath)
        {
            var clam = new ClamClient("13.76.89.213", 3310);
            //var scanResult = await clam.ScanFileOnServerAsync("C:\\Users\\Desmond\\Downloads\\TeamViewer_Setup.exe");  //any file you would like!
            var scanResult = await clam.SendAndScanFileAsync(filepath);

            switch (scanResult.Result)
            {
                case ClamScanResults.Clean:
                    Console.WriteLine("The file is clean!");
                    //MessageBox.Show("The file is clean");
                    flag = "C";
                    break;
                case ClamScanResults.VirusDetected:
                    Console.WriteLine("Virus Found!");
                    Console.WriteLine("Virus name: {0}", scanResult.InfectedFiles.First().VirusName);
                    MessageBox.Show("Virus Found! Virus name: {0}", scanResult.InfectedFiles.First().VirusName);
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
    }
}
