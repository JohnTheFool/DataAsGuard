using DataAsGuard.CSClass;
using DataAsGuard.Profiles;
using DataAsGuard.Profiles.Admin;
using Steganography;
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

namespace DataAsGuard.Viewer
{
    public partial class MetaAdmin : Form
    {
        public MetaAdmin()
        {
            InitializeComponent();
        }
        private Bitmap bmp = null;

        private void readMeta(string fileName)
        {
            // Read File extended properties
            List<string> arrHeaders = new List<string>();
            List<Tuple<int, string, string>> attributes = new List<Tuple<int, string, string>>();

            Shell32.Shell shell = new Shell32.Shell();
            Shell32.Folder objFolder = shell.NameSpace(System.IO.Path.GetDirectoryName(fileName));
            Shell32.FolderItem folderItem = objFolder.ParseName(System.IO.Path.GetFileName(fileName));


            for (int i = 0; i < short.MaxValue; i++)
            {
                string header = objFolder.GetDetailsOf(null, i);
                if (String.IsNullOrEmpty(header))
                    break;
                arrHeaders.Add(header);
            }

            // The attributes list below will contain a tuple with attribute index, name and value
            // Once you know the index of the attribute you want to get, 
            // you can get it directly without looping, like this:
            var Authors = objFolder.GetDetailsOf(folderItem, 20);

            for (int i = 0; i < arrHeaders.Count; i++)
            {
                var attrName = arrHeaders[i];
                var attrValue = objFolder.GetDetailsOf(folderItem, i);
                var attrIdx = i;

                attributes.Add(new Tuple<int, string, string>(attrIdx, attrName, attrValue));
                if (i <= 5 || i == 10 || i == 21 || i == 24 || i == 25 || i == 33)
                {
                    textBox.Text += attrName + ": " + attrValue + Environment.NewLine;
                    //Console.WriteLine("{0}\t{1}: {2}", i, attrName, attrValue);
                    Console.WriteLine("{0}\t{1}: {2}", i + 1, attrName, attrValue);
                }
            }
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            filePath.Clear();
            textBox.Clear();
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Text Documents;Word Docx;PPTX;XLSX;Png;MP4;All |*.txt;*.docx;*pptx;*xlsx;*.png;*mp4;*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = open_dialog.FileName;
                var extension = Path.GetExtension(open_dialog.FileName);
                switch (extension.ToLower())
                {
                    case ".docx":
                        readMeta(open_dialog.FileName);
                        break;
                    case ".xlsx":
                        readMeta(open_dialog.FileName);
                        break;
                    case ".pptx":
                        readMeta(open_dialog.FileName);
                        break;
                    case ".png":
                        string password = "Ilovethispic123";
                        bmp = (Bitmap)Image.FromFile(open_dialog.FileName); ;
                        string extractedText = SteganographyHelper.extractText(bmp);
                        extractedText = Crypto.DecryptStringAES(extractedText, password);
                        textBox.Text = extractedText;
                        break;
                    case ".txt":
                        System.Diagnostics.Process pProcess = new System.Diagnostics.Process();

                        pProcess.StartInfo.UseShellExecute = false;

                        pProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

                        //strCommand is path and file name of command to run
                        pProcess.StartInfo.FileName = "cmd.exe";

                        //strCommandParameters are parameters to pass to program
                        pProcess.StartInfo.Arguments = "/C more < " + open_dialog.FileName + ":DS1";

                        pProcess.StartInfo.UseShellExecute = false;

                        //Set output of program to be written to process output stream
                        pProcess.StartInfo.RedirectStandardOutput = true;

                        //Optional
                        //pProcess.StartInfo.WorkingDirectory = strWorkingDirectory;

                        //Start the process
                        pProcess.Start();

                        //Get program output
                        string strOutput = pProcess.StandardOutput.ReadToEnd();

                        textBox.Text = strOutput;
                        //Wait for process to finish
                        pProcess.WaitForExit();
                        break;
                    case ".mp4":
                        TagLib.File videoFile = TagLib.File.Create(open_dialog.FileName);
                        TagLib.Mpeg4.AppleTag customTag = (TagLib.Mpeg4.AppleTag)videoFile.GetTag(TagLib.TagTypes.Apple);
                        string tokenValue = customTag.GetDashBox("User", "Downloaded");
                        textBox.Text = tokenValue;
                        break;
                    }
                }
            }

        private void Logout_Click(object sender, EventArgs e)
        {
            Logininfo.userid = null;
            Logininfo.email = null;
            Logininfo.username = null;
            Login login = new Login();
            login.Show();
            Hide();
        }

        private void AdminHome_Click(object sender, EventArgs e)
        {
            AdminProfile adminHome = new AdminProfile();
            adminHome.Show();
            Hide();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            AdminProfileSettings settings = new AdminProfileSettings();
            settings.Show();
            Hide();
        }

    }
}
