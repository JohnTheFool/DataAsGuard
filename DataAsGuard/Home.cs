using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAsGuard
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showImg(object sender, EventArgs e)
        {
            ImgViewer.ImgViewerForm imgViewerForm = new ImgViewer.ImgViewerForm();
            imgViewerForm.Show();
            Hide();
        }

        private void viewPdf_Click(object sender, EventArgs e)
        {
            PdfViewer.PdfViewer pdfViewerForm = new PdfViewer.PdfViewer();
            pdfViewerForm.Show();
            Hide();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            Profiles.Admin.AdminProfile profile = new Profiles.Admin.AdminProfile();
            profile.Show();
            Hide();
        }

        private void manageFilesButton_Click(object sender, EventArgs e)
        {
            FileManagement.FileManagementHub filePermissions = new FileManagement.FileManagementHub();
            filePermissions.Show();
            Hide();
        }

        private void uploadFileButton_Click(object sender, EventArgs e)
        {
            FileManagement.FileUpload fileUpload = new FileManagement.FileUpload();
            fileUpload.Show();
            Hide();
        }
    }
}
