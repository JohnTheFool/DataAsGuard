using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAsGuard.Viewer
{
    public partial class DocEd : Form
    {
        public DocEd()
        {
            InitializeComponent();
        }

        Color colour = Color.Blue;
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
        }

        private void pColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colour = colorDialog1.Color;
                pColor.BackColor = colour;
            }
        }
    }
}
