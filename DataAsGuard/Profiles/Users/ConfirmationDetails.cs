using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAsGuard.CSClass;
using MySql.Data.MySqlClient;

namespace DataAsGuard.Profiles.Users
{
    public partial class ConfirmationDetails : Form
    {
        private Random rand = new Random();
        AesEncryption aes = new AesEncryption();
        DBLogger dblog = new DBLogger();
        public ConfirmationDetails()
        {
            InitializeComponent();
        }

        private void Registration_Shown(Object sender, EventArgs e)
        {
            validateUsername.Hide();
            validateCaptcha.Hide();
            userdataRetrieval();
            CreateImage();
        }

        private void userdataRetrieval()
        {
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
                        username.Text = aes.Decryptstring(reader.GetString(reader.GetOrdinal("username")), Logininfo.userid.ToString());
                        name.Text = reader.GetString(reader.GetOrdinal("firstname")) + " " + reader.GetString(reader.GetOrdinal("lastname"));
                        phoneNo.Text = aes.Decryptstring(reader.GetString(reader.GetOrdinal("contact")), Logininfo.userid.ToString());
                        email.Text = aes.Decryptstring(reader.GetString(reader.GetOrdinal("email")), Logininfo.userid.ToString());
                        DOB.Text = reader.GetString(reader.GetOrdinal("dob"));

                    }

                    if (reader != null)
                        reader.Close();
                }
            }
        }

        //submit button
        private void Confirm_Click(object sender, EventArgs e)
        {
            if (captchabox.Text == code.ToString())
            {
                bool contains = usernamechecker(username.Text);
                //if contains == true and username is the same as the current username for the current user OR
                //if contains == false
                if ((contains == true && checkuserid == Logininfo.userid) || (contains == false))
                {
                    updateUsername(username.Text);
                    //route to OTP page
                    confirmationOTP registerOTP = new confirmationOTP();
                    registerOTP.Show();
                    Hide();
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                    }
                }
                else
                {
                    validateUsername.Show();
                    validateUsername.ForeColor = Color.Red;
                    validateUsername.Text = "Username had been taken.";
                }
            }
            else
            {
                validateCaptcha.Show();
                validateCaptcha.ForeColor = Color.Red;
                validateCaptcha.Text = "Incorrect Entry";
            }
        }

        //Update username
        public void updateUsername(string username)
        {
            //UPDATE PASSWORD TO DATABASE
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                string queryStr = "";
                queryStr = "UPDATE Userinfo set username=@username where userid = @userid";

                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, con);
                cmd.Parameters.AddWithValue("@username", aes.Encryptstring(username,Logininfo.userid));
                cmd.Parameters.AddWithValue("@userid", CSClass.Logininfo.userid.ToString());
                cmd.ExecuteReader();
                con.Close();
                dblog.Log("User Information changed", "Accounts", Logininfo.userid.ToString(), Logininfo.email);
            }
        }

        private void RefreshCaptcha_Click(object sender, EventArgs e)
        {
            //release resources uses by captcha to prevent issues
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
            CreateImage();
        }

        //captcha
        private void CreateImage()
        {
            string code = GetRandomText();

            Bitmap bitmap = new Bitmap(200, 50, PixelFormat.Format32bppArgb);
            Bitmap bmap = new Bitmap(bitmap.Width, bitmap.Height);
            Graphics g = Graphics.FromImage(bmap);
            Pen pen = new Pen(Color.Yellow);
            Rectangle rect = new Rectangle(0, 0, 200, 50);

            SolidBrush b = new SolidBrush(Color.Black);
            SolidBrush White = new SolidBrush(Color.White);

            int counter = 0;

            g.DrawRectangle(pen, rect);
            g.FillRectangle(b, rect);

            for (int i = 0; i < code.Length; i++)
            {
                //text font
                g.DrawString(code[i].ToString(), new Font("Arial", 10 + rand.Next(14, 18)), White, new PointF(10 + counter, 10));
                counter += 20;
            }

            DrawRandomLines(g);
            bitmap.Dispose();
            bitmap = bmap;
            b.Dispose();
            pen.Dispose();
            White.Dispose();
            g.Dispose();

            //check for existing captcha file
            if (File.Exists("tempimage.jpg"))
            {

                try
                {
                    File.Delete("tempimage.jpg");
                    bitmap.Save("tempimage.jpg", ImageFormat.Jpeg);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {

                bitmap.Save("tempimage.jpg", ImageFormat.Jpeg);

            }
            bitmap.Dispose();
            pictureBox1.Image = Image.FromFile("tempimage.jpg");
        }

        //random lines in the captcha
        private void DrawRandomLines(Graphics g)
        {
            SolidBrush green = new SolidBrush(Color.Green);
            //For Creating Lines on The Captcha 
            for (int i = 0; i < 20; i++)
            {
                g.DrawLines(new Pen(green, 2), GetRandomPoints());
            }

        }

        private Point[] GetRandomPoints()
        {
            Point[] points = { new Point(rand.Next(10, 150), rand.Next(10, 150)), new Point(rand.Next(10, 100), rand.Next(10, 100)) };
            return points;
        }

        string code;
        //generate random text in the captcha
        private string GetRandomText()
        {
            StringBuilder randomText = new StringBuilder();

            //if (String.IsNullOrEmpty(code))
            //{
                string alphabets = "abcdefghijklmnopqrstuvwxyz1234567890";

                Random r = new Random();
                for (int j = 0; j <= 5; j++)
                {

                    randomText.Append(alphabets[r.Next(alphabets.Length)]);
                }

                code = randomText.ToString();
            //}

            return code;
        }

        static string checkuserid;
        private void username_Leave(object sender, EventArgs e)
        {
            bool contains = usernamechecker(username.Text);
            if (contains == true && checkuserid != Logininfo.userid)
            {
                validateUsername.Show();
                validateUsername.ForeColor = Color.Red;
                validateUsername.Text = "Username had been taken.";
            }
            else if (contains == true && checkuserid == Logininfo.userid)
            {
                validateUsername.Show();
                validateUsername.ForeColor = Color.ForestGreen;
                validateUsername.Text = "Username OK!";
            }
            else
            {
                validateUsername.Show();
                validateUsername.ForeColor = Color.ForestGreen;
                validateUsername.Text = "Username OK!";
            }
        }

        //check for duplicates in username
        public bool usernamechecker(string usernamevalue)
        {
            bool contains = false;
            //UPDATE PASSWORD TO DATABASE
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                string queryStr = "";
                queryStr = "SELECT * FROM Userinfo";

                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, con);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    //cannot have duplicate
                    //if it contains a value.
                    while (reader.Read())
                    {
                        if (usernamevalue == aes.Decryptstring(reader.GetString(reader.GetOrdinal("username")), reader.GetString(reader.GetOrdinal("userid"))))
                        {
                            contains = true;
                            checkuserid = reader.GetString(reader.GetOrdinal("userid"));
                        }
                    }

                    if (reader != null)
                        reader.Close();
                }
            }
            return contains;
        }
    }
}

