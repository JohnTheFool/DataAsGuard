using DataAsGuard.CSClass;
using DataAsGuard.Viewer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAsGuard.Profiles.Users
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void profile_Shown(Object sender, EventArgs e)
        {
            userdataRetrieval();
        }

        private void userdataRetrieval()
        {
            AesEncryption aes = new AesEncryption();

            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM Userinfo WHERE userid=@userid";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@userid", CSClass.Logininfo.userid.ToString());
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Username.Text = aes.Decryptstring(reader.GetString(reader.GetOrdinal("username")), Logininfo.userid.ToString());
                        FName.Text = reader.GetString(reader.GetOrdinal("firstname")) +" "+ reader.GetString(reader.GetOrdinal("lastname"));
                        Contact.Text = "****" + aes.Decryptstring(reader.GetString(reader.GetOrdinal("contact")), Logininfo.userid.ToString()).Substring(4, 4);
                        Email.Text = aes.Decryptstring(reader.GetString(reader.GetOrdinal("email")), Logininfo.userid.ToString());
                        DOB.Text = reader.GetString(reader.GetOrdinal("dob"));
                    }

                    if (reader != null)
                        reader.Close();
                }
            }
        }

        private void chgpass_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword();
            change.Show();
            Hide();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
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

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Profilesettings settings = new Profilesettings();
            settings.Show();
            Hide();
        }

    }
}
