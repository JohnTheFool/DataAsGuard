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

namespace DataAsGuard.PdfViewer
{
    public partial class PdfViewer : Form
    {
        public PdfViewer()
        {
            InitializeComponent();
        }

        private void PdfViewer_Load(object sender, EventArgs e)
        {

        }

        private void pdfOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "PDF|*.pdf" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    axAcroPDF.src = ofd.FileName;
                    axAcroPDF.setShowToolbar(false);
                    axAcroPDF.Show();
                    //System.Diagnostics.Process.Start(ofd.FileName);
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Hide();
        }

        private void openPdf_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "PDF|*.pdf" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    axAcroPDF.src = ofd.FileName;
                    axAcroPDF.setShowToolbar(false);
                    axAcroPDF.Show();
                    //System.Diagnostics.Process.Start(ofd.FileName);
                }
            }
        }
    }
}
