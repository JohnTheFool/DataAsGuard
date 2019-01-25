using DataAsGuard.CSClass;
using DataAsGuard.FileManagement;
using DataAsGuard.Profiles;
using DataAsGuard.Viewer;
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

        private void button1_Click(object sender, EventArgs e)
        {
            FileUpload fileUpload = new FileUpload();
            fileUpload.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profiles.Login register = new DataAsGuard.Profiles.Login();
            register.Show();
            Hide();
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
            FileManagementHub filePermissions = new FileManagementHub();
            filePermissions.Show();
            Hide();
        }

        private void uploadFileButton_Click(object sender, EventArgs e)
        {
            FileUpload fileUpload = new FileUpload();
            fileUpload.Show();
            Hide();
        }

        private void viewDoc_Click(object sender, EventArgs e)
        {
            Viewer.DocEd docEd = new Viewer.DocEd();
            docEd.Show();
            Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Steganography.Steganography steg = new Steganography.Steganography();
            steg.Show();
            Hide();
        }

        private void watchVideoBtn_Click(object sender, EventArgs e)
        {
            Viewer.VideoPlayer videoView = new Viewer.VideoPlayer();
            videoView.Show();
            Hide();
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            Test testView = new Test();
            testView.Show();
            Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Logininfo.userid = null;
            Logininfo.email = null;
            Logininfo.username = null;
            Login login = new Login();
            login.Show();
            Hide();
        }

        private void Chat_Click(object sender, EventArgs e)
        {
            DataAsGuard.Chat.Chat chat = new DataAsGuard.Chat.Chat();
            chat.Show();
        }

        private void metaAdmin_Click(object sender, EventArgs e)
        {
            MetaAdmin view = new MetaAdmin();
            view.Show();
            Hide();
        }

        private void groupManagerButton_Click(object sender, EventArgs e)
        {
            ManageGroups view = new ManageGroups();
            view.Show();
            Hide();
        }
    }
}
