using DataAsGuard.CSClass;
using DataAsGuard.Profiles.Admin;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
        static string FailedUsername;
        static Stopwatch sw = new Stopwatch();
        private static double timeElapsed;
        static int failedLockCounter;
        ArrayList array = new ArrayList();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Shown(Object sender, EventArgs e)
        {
            validation.Hide();
            this.KeyPreview = true;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                loginbutton.PerformClick();
            }
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = Password.Text;     
            AesEncryption aes = new AesEncryption();

            string befencryptedUsername = null;
            string hashpassword = null;
            int userid = 0;
            int passwordcheck = 1;
            string email = null;
            string checkvflag = null;
            string fname = null;
            string lname = null;
            string ipaddress = null;

            ArrayList iplist = GetAuthoriseIPAddressList();

            if (sw.IsRunning == true)
            {
                //only calculate when the account is log or to put a timer inbetween fail attempts
                timeElapsed = sw.Elapsed.TotalSeconds;
                if(timeElapsed > 1800)
                {
                    sw.Stop();
                    FailureAttempts = 0;
                    failedLockCounter = 0;
                    array.Clear();
                }
            }

            if (failedLockCounter == 1 && (timeElapsed <= 60 && timeElapsed > 0))
            {
                validation.Show();
                validation.ForeColor = Color.Red;
                validation.Text = "Due to multiple failure, Please try again after 1 minute";
            }
            else if (failedLockCounter == 2 && (timeElapsed <= 180 && timeElapsed > 0))
            {
                validation.Show();
                validation.ForeColor = Color.Red;
                validation.Text = "Due to multiple failure, Please try again after 3 minute";
            }
            else if (failedLockCounter == 3 && (timeElapsed <= 300 && timeElapsed > 0))
            {
                validation.Show();
                validation.ForeColor = Color.Red;
                validation.Text = "Due to multiple failure, Please try again after 5 minute";
            }
            else
            {
                if (username != "" && password != "")
                {
                    try
                    {
                        using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
                        {
                            con.Open();
                            string selectQuery = "SELECT * FROM Userinfo";
                            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                            MySqlDataReader reader = cmd.ExecuteReader();
                            while (reader.HasRows && reader.Read())
                            {
                                if (username == aes.Decryptstring(reader.GetString(reader.GetOrdinal("username")), reader.GetString(reader.GetOrdinal("userid"))))
                                {
                                    userid = reader.GetInt32(reader.GetOrdinal("userid"));
                                    befencryptedUsername = aes.Decryptstring(reader.GetString(reader.GetOrdinal("username")), reader.GetString(reader.GetOrdinal("userid")));
                                    email = aes.Decryptstring(reader.GetString(reader.GetOrdinal("email")), reader.GetString(reader.GetOrdinal("userid")));
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
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        dblog.Log(ex.ToString(), "Error", "Null", "Null");
                    }
                    
                    //check if the email can be found in db
                    if (befencryptedUsername == null || befencryptedUsername == "")
                    {
                        validation.Show();
                        validation.ForeColor = Color.Red;
                        validation.Text = "Incorrect Email or Password.";
                        FailureAttempts = 0;
                        //if fail logon due to password with username
                        //Add username into array which act as a counter if more than 6 of the same username appear in the array that the user key in the text field
                        array.Add(username);
                        for(int i=0; i < array.Count; i++)
                        {
                            //code feels weird cause the if condition runs only at the latest addition
                            if (array[i].ToString() == username)
                            {
                                FailureAttempts += 1;
                            }
                        }
                        if (FailureAttempts > 6)
                        {
                            for (int i = array.Count-1; i >= 0; i--)
                            {
                                if(array[i].ToString() == username)
                                {
                                    array.RemoveAt(i);
                                }
                            }
                            if (sw.IsRunning)
                            {
                                sw.Reset();
                            }
                            else
                            {
                                sw.Start();
                            }
                            failedLockCounter += 1;
                            FailureAttempts = 0;
                        }
                        //log wrong password attempts on wrong username.
                        dblog.Log("Failure to Login User (Wrong username): " + username, "LogonFailure", "null", "null");
                    }
                    //if email found, check if it is lock account and whether it has the correct password
                    else
                    {
                        if (checkvflag == "L")
                        {
                            validation.Show();
                            validation.ForeColor = Color.Red;
                            validation.Text = "Your Account has been Lock due to Suspicious Activity.";
                            dblog.Log("Attempt to logon to lock account" + username, "LogonFailure", userid.ToString(), email);
                        }
                        else
                        {
                            //retrieve in case of failure for locking the account
                            FailedUsername = befencryptedUsername;
                            //comparing passwords
                            byte[] hashBytes = Convert.FromBase64String(hashpassword);
                            //retrieve salt from stored hash
                            byte[] salt = new byte[16];
                            Array.Copy(hashBytes, 0, salt, 0, 16);
                            /* Compute the hash on the password the user entered */
                            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 2000);
                            byte[] hash = pbkdf2.GetBytes(20);
                            FailureAttempts = 0;
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
                                    dblog.Log("Failure to Login User (Wrong Password): " + username, "LogonFailure", userid.ToString(), email);

                                    //if fail logon due to password with username
                                    //Add username into array which act as a counter if more than 6 of the same username appear in the array that the user key in the text field
                                    array.Add(username);
                                    for (int u = 0; u < array.Count; u++)
                                    {
                                        //code feels weird cause the if condition runs only at the latest addition
                                        if (array[u].ToString() == username)
                                        {
                                            FailureAttempts += 1;
                                        }
                                    }
                                    //More than 6 failures at one Session 
                                    if (FailureAttempts > 6)
                                    {
                                        if (userid == 1)
                                        {

                                        }
                                        else
                                        {
                                            for (int u = array.Count - 1; u >= 0; u--)
                                            {
                                                if (array[u].ToString() == username)
                                                {
                                                    array.RemoveAt(u);
                                                }
                                            }
                                            failedLockCounter += 1;
                                            if (sw.IsRunning)
                                            {
                                                sw.Reset();
                                            }
                                            else
                                            {
                                                sw.Start();
                                            }
                                            //lock account
                                            LockAccount(userid);
                                            sendMsg(email, password, fname, lname, username);
                                            dblog.Log("User Account Locked due to Multiple Failures (Suspicious Activity): " + username, "LogonFailure", userid.ToString(), email);
                                            dblog.Log("Account status changed (T -> L)", "Accounts", userid.ToString(), email);
                                        }
                                    }
                                    break;
                                }
                            }
                        }
                    }

                    //if Everything is correct
                    if (passwordcheck == 1 && username == befencryptedUsername)
                    {
                        //if the userid == 1, which is the admin userid
                        if (userid == 1)
                        {
                            Logininfo.userid = userid.ToString();
                            Logininfo.username = username;
                            Logininfo.email = email;
                            AdminProfile admin = new AdminProfile();
                            admin.Show();
                            Hide();
                            dblog.Log("Login User: " + username, "LogonSuccess", userid.ToString(), email);
                        }
                        else
                        {
                            //the for loop is to loop for authoriseIP address
                            //for(int i = 0; i< iplist.Count; i++)
                            //{
                                //ipaddress = GetIPAddress();
                                //if (ipaddress == iplist[i].ToString())
                                //{
                                    //F if have not change passwords
                                    if (checkvflag == "F")
                                    {
                                        Logininfo.userid = userid.ToString();
                                        Logininfo.username = username;
                                        Logininfo.email = email;
                                        dblog.Log("First Time Login User: " + username, "LogonSuccess", userid.ToString(), email);
                                        Users.ConfirmationDetails register = new Users.ConfirmationDetails(); // If status is Not completed
                                        register.Show();
                                        Hide();
                                    }
                                    else if (checkvflag == "FU")
                                    {
                                        Logininfo.userid = userid.ToString();
                                        Logininfo.username = username;
                                        Logininfo.email = email;
                                        dblog.Log("First Time Login after forget Username: " + username, "LogonSuccess", userid.ToString(), email);
                                        Users.forgetUsername forgetUsername = new Users.forgetUsername(); // If status is Not completed
                                        forgetUsername.Show();
                                        Hide();
                                    }
                                    else if (checkvflag == "FP")
                                    {
                                        Logininfo.userid = userid.ToString();
                                        Logininfo.username = username;
                                        Logininfo.email = email;
                                        dblog.Log("First Time Login after forget Password: " + username, "LogonSuccess", userid.ToString(), email);
                                        Users.forgetPassword forgetPassword = new Users.forgetPassword(); // If status is Not completed
                                        forgetPassword.Show();
                                        Hide();
                                    }
                                    //T if have verification and change password.
                                    else if (checkvflag == "T")
                                    {
                                        Logininfo.userid = userid.ToString();
                                        Logininfo.username = username;
                                        Logininfo.email = email;
                                        dblog.Log("Login User: " + username, "LogonSuccess", userid.ToString(), email);
                                        Users.Profile profile = new Users.Profile();
                                        profile.Show();
                                        Hide();
                                    }
                                    //L for Lock Account
                                    else if (checkvflag == "L")
                                    {
                                        validation.Show();
                                        validation.ForeColor = Color.Red;
                                        validation.Text = "Your Account has been Lock due to Suspicious Activity.";
                                    }
                                //}
                                //else
                                //{
                                //    MessageBox.Show("Your IP address is not authorised");
                                //}
                            //}
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
                queryStr = "UPDATE Userinfo set verificationflag=@vflag,statusDate=@statusDate where userid = @userid";

                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, con);
                cmd.Parameters.AddWithValue("@vflag", "L");
                cmd.Parameters.AddWithValue("@statusDate", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.ExecuteReader();
                con.Close();
            }
       }

        //SMTP PROTOCOL AFTER REGISTERING
        public static void sendMsg(string Email, string Password, string Firstname, string Lastname, string username)
        {

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 25;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("dataasguard@gmail.com", "DataAsguard123");

            MailMessage msg = new MailMessage();
            msg.Subject = "Hello " + username + "";
            msg.Body = "Hello " + Firstname + " " + Lastname + ", Your Account has been LOCKED due to multiple failed attempts!";

            msg.Body += "<tr>";
            msg.Body += "<td>Please contact the IT support to assist in this situation!</td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>If you are not the owner of the account pls ignore this message.</td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td></br></td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Thank you, </td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Team DataAsguardians.</td>";
            msg.Body += "</tr>";

            string toAddress = Email; //RECIPIENT EMAIL
            msg.To.Add(toAddress);

            string fromAddress = "\"DataAsguard \" dataasguard@gmail.com";
            msg.From = new MailAddress(fromAddress);
            msg.IsBodyHtml = true;

            try
            {
                smtp.Send(msg);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        //IPAddress of the computer
        protected string GetIPAddress()
        {
            string myHost = Dns.GetHostName();
            string myIP = Dns.GetHostByName(myHost).AddressList[0].ToString();

            return myIP;
        }

        //IPAddress of the authorisedIP
        protected ArrayList GetAuthoriseIPAddressList()
        {
            ArrayList IPList = new ArrayList();

            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                string selectQuery = "SELECT * FROM authoriseIP";
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows && reader.Read())
                {
                    IPList.Add(reader.GetString(reader.GetOrdinal("authoriseIP")));
                    //MessageBox.Show(userbirthdate);
                }

                con.Close();
            }

            return IPList;
        }

        private void forgetUserInfo_Click(object sender, EventArgs e)
        {
            forgetUserInfo forgetUser = new forgetUserInfo();
            forgetUser.Show();
            Hide();
        }
    }
}
