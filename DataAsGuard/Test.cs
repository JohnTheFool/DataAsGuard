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
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                cn.Open();
                MessageBox.Show("Open");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scantest();
        }

        private async void scantest()
        {
            var clam = new ClamClient("35.247.184.223", 3310);
            var scanResult = await clam.ScanFileOnServerAsync("C:\\Users\\Desmond\\Downloads\\PokeMMO.zip");  //any file you would like!

            switch (scanResult.Result)
            {
                case ClamScanResults.Clean:
                    Console.WriteLine("The file is clean!");
                    break;
                case ClamScanResults.VirusDetected:
                    Console.WriteLine("Virus Found!");
                    Console.WriteLine("Virus name: {0}", scanResult.InfectedFiles.First().VirusName);
                    break;
                case ClamScanResults.Error:
                    Console.WriteLine("Woah an error occured! Error: {0}", scanResult.RawResult);
                    break;
            }
        }
    }
}
