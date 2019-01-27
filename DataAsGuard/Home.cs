using DataAsGuard.CSClass;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Profiles.Users.Profilesettings userprofileSettings = new Profiles.Users.Profilesettings();
            userprofileSettings.Show();
            Hide();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Hide();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            Profiles.Users.Profile profile = new Profiles.Users.Profile();
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
    }
}
