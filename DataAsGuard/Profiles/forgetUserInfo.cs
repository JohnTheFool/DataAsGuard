using DataAsGuard.CSClass;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAsGuard.Profiles
{
    public partial class forgetUserInfo : Form
    {
        DBLogger dblog = new DBLogger();
        AesEncryption aes = new AesEncryption();
        string vflag;

        public forgetUserInfo()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            string emailvalue = email.Text.ToString();
            string comboboxvalue = comboBox1.Text.ToString();

            //if email field is empty
            if (emailvalue != "" || emailvalue != null)
            {
                //if combobox is not filled
                if(comboboxvalue != "" || comboboxvalue != null)
                {
                    //check for email
                    if (searchemail(emailvalue))
                    {
                        if(vflag == "F")
                        {
                            MessageBox.Show("Please complete the verification process for first time login. An email has been send to your email. Please check in the junk mailbox as well.");
                        }
                        else if (vflag == "T")
                        {
                            //store session values
                            Logininfo.forgetUserinfo = comboboxvalue;

                            //redirect
                            ForgetOTP forgetOTP = new ForgetOTP();
                            forgetOTP.Show();
                            Hide();
                        }
                        else if(vflag == "L")
                        {
                            MessageBox.Show("Your account is found lock. Please contact system admin to know more details");
                        }
                        else if (vflag == "FU")
                        {
                            MessageBox.Show("Your account had gone through the forget username phase. An email had been send to your email since then. Please login with your new username to access the system.");
                        }
                        else if (vflag == "FP")
                        {
                            MessageBox.Show("Your account had gone through the forget Password phase. An email had been send to your email since then. Please login with your new password to access the system.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email not found. Please key in the correct Email.");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Email Field not filled. Ensure the combobox is selected as well");
            }
        }


        //find email in db using the email given
        private bool searchemail(string email)
        {
            bool contain = false;
            if(email == "Dataasguard@gmail.com")
            {
                return contain;
            }
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
                        if(email == aes.Decryptstring(reader.GetString(reader.GetOrdinal("email")), reader.GetString(reader.GetOrdinal("userid")))){
                            Logininfo.forgetEmail = email;
                            Logininfo.userid = reader.GetString(reader.GetOrdinal("userid"));
                            vflag = reader.GetString(reader.GetOrdinal("verificationflag"));

                            contain = true;

                            return contain;
                        }
                        else
                        {
                            //MessageBox.Show();
                        }
                        //MessageBox.Show(userbirthdate);
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                dblog.Log(ex.ToString(), "Error", "Null", "Null");
            }
            return contain;
        }


    }
}
