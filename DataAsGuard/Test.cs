using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAsGuard.DB;
using System.Configuration;
using MySql.Data.MySqlClient;
using nClam;
using System.Diagnostics;

namespace DataAsGuard
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C echo 'SECRET MSG' > C:\\Users\\Solomon\\Documents\\something.txt:SOMETHING";
            process.StartInfo = startInfo;
            process.Start();
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
    }
}
