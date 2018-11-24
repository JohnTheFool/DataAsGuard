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

namespace DataAsGuard.Profiles.Users
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void chgpass_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword();
            change.Show();
            Hide();
        }

        private void chgpic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.jpg, *.jpeg, *.png"; // allowed file types
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if OK clicked
            {
                String path = dialog.FileName; // get name of file
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do wtv
                {
                    // ...
                }
            }
        }
    }
}
