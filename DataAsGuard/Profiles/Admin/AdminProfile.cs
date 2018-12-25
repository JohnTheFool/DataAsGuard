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

namespace DataAsGuard.Profiles.Admin
{
    public partial class AdminProfile : Form
    {
        public AdminProfile()
        {
            InitializeComponent();
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {

        }

        private void chgpass_Click(object sender, EventArgs e)
        {

        }

        private void AddUsers_Click(object sender, EventArgs e)
        {
            //Users.ConfirmationDetails confirmationDetails = new Users.ConfirmationDetails();
            //confirmationDetails.Show();
           
            Registration Registration = new Registration();
            Registration.Show();
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

        private void AdminHome_Click(object sender, EventArgs e)
        {
            AdminProfile Profiles = new AdminProfile();
            Profiles.Show();
            Hide();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            AdminProfileSettings settings = new AdminProfileSettings();
            settings.Show();
            Hide();
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            AdminChangePassword changePassword = new AdminChangePassword();
            changePassword.Show();
            Hide();
        }
    }
}
