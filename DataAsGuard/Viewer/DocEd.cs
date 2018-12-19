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
using DataAsGuard;

namespace DataAsGuard.Viewer
{
    public partial class DocEd : Form
    {
        public DocEd()
        {
            InitializeComponent();
        }

        Color colour = Color.Black;
        bool check = true;
        private void btnSave_Click(object sender, EventArgs e)
        {
            rtfBox.SelectionColor = colour;
            if (check)
                rtfBox.SelectedText = txtValue.Text;
            else
                rtfBox.SelectedText = Environment.NewLine + txtValue.Text;
            check = false;
            txtValue.Clear();
            txtValue.Focus();

            //using(SaveFileDialog sfd = new SaveFileDialog() { Filter="Text Documents;Word Document |*.txt;*.docx", ValidateNames = true })
            //{
            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        using(StreamWriter sw = new StreamWriter(sfd.FileName))
            //        {
            //            await sw.WriteLineAsync(rtfBox.Text);
            //            MessageBox.Show("File Saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
            //}
        }

        private void pColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colour = colorDialog1.Color;
                pColor.BackColor = colour;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Hide();
        }
    }
}
