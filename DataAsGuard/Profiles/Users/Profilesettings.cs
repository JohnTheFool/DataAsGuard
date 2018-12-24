using DataAsGuard.CSClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAsGuard.Profiles.Users
{
    public partial class Profilesettings : Form
    {
        public Profilesettings()
        {
            InitializeComponent();
        }

        //button navigation
        private void BackButton_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Logininfo.userid = null;
            Logininfo.email = null;
            Logininfo.username = null;
            Login login = new Login();
            login.Show();
            Hide();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            Hide();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Profilesettings settings = new Profilesettings();
            settings.Show();
            Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Hide();
        }
    }
}
