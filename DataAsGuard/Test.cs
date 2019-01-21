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


        private void button1_Click(object sender, EventArgs e)
        {
            PdfReader reader = new PdfReader(@"C:\Users\Solomon\Documents\TEST\test.pdf");
            iTextSharp.text.Rectangle size = reader.GetPageSizeWithRotation(1);
            Document document = new Document(size);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(@"C:\Users\Solomon\Documents\TEST\tefe.pdf", FileMode.Create, FileAccess.Write));
            document.AddTitle("Seolhyun");
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
            document.Open();
            PdfContentByte cb = writer.DirectContent;
            for (int pageNumber = 1; pageNumber <= reader.NumberOfPages; pageNumber++)
            {
                document.NewPage();
                PdfImportedPage page = writer.GetImportedPage(reader, pageNumber);
                cb.AddTemplate(page, 0, 0);
            }
            document.Close();

            PdfReader reader2 = new PdfReader(@"C:\Users\Solomon\Documents\TEST\tefe.pdf");
            string s = reader2.Info["Title"];
            MessageBox.Show(s);
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

        //protected string GetIPAddress()
        //{
        //    string myHost = Dns.GetHostName();
        //    //string myIP = Dns.GetHostByName(myHost).AddressList[0].ToString();

        //    return myIP;
        //}
    }
}
