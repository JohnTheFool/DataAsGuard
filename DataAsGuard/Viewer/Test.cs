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

namespace DataAsGuard.Viewer
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DbClass dbCon = new DbClass();

            List<string> dataDisplay = new List<string>();

            dataDisplay = dbCon.DbRetrieve("Userinfo", "sh_9513");

            foreach(string i in dataDisplay)
            {
                Console.WriteLine(i);
                MessageBox.Show(i);
            }
        }
    }
}
