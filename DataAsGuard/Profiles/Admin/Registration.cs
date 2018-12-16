using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAsGuard.Profiles.Admin
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Shown(Object sender, EventArgs e)
        {
            validateEmail.Hide();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            RegistrationDetails registrationDetails = new RegistrationDetails();
            registrationDetails.Show();
            Hide();
        }

        //validateEmail
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var regex = "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
            Match match = Regex.Match(textBox1.Text, regex, RegexOptions.IgnoreCase);
            if (textBox1.Text == string.Empty)
            {
                //"Please insert a proper email",
                validateEmail.Show();
                validateEmail.ForeColor = Color.Red;
                validateEmail.Text = "Please a proper email";
            }
            else if (textBox1.Text != string.Empty && !match.Success)
            {
                //"Please insert a proper email",
                validateEmail.Show();
                validateEmail.ForeColor = Color.Red;
                validateEmail.Text = "Please insert a proper email";
            }
            else if (textBox1.Text != string.Empty && match.Success)
            {
                //"Please insert a proper email",
                validateEmail.Show();
                validateEmail.ForeColor = Color.ForestGreen;
                validateEmail.Text = "Email Validated";
            }
        }
    }
}

