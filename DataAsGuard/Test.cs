using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAsGuard;
using System.Configuration;
using MySql.Data.MySqlClient;
using nClam;
using System.Diagnostics;
using System.Net;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace DataAsGuard
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        public static TagLib.Tag FileTagReader(Stream stream, string fileName)
        {
            //Create a simple file and simple file abstraction
            var simpleFile = new Metadata(fileName, stream);
            var simpleFileAbstraction = new SimpleFileAbstraction(simpleFile);
            /////////////////////

            //Create a taglib file from the simple file abstraction
            var mp3File = TagLib.File.Create(simpleFileAbstraction);

            //Get all the tags
            TagLib.Tag tags = mp3File.Tag;

            //Save and close
            mp3File.Save();
            mp3File.Dispose();

            //Return the tags
            return tags;
        }

        public bool IsFileLock(string filePath)
        {
            FileStream stream = null;
            try
            {
                stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return false;
        }

        private string stupid(string fileName)
        {
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();

                string lockNo = "";
                String fileErmQuery = "SELECT * FROM fileInfo WHERE fileName = @nameParam";
                MySqlCommand getFilecmd = new MySqlCommand(fileErmQuery, con);
                getFilecmd.Parameters.AddWithValue("@nameParam", fileName);
                MySqlDataReader reader = getFilecmd.ExecuteReader();
                if (IsFileLock(@"C:\Users\Solomon\Documents\TEST\shitshit.docx") == true)
                {
                    String fileLockQuery = "UPDATE da_schema.fileInfo SET fileLock = '1' WHERE fileName = @lockNo";
                    MySqlCommand fileLockCmd = new MySqlCommand(fileLockQuery, con);
                    fileLockCmd.Parameters.AddWithValue("@lockNo", fileName);
                    fileLockCmd.ExecuteNonQuery();
                }
                else
                {
                    String fileLockQuery = "UPDATE da_schema.fileInfo SET fileLock = '0' WHERE fileName = @lockNo";
                    MySqlCommand fileLockCmd = new MySqlCommand(fileLockQuery, con);
                    fileLockCmd.Parameters.AddWithValue("@lockNo", fileName);
                    fileLockCmd.ExecuteNonQuery();
                }
                lockNo = reader["fileLock"].ToString();
                return lockNo;
                }
            }

        private string CheckWriteOnly(string userId ,string fileName)
        {
            string isWrite = "";
            string fileId = "";
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String fileIdQuery = "SELECT * FROM da_schema.fileInfo WHERE fileName = @nameParam";
                MySqlCommand getFileIdcmd = new MySqlCommand(fileIdQuery, con);
                getFileIdcmd.Parameters.AddWithValue("@nameParam", fileName);
                MySqlDataReader reader = getFileIdcmd.ExecuteReader();
                if (reader.Read())
                {
                    fileId = reader["fileId"].ToString();
                }
                reader.Close();

                //MessageBox.Show(fileId);

                String fileWritePermQuery = "SELECT * FROM da_schema.userFilePermissions WHERE fileID = @fileParam AND userID = @userIdParam";
                MySqlCommand getFilePermcmd = new MySqlCommand(fileWritePermQuery, con);
                getFilePermcmd.Parameters.AddWithValue("@fileParam", fileId);
                getFilePermcmd.Parameters.AddWithValue("@userIdParam", userId);
                MySqlDataReader reader2 = getFilePermcmd.ExecuteReader();
                if (reader2.Read())
                {
                    isWrite = reader2["editPermission"].ToString();
                }
                //MessageBox.Show(isWrite);
                reader2.Close();
                con.Close();
                return isWrite;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(IsFileLock(@"C:\Users\Solomon\Documents\TEST\somerubbish.xlsx") == true)
            {
                MessageBox.Show("Open");
            }
            else
            {
                MessageBox.Show("Close");
            }
            //PdfReader reader = new PdfReader(@"C:\Users\Solomon\Documents\TEST\test.pdf");
            //iTextSharp.text.Rectangle size = reader.GetPageSizeWithRotation(1);
            //Document document = new Document(size);
            //PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(@"C:\Users\Solomon\Documents\TEST\tefe.pdf", FileMode.Create, FileAccess.Write));
            //document.AddTitle("Seolhyun");
            //document.AddTitle(dt.Rows[0].ItemArray[2].ToString());
            //document.AddSubject(dt.Rows[0].ItemArray[7].ToString());
            //document.AddCreator(dt.Rows[0].ItemArray[9].ToString());
            //document.AddHeader("Document Group", dt.Rows[0].ItemArray[4].ToString());
            //document.AddHeader("Document Name", dt.Rows[0].ItemArray[1].ToString());
            //document.AddHeader("Contributor", dt.Rows[0].ItemArray[3].ToString());
            //document.AddHeader("Function", dt.Rows[0].ItemArray[5].ToString());
            //document.AddHeader("Version", dt.Rows[0].ItemArray[6].ToString());
            //document.AddHeader("Source", dt.Rows[0].ItemArray[8].ToString());
            //document.AddCreator("Scorpus");
            //document.Open();
            //PdfContentByte cb = writer.DirectContent;
            //for (int pageNumber = 1; pageNumber <= reader.NumberOfPages; pageNumber++)
            //{
            //    document.NewPage();
            //    PdfImportedPage page = writer.GetImportedPage(reader, pageNumber);
            //    cb.AddTemplate(page, 0, 0);
            //}
            //document.Close();

            //PdfReader reader2 = new PdfReader(@"C:\Users\Solomon\Documents\TEST\tefe.pdf");
            //string s = reader2.Info["Title"];
            //MessageBox.Show(s);
            //PdfDocument document = PdfReader.Open(@"C:\Users\Solomon\Documents\TEST\test.pdf");
            //document.Info.Author = "ME";
            //document.Save("Result");
            //MessageBox.Show(document.Info.Author);
            //Write metadata into MP4 file
            //TagLib.File videoFile = TagLib.File.Create("C:\\Users\\Solomon\\Documents\\TEST\\DsGKcQRVAAAr_Kb.mp4");
            //TagLib.Mpeg4.AppleTag customTag = (TagLib.Mpeg4.AppleTag)videoFile.GetTag(TagLib.TagTypes.Apple);
            //customTag.SetDashBox("Producer", "Producer1", "value");
            //videoFile.Save();
            //videoFile.Dispose();
            //string tokenValue = customTag.GetDashBox("Producer", "Producer1");
            //MessageBox.Show(tokenValue);
            //TagLib.Tag tags = FileTagReader(song, "C:\\Users\\Solomon\\Documents\\TEST\\DsGKcQRVAAAr_Kb.mp4");

            //Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            //object miss = System.Reflection.Missing.Value;
            //object path = @"C:\Users\Solomon\Documents\TEST\test.docx";
            //object readOnly = true;
            //Microsoft.Office.Interop.Word.Document docs = word.Documents.Open(ref path, ref miss, ref readOnly, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss);
            //string totaltext = "";
            //for (int i = 0; i < docs.Paragraphs.Count; i++)
            //{
            //    totaltext += " \r\n " + docs.Paragraphs[i + 1].Range.Text.ToString();
            //}
            ////MessageBox.Show(totaltext);
            ////Console.WriteLine(totaltext);
            //docs.Close();
            //word.Quit();
            //MessageBox.Show(totaltext);
            //DataAsGuard.Viewer.DocEd dd = new DataAsGuard.Viewer.DocEd();
            //dd.CreateDocument(totaltext);
            //DbClass dbClass = new DbClass();
            //List<string> something = new List<string>();
            //something.Add(dbClass.DbRetrieve("fileInfo", "fileName").ToString());
            //foreach (string i in something)
            //{
            //    MessageBox.Show(i);
            //}
            //string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            //using (MySqlConnection cn = new MySqlConnection(connStr))
            //{
            //    cn.Open();
            //    MessageBox.Show("Open");
            //}
            //MessageBox.Show(System.Security.Principal.WindowsIdentity.GetCurrent().Name);
            //System.Diagnostics.Process process = new System.Diagnostics.Process();
            //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = "/C echo 'SECRET MSG' > C:\\Users\\Solomon\\Documents\\something.txt:SOMETHING";
            //process.StartInfo = startInfo;
            //process.Start();

            //string filePath = @"C:\\Users\\Solomon\\Documents\\test.docx";
            //var file = ShellFile.FromFilePath(filePath);

            //// Read and Write:

            //string[] oldAuthors = file.Properties.System.Author.Value;
            //string oldTitle = file.Properties.System.Title.Value;

            //file.Properties.System.Author.Value = new string[] { "Author #1", "Author #2" };
            //file.Properties.System.Title.Value = "Example Title";

            //// Alternate way to Write:

            //ShellPropertyWriter propertyWriter = file.Properties.GetPropertyWriter();
            //propertyWriter.WriteProperty(SystemProperties.System.Author, new string[] { "Author" });
            //propertyWriter.Close()
        }

        //Write metadata into MP4 file
        //TagLib.File videoFile = TagLib.File.Create("test.mp4");
        //TagLib.Mpeg4.AppleTag customTag = (TagLib.Mpeg4.AppleTag)f.GetTag(TagLib.TagTypes.Apple);
        //customTag.SetDashBox("Producer","Producer1", "value");
        //f.Save();
        //f.Dispose();

        //Write metadata into pddf file
        //PdfDocument document = PdfReader.Open("Test.pdf");
        //document.Info.Author = "ME";
        //document.Save("Result");

        private void button2_Click(object sender, EventArgs e)
        {
            scantest();
        }

        private async void scantest()
        {
            var clam = new ClamClient("13.76.89.213", 3310);
            //var scanResult = await clam.ScanFileOnServerAsync("C:\\Users\\Desmond\\Downloads\\TeamViewer_Setup.exe");  //any file you would like!
            var scanResult = await clam.SendAndScanFileAsync("C:\\Users\\Desmond\\Downloads\\TeamViewer_Setup.exe");

            switch (scanResult.Result)
            {
                case ClamScanResults.Clean:
                    Console.WriteLine("The file is clean!");
                    MessageBox.Show("The file is clean");
                    break;
                case ClamScanResults.VirusDetected:
                    Console.WriteLine("Virus Found!");
                    Console.WriteLine("Virus name: {0}", scanResult.InfectedFiles.First().VirusName);
                    MessageBox.Show("Virus name: {0}", scanResult.InfectedFiles.First().VirusName);
                    break;
                case ClamScanResults.Error:
                    Console.WriteLine("Woah an error occured! Error: {0}", scanResult.RawResult);
                    MessageBox.Show("Woah an error occured! Error: {0}", scanResult.RawResult);
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(GetIPAddress());
        }

        private string GetFileId(string fileName)
        {
            string fileId = "";
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();

                // Get FIle ID
                String fileIdQuery = "SELECT * FROM da_schema.fileInfo WHERE fileName = @nameParam";
                MySqlCommand getFileIdcmd = new MySqlCommand(fileIdQuery, con);
                getFileIdcmd.Parameters.AddWithValue("@nameParam", fileName);
                MySqlDataReader reader = getFileIdcmd.ExecuteReader();
                if (reader.Read())
                {
                    fileId = reader["fileId"].ToString();
                }
                reader.Close();
                //MessageBox.Show("FileID : " + fileId);
            }
            return fileId;
        }

        private List<string> GetGroupId(string userId)
        {
            List<string> groupIdList = new List<string>();
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String grpIdQuery = "SELECT * FROM da_schema.groupUsers WHERE userID = @userParam";
                MySqlCommand getGroupIdcmd = new MySqlCommand(grpIdQuery, con);
                getGroupIdcmd.Parameters.AddWithValue("@userParam", userId);
                MySqlDataReader reader2 = getGroupIdcmd.ExecuteReader();
                //while (reader2.HasRows)
                //{
                while (reader2.Read())
                {
                    groupIdList.Add(reader2["groupID"].ToString());
                }
            }
            return groupIdList;
        }

        private string CheckWriteOnlyGroup(string fileId, string groupId)
        {
            string isWrite = "";
            List<string> groupIdList = new List<string>();
            //string groupId = "";
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();

                // Get FIle ID
                //string fileId = "";
                //String fileIdQuery = "SELECT * FROM da_schema.fileInfo WHERE fileName = @nameParam";
                //MySqlCommand getFileIdcmd = new MySqlCommand(fileIdQuery, con);
                //getFileIdcmd.Parameters.AddWithValue("@nameParam", fileName);
                //MySqlDataReader reader = getFileIdcmd.ExecuteReader();
                //if (reader.Read())
                //{
                //    fileId = reader["fileId"].ToString();
                //}
                //reader.Close();
                //MessageBox.Show("FileID : " + fileId);

                // Get Group ID
                //String grpIdQuery = "SELECT * FROM da_schema.groupUsers WHERE userID = @userParam";
                //MySqlCommand getGroupIdcmd = new MySqlCommand(grpIdQuery, con);
                //getGroupIdcmd.Parameters.AddWithValue("@userParam", userId);
                //MySqlDataReader reader2 = getGroupIdcmd.ExecuteReader();
                ////while (reader2.HasRows)
                ////{
                //while (reader2.Read())
                //{
                //    groupIdList.Add(reader2["groupID"].ToString());
                ////    foreach (string i in groupIdList)
                ////{
                ////MessageBox.Show(reader2["groupID"].ToString());
                ////}
                ////MessageBox.Show("GroupID " + reader2["groupId"].ToString());

                //}
                //reader2.Close();
                //for (int i = 0; i < groupIdList.Count; i++)
                //{
                //    MessageBox.Show("Group ID: " + groupIdList[i]);
                //}
                //}
                //    reader2.Close();
                //    MessageBox.Show(groupIdList.ToString());
                //    MessageBox.Show(groupId);
                //    Get Perms

                String fileWritePermQuery = "SELECT * FROM da_schema.groupFilePermissions WHERE groupID = @groupIdParam AND fileID = @fileIdParam";
                MySqlCommand getFilePermcmd = new MySqlCommand(fileWritePermQuery, con);
                getFilePermcmd.Parameters.AddWithValue("@fileIdParam", fileId);
                //for (int i = 0; i < groupIdList.Count; i++)
                //{
                    getFilePermcmd.Parameters.AddWithValue("@groupIdParam", groupId);
                    MySqlDataReader reader3 = getFilePermcmd.ExecuteReader();
                    if (reader3.Read())
                    {
                        isWrite = reader3["editPermission"].ToString();
                    }
                    //MessageBox.Show("Is Write = " + isWrite);
                    reader3.Close();
                    con.Close();
                    //MessageBox.Show("Group ID: " + isWrite);
                //}
            }
            return isWrite;
            }
        //private Boolean CompareGroupPerms()
        //{
        //    Boolean compare = false;
        //    string fileId = GetFileId("Excel Schedule.xlsx");
        //    List<string> groupId = GetGroupId("4");
        //    //CheckWriteOnlyGroup("4", "Excel Schedule.xlsx");
        //    for (int i = 0; i < groupId.Count; i++)
        //    {
        //        if (CheckWriteOnlyGroup(fileId, groupId[i]) == "True")
        //        {
        //            compare = true;
        //        }
        //        else
        //        {
        //            compare = false;
        //        }
        //    }
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            //if (CompareGroupPerms() == true)
            //{
            //    MessageBox.Show("TRUE");
            //}
            //else
            //{
            //    MessageBox.Show("FALSE");
            //}
            string fileId = GetFileId("Excel Schedule.xlsx");
            List<string> groupId = GetGroupId("4");
            //CheckWriteOnlyGroup("4", "Excel Schedule.xlsx");
            for (int i = 0; i < groupId.Count; i++)
            {
                if (CheckWriteOnlyGroup(fileId, groupId[i]) == "True")
                {
                    MessageBox.Show("TRUE");
                }
                else
                {
                    MessageBox.Show("FALSE");
                }
            }
            //if (CheckWriteOnlyGroup("4", "Excel Schedule.xlsx") == "True" || CheckWriteOnlyGroup("4", "Excel Schedule.xlsx") == "1")
            //{
            //    MessageBox.Show("TRUE");
            //}
            //else if (CheckWriteOnlyGroup("4", "Excel Schedule.xlsx") == "False" || CheckWriteOnlyGroup("4", "Excel Schedule.xlsx") == "0")
            //{
            //    MessageBox.Show("FALSE");
            //}
            //else
            //{
            //    MessageBox.Show("neither TRUE nor FALSE");
            //}

        }

        //protected string GetIPAddress()
        //{
        //    string myHost = Dns.GetHostName();
        //    //string myIP = Dns.GetHostByName(myHost).AddressList[0].ToString();

        //    return myIP;
        //}
    }
}
