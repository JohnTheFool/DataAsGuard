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
    public partial class confirmationOTP : Form
    {
        public confirmationOTP()
        {
            InitializeComponent();
        }

        private void OTPConfirm_Click(object sender, EventArgs e)
        {
            Profile registerOTP = new Profile();
            registerOTP.Show();
            Hide();
        }
    }
}
