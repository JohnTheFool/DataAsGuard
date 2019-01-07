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
    }
}
