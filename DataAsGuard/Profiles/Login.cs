using DataAsGuard.CSClass;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        DBLogger dblog = new DBLogger();
        static int FailureAttempts;
        static string FailureEmail;
        static Stopwatch sw = new Stopwatch();
        private static double timeElapsed;

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
            string username = null;

            if (sw.IsRunning == true)
            {
                //only calculate when the account is log or to put a timer inbetween for fail attempts
                timeElapsed = sw.Elapsed.TotalSeconds;
            }

            if (timeElapsed <= 60 && timeElapsed > 0)
            {
                validation.Show();
                validation.ForeColor = Color.Red;
                validation.Text = "Due to multiple failure, Please try again after 1 minute";
            }
            else
            {
                if (Email != "" && password != "")
                {
                    if (Email == "Admin" && password == "Admin")
                    {
                        Logininfo.userid = "admin";
                        dblog.Log("User Login Admin", "LogonSuccess", Logininfo.userid, "Admin");
                        Admin.AdminProfile profile = new Admin.AdminProfile();
                        profile.Show();
                        Hide();
                    }
                    else
                    {
                        using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
                        {
                            con.Open();
                            string selectQuery = "SELECT * FROM Userinfo";
                            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                            MySqlDataReader reader = cmd.ExecuteReader();
                            while (reader.HasRows && reader.Read())
                            {

                                if (Email == aes.Decryptstring(reader.GetString(reader.GetOrdinal("email")), reader.GetString(reader.GetOrdinal("userid"))))
                                {
                                    userid = reader.GetInt32(reader.GetOrdinal("userid"));
                                    username = reader.GetString(reader.GetOrdinal("username"));
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
                    }

                    //check if the email can be found in db
                    if (befencryptedemail == null || befencryptedemail == "")
                    {
                        validation.Show();
                        validation.ForeColor = Color.Red;
                        validation.Text = "Incorrect Email or Password.";
                        FailureAttempts += 1;
                        if (FailureAttempts > 3)
                        {
                            sw.Start();
                            FailureAttempts = 0;
                        }
                        //log wrong password attempts on wrong email.
                        dblog.Log("Failure Login User (Wrong Email): " + Email, "LogonFailure", "null", "null");
                    }
                    //if email found check if it is lock and correct password
                    else
                    {
                        if (checkvflag == "L")
                        {
                            validation.Show();
                            validation.ForeColor = Color.Red;
                            validation.Text = "Your Account has been Lock due to Suspicious Activity.";
                            dblog.Log("Attempt to logon to lock account" + Email, "LogonFailure", userid.ToString(), username);
                        }
                        else
                        {
                            //retrieve in case of failure for locking the account
                            FailureEmail = befencryptedemail;
                            //comparing passwords
                            byte[] hashBytes = Convert.FromBase64String(hashpassword);
                            //retrieve salt from stored hash
                            byte[] salt = new byte[16];
                            Array.Copy(hashBytes, 0, salt, 0, 16);
                            /* Compute the hash on the password the user entered */
                            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 2000);
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
                                    //log if wrong password for particular user.
                                    dblog.Log("Failure Login User (Wrong Password): " + Email, "LogonFailure", userid.ToString(), username);
                                    //if Failure for consecutive same email with wrong password
                                    if (FailureEmail == Email)
                                    {
                                        FailureAttempts += 1;
                                    }
                                    else if (FailureEmail != Email)
                                    {
                                        FailureAttempts = 0;
                                    }

                                    //More than 3 failures at one Session 
                                    if (FailureAttempts > 3)
                                    {
                                        sw.Start();
                                        //lock account
                                        LockAccount(userid);
                                        dblog.Log("User Account Locked due to Multiple Failures: " + Email, "LogonFailure", userid.ToString(), username);
                                    }
                                    break;
                                }
                            }
                        }
                    }

                    if (passwordcheck == 1 && Email == befencryptedemail)
                    {
                        //F if have not change passwords
                        if (checkvflag == "F")
                        {

                            Logininfo.userid = userid.ToString();
                            dblog.Log("First Time Login User: " + Email, "LogonSuccess", Logininfo.userid, username);
                            Users.ConfirmationDetails register = new Users.ConfirmationDetails(); // If status is Not completed
                            register.Show();
                            Hide();
                        }
                        //T if have verification and change password.
                        else if (checkvflag == "T")
                        {
                            Logininfo.userid = userid.ToString();
                            dblog.Log("Login User: " + Email, "LogonSuccess", Logininfo.userid, username);
                            Users.Profile profile = new Users.Profile();
                            profile.Show();
                            Hide();
                        }
                        else if (checkvflag == "L")
                        {
                            validation.Show();
                            validation.ForeColor = Color.Red;
                            validation.Text = "Your Account has been Lock due to Suspicious Activity.";
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

       public void LockAccount(int userid)
       {
            //UPDATE PASSWORD TO DATABASE
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                string queryStr = "";
                queryStr = "UPDATE Userinfo set verificationflag=@vflag where userid = @userid";

                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, con);
                cmd.Parameters.AddWithValue("@vflag", "L");
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.ExecuteReader();
                con.Close();
            }
       }
    }
}
