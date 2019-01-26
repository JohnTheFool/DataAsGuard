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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAsGuard.Profiles.Users
{
    public partial class confirmationOTP : Form
    {
        static Stopwatch sw;
        private string hpnumber;
        private static double timeElapsed;
        AesEncryption aes = new AesEncryption();
        static string OTPReturn;

        public confirmationOTP()
        {
            InitializeComponent();
        }

        private void OTP_Shown(Object sender, EventArgs e)
        {
            validationOTP.Hide();
            refreshOTP.Hide();
            OTP();
        }

        private void OTPConfirm_Click(object sender, EventArgs e)
        {
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
                    changePasswordRegistration changePasswordConfirmation = new changePasswordRegistration();
                    changePasswordConfirmation.Show();
                    Hide();
                }
            }
            else
            {
                validationOTP.Text = "Your One-Time-Password is incorrect!";
                validationOTP.ForeColor = System.Drawing.Color.Red;
                validationOTP.Visible = true;
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
                otpCommand.Parameters.AddWithValue("@userID", CSClass.Logininfo.userid.ToString());
                reader = otpCommand.ExecuteReader();

                while (reader.HasRows && reader.Read())
                {
                    hpnumber = aes.Decryptstring(reader["contact"].ToString(), CSClass.Logininfo.userid.ToString());
                }

                reader.Close();
            }

            //The first 2 values("WebAPI ID", "WebAPI Password") in the string input below are Commzgate Web API account details which will differ between different accounts used
            //string response = OTPStr("102150002", "Data@sguard1an", "65" + hpnumber, "Your One-Time-Password for DataAsguard is *OTP*");
            //Retrieve the back value
            //OTPReturn = response.Substring(Math.Max(0, response.Length - 5));

            OTPReturn = "12345"; //(Testing purposes to prevent wasting of the messages)
            //If OTP doesn't send after a period of time, replace the 2 API details above with new ones from the list below
            //Here is a list of unused WebAPI account details I prepared and created that still have 10 SMS credits each. 
            //WebAPI ID: 101510002     WebAPI Password: DataAsguard1 
            //WebAPI ID: 102150002     WebAPI Password: Data@sguard1an (Currently in use above)  
            
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

    }
}
