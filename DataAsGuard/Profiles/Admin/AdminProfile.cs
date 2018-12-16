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
            Users.ConfirmationDetails confirmationDetails = new Users.ConfirmationDetails();
            confirmationDetails.Show();
           
            //Registration Registration = new Registration();
            //Registration.Show();
            Hide();
        }
    }
}
