﻿using MySql.Data.MySqlClient;
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

        public FileUpload()
        {
            InitializeComponent();
        }

        private Boolean InsertFileInfoToDB()
        {
            Boolean success = false;
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {

                con.Open();
                String executeQuery = "INSERT INTO fileInfo(fileName, fileSize, dateCreated, fileOwner, description) VALUES (@nameParam, @sizeParam, @dateParam, @ownerParam, @descParam)";
                    
                MySqlCommand myCommand = new MySqlCommand(executeQuery, con);
                myCommand.Parameters.AddWithValue("@nameParam", this.fileName.Text);
                myCommand.Parameters.AddWithValue("@sizeParam", this.fileSize.Text);
                myCommand.Parameters.AddWithValue("@dateParam", DateTime.Now);
                myCommand.Parameters.AddWithValue("@ownerParam", "Test"); //Logininfo.userid
                myCommand.Parameters.AddWithValue("@descParam", this.fileDescBox.Text);
                myCommand.ExecuteNonQuery();
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
                        System.IO.File.Copy(fileSourcePath, "../../Files/" + fileName.Text);
                        MessageBox.Show("File successfully uploaded.");
                    }
                }
                
            }
            else
            {
                if (InsertFileInfoToDB())
                {
                    System.IO.File.Copy(fileSourcePath, "../../Files/" + fileName.Text);
                    MessageBox.Show("File successfully uploaded.");
                }
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
