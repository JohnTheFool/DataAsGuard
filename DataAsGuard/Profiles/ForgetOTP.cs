using DataAsGuard.CSClass;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAsGuard.Profiles
{
    public partial class ForgetOTP : Form
    {

        static Stopwatch sw;
        private string hpnumber;
        private static double timeElapsed;
        AesEncryption aes = new AesEncryption();
        static string OTPReturn;
        DBLogger dblog = new DBLogger();
        Random rand = new Random();

        string Email;
        string Firstname;
        string Lastname;
        string username;

        public ForgetOTP()
        {
            InitializeComponent();
        }


        private void ForgetEmailOTP_Shown(Object sender, EventArgs e)
        {
            validationOTP.Hide();
            refreshOTP.Hide();
            OTP();
        }

        private void OTPConfirm_Click(object sender, EventArgs e)
        {
            string targetemail = Logininfo.forgetEmail;
            string targettype = Logininfo.forgetUserinfo;
            searchInfo();
            
            timeElapsed = sw.Elapsed.TotalSeconds;
            //check if the OTP input equal to the result
            string userOTPInput = OTPInput.Text;
            if (userOTPInput.Equals(OTPReturn))
            {
                if (timeElapsed > 120 || timeElapsed <= 0)
                {
                    validationOTP.Text = "Your One-Time-Password has expired or has been invalidated!";
                    validationOTP.ForeColor = System.Drawing.Color.Red;
                    validationOTP.Visible = true;
                    refreshOTP.Visible = true;
                }
                else
                {
                    //send email with newly generated username
                    if(targettype == "Username")
                    {
                        string newusername = Firstname + Lastname[0] + rand.Next(0, 1000);

                        updateUsername(newusername);

                        sendMsg(Email, Firstname, Lastname, newusername);
                        EmailSend emailsend = new EmailSend();
                        emailsend.Show();
                        Hide();
                        Logininfo.forgetEmail = null;
                        Logininfo.forgetUserinfo = null;
                        Logininfo.userid = null;
                    }
                    //send email with newly generated password
                    else if (targettype == "Password")
                    {
                        string newGeneratedPassword = RandomString(10);
                        string hashpassword = passwordhash(newGeneratedPassword);

                        updatePassword(hashpassword);

                        sendMsg2(Email, newGeneratedPassword, Firstname, Lastname, username);
                        EmailSend emailsend = new EmailSend();
                        emailsend.Show();
                        Hide();
                        Logininfo.forgetEmail = null;
                        Logininfo.forgetUserinfo = null;
                        Logininfo.userid = null;
                    }   
                }
            }
            else
            {
                validationOTP.Text = "Your One-Time-Password is incorrect!";
                validationOTP.ForeColor = System.Drawing.Color.Red;
                validationOTP.Visible = true;
            }
        }

        //SMTP PROTOCOL AFTER Username Option
        public static void sendMsg(string Email, string Firstname, string Lastname, string username)
        {

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 25;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("dataasguard@gmail.com", "DataAsguard123");

            MailMessage msg = new MailMessage();
            msg.Subject = "Forget Username Request Completed";
            msg.Body = "Hello " + Firstname + " " + Lastname;

            msg.Body += "<tr>";
            msg.Body += "<td>The forget username request details are given below: </td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Username: " + username + "</td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Please login with your username </td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Please try to login to your account!</td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>A request to change your username will occur.</td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Please perform the change of username to start using DataAsguard.</td>";
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

        //SMTP PROTOCOL AFTER Password option
        public static void sendMsg2(string Email, string Password, string Firstname, string Lastname, string username)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 25;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("dataasguard@gmail.com", "DataAsguard123");

            MailMessage msg = new MailMessage();
            msg.Subject = "Forget Password Request Completed";
            msg.Body = "Hello " + Firstname + " " + Lastname ;

            msg.Body += "<tr>";
            msg.Body += "<td>Your Forget Password request are given below: </td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Please login with your username and your new password </td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Password: " + Password + "</td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Please try to login to your account!</td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>A request to change your password will occur.</td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Please perform the change of password to start using DataAsguard.</td>";
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

        private void searchInfo()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
                {
                    con.Open();
                    string selectQuery = "SELECT * FROM Userinfo WHERE userID = @userID";
                    MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@userID", Logininfo.userid.ToString());
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.HasRows && reader.Read())
                    {
                        Email = aes.Decryptstring(reader.GetString(reader.GetOrdinal("email")), reader.GetString(reader.GetOrdinal("userid")));
                        Firstname = reader.GetString(reader.GetOrdinal("firstname"));
                        Lastname = reader.GetString(reader.GetOrdinal("lastname"));
                        username = aes.Decryptstring(reader.GetString(reader.GetOrdinal("username")), reader.GetString(reader.GetOrdinal("userid")));
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                dblog.Log(ex.ToString(), "Error", "Null", "Null");
            }
        }

        //randomnize password
        public string RandomString(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }

            return res.ToString();
        }

        //hash password
        public string passwordhash(string password)
        {
            //generate salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            //PBKDF2 (Password-Based Key Derivation Function 2)
            //generate hash
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 2000);
            byte[] hash = pbkdf2.GetBytes(20);
            //PBKDF2 (Password-Based Key Derivation Function 2)
            byte[] hashBytes = new byte[36];
            //salt(0-15)
            Array.Copy(salt, 0, hashBytes, 0, 16);

            //hashpassword(16-36)
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string savedPasswordHash = Convert.ToBase64String(hashBytes);

            return savedPasswordHash;
        }

        //Update username
        public void updateUsername(string username)
        {
            //UPDATE PASSWORD TO DATABASE
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                string queryStr = "";
                queryStr = "UPDATE Userinfo set username=@username,verificationflag=@vflag where userid = @userid";

                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, con);
                cmd.Parameters.AddWithValue("@username", aes.Encryptstring(username, Logininfo.userid));
                cmd.Parameters.AddWithValue("@userid", Logininfo.userid);
                cmd.Parameters.AddWithValue("vflag", "FU");
                cmd.ExecuteReader();
                con.Close();
                dblog.Log("Forget Username Request Completed", "Accounts", Logininfo.userid.ToString(), Logininfo.forgetEmail);
                dblog.Log("User Information changed", "Accounts", Logininfo.userid.ToString(), Logininfo.forgetEmail);
                dblog.Log("Account Status Changed(T -> FU)", "Accounts", Logininfo.userid.ToString(), Logininfo.forgetEmail);
            }
        }

        //Update password
        public void updatePassword(string password)
        {
            //UPDATE PASSWORD TO DATABASE
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                string queryStr = "";
                queryStr = "UPDATE Userinfo set password=@password, verificationflag=@vflag where userid = @userid";

                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, con);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@userid", Logininfo.userid);
                cmd.Parameters.AddWithValue("vflag", "FP");
                cmd.ExecuteReader();
                con.Close();
                dblog.Log("Forget Password Request Completed", "Accounts", Logininfo.userid.ToString(), Logininfo.forgetEmail);
                dblog.Log("User Information changed", "Accounts", Logininfo.userid.ToString(), Logininfo.forgetEmail);
                dblog.Log("Account Status Changed(T -> FP)", "Accounts", Logininfo.userid.ToString(), Logininfo.forgetEmail);
            }
        }

        public void OTP()
        {
            MySqlConnection MyConnection = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema");
            MyConnection.Open();
            MySqlDataReader reader;

            sw = new Stopwatch();
            sw.Start();

            using (MySqlCommand otpCommand = new MySqlCommand("SELECT contact FROM Userinfo WHERE userID = @userID", MyConnection))
            {
                otpCommand.Parameters.AddWithValue("@userID", Logininfo.userid.ToString());
                reader = otpCommand.ExecuteReader();

                while (reader.HasRows && reader.Read())
                {
                    hpnumber = aes.Decryptstring(reader["contact"].ToString(), Logininfo.userid.ToString());
                }

                reader.Close();
            }

            //The first 2 values("WebAPI ID", "WebAPI Password") in the string input below are Commzgate Web API account details which will differ between different accounts used
            //string response = OTPStr("101510002", "DataAsguard1", "65" + hpnumber, "Your One-Time-Password for DataAsguard is *OTP*");
            //Retrieve the back value
            //OTPReturn = response.Substring(Math.Max(0, response.Length - 5));

            OTPReturn = "12345"; //(Testing purposes to prevent wasting of the messages)
                                 //If OTP doesn't send after a period of time, replace the 2 API details above with new ones from the list below
                                 //Here is a list of unused WebAPI account details I prepared and created that still have 10 SMS credits each. 
                                 //WebAPI ID: 101510002     WebAPI Password: DataAsguard1 (Currently in use above)
                                 //WebAPI ID: 102150002     WebAPI Password: Data@sguard1an   

        }

        public static string OTPStr(string ID, string Password, string mobile, string msg)
        {
            string response = "";
            try
            {
                //Construct Send Params.
                string gateWay = "https://www.commzgate.net/gateway/SendMsg?";
                //Setup Params
                string paramData = "";
                paramData += "ID=" + ID + "&";
                paramData += "Password=" + Password + "&";
                paramData += "Mobile=" + mobile + "&";
                paramData += "Type=" + "A" + "&";
                paramData += "Message=" + System.Uri.EscapeDataString(msg) + "&";
                paramData += "OTP=true";

                //Ensure Ascii format
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] ASCIIparamData = encoding.GetBytes(paramData);

                //Setting Request
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(gateWay);
                request.Method = "POST";

                request.Accept = "text/plain";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = ASCIIparamData.Length;

                //Sending Request.
                Stream streamReq = request.GetRequestStream();
                streamReq.Write(ASCIIparamData, 0, ASCIIparamData.Length);

                //Get Response
                HttpWebResponse HttpWResp = (HttpWebResponse)request.GetResponse();
                Stream streamResponse = HttpWResp.GetResponseStream();

                //Read the Response.. and open a dialog
                StreamReader reader = new StreamReader(streamResponse);
                response = reader.ReadToEnd();

                return response;
            }
            catch (Exception e)
            {
                return "" + e;
            }
        }

        private void refreshOTP_Click(object sender, EventArgs e)
        {
            OTP();
            validationOTP.Show();
            validationOTP.ForeColor = Color.Black;
            validationOTP.Text = "A New OTP has been send to your number!";
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }
    }
}
