using DataAsGuard.CSClass;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAsGuard.Profiles
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Shown(Object sender, EventArgs e)
        {
            validation.Hide();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string Email = email.Text;
            string password = Password.Text;     
            AesEncryption aes = new AesEncryption();

            string befencryptedemail = null;
            string hashpassword = null;
            int userid = 0;
            int passwordcheck = 1;
            string checkvflag = null;

            if (Email != "" && password != "")
            {
                using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
                {
                    con.Open();
                    string selectQuery = "SELECT * FROM Userinfo";
                    MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.HasRows && reader.Read())
                    {
                        if(Email == "Admin")
                        {
                            Logininfo.userid = 0;

                            Admin.AdminProfile profile = new Admin.AdminProfile();
                            profile.Show();
                            Hide();
                        }
                        else if(Email == aes.Decryptstring(reader.GetString(reader.GetOrdinal("email")), reader.GetString(reader.GetOrdinal("userid"))))
                        {
                           
                            userid = reader.GetInt32(reader.GetOrdinal("userid"));
                            
                            befencryptedemail = aes.Decryptstring(reader.GetString(reader.GetOrdinal("email")), reader.GetString(reader.GetOrdinal("userid")));
                            //compare hash password
                            hashpassword = reader.GetString(reader.GetOrdinal("password"));
                            checkvflag = reader.GetString(reader.GetOrdinal("verificationflag"));
                            break;
                        }
                        //MessageBox.Show(userbirthdate);
                    }

                    con.Close();
                }

                if(befencryptedemail == null || befencryptedemail == "") {
                    validation.Show();
                    validation.ForeColor = Color.Red;
                    validation.Text = "Incorrect Email or Password.";
                }
                else
                {
                    //comparing passwords
                    byte[] hashBytes = Convert.FromBase64String(hashpassword);
                    //retrieve salt from stored hash
                    byte[] salt = new byte[16];
                    Array.Copy(hashBytes, 0, salt, 0, 16);
                    /* Compute the hash on the password the user entered */
                    var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 5000);
                    byte[] hash = pbkdf2.GetBytes(20);
                    /* Compare the results */
                    for (int i = 0; i < 20; i++)
                    {
                        if (hashBytes[i + 16] != hash[i])
                        {
                            validation.Show();
                            validation.ForeColor = Color.Red;
                            validation.Text = "Incorrect Email or Password.";
                            passwordcheck = 0;
                            break;
                        }
                    }
                }

                if(passwordcheck == 1 && Email == befencryptedemail)
                {
                    //F if have not change passwords
                    if (checkvflag == "F")
                    {
                        Logininfo.userid = userid;

                        Users.ConfirmationDetails register = new Users.ConfirmationDetails(); // If status is Not completed
                        register.Show();
                        Hide();
                    }
                    else
                    {
                        Users.Profile profile = new Users.Profile();
                        profile.Show();
                        Hide();
                    }
                }

            }
            else
            {
                validation.Show();
                validation.ForeColor = Color.Red;
                validation.Text = "Incorrect Email or Password.";
            }
        }

       
    }
}
