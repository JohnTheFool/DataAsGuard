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

namespace DataAsGuard.Editor
{
    public partial class EditorForm : Form
    {
        public EditorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbClass dbCon = new DbClass();
            //string queryStr = "SELECT username FROM da_schema.Userinfo";
            List<string> dataDisplay = new List<string>();
            dataDisplay = dbCon.DbRetrieve("Userinfo", "username");
            MessageBox.Show("Connection Open ! ");
            foreach (string i in dataDisplay)
            {
                MessageBox.Show(i);
            }
        }
    }
}
