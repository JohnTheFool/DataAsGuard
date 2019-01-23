using DataAsGuard.CSClass;
using MySql.Data.MySqlClient;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAsGuard.Profiles.Admin
{
    public partial class Registration : Form
    {
        private Random rand = new Random();
        //smtp
        string emails, password, Firstname, Lastname;
        DBLogger dblog = new DBLogger();
        static string username;

        public Registration()
        {
            InitializeComponent();
            CreateImage();
        }

        private void Registration_Shown(Object sender, EventArgs e)
        {
            validatefname.Hide();
            validatelName.Hide();
            validatephoneNO.Hide();
            validateDOB.Hide();
            validateEmail.Hide();
            validatecaptcha.Hide();
            validation.Hide();
            //change date time to dd/MM/yy
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat="dd/MM/yyyy";
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            string firstname = fName.Text;
            string lastname = lName.Text;
            string email = Email.Text;
            //contact
            string phoneNo = PhoneNO.Text;
            string dob = dateTimePicker1.Text;

            //for smtp
            emails = Email.Text.ToString();
            Firstname = fName.Text.ToString();
            Lastname = lName.Text.ToString();
            string hashpassword;

            //check if all field is not null or empty
            if (firstname != "" && lastname != "" && email != "" && phoneNo != "" && dob != "" && captchabox.Text != "")
            {
                //check if captcha are correct
                if (captchabox.Text == code.ToString())
                {
                    //pre encrypted
                    password = RandomString(10);
                    hashpassword = passwordhash(password);

                    username = firstname + lastname[0] + rand.Next(0, 1000);

                    //registerUser
                    registerUser(hashpassword);

                    sendMsg(email, password, firstname, lastname, username);

                    RegistrationConfirm Confirm = new RegistrationConfirm();
                    Confirm.Show();
                    Hide();
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                    }
                }
                else
                {
                    validatecaptcha.Show();
                    validatecaptcha.ForeColor = Color.Red;
                    validatecaptcha.Text = "Incorrect Captcha";
                }
            }
            else
            {
                if (firstname == "" || firstname == null)
                {
                    validatefname.Show();
                    validatefname.ForeColor = Color.Red;
                    validatefname.Text = "Field cannot be empty";
                }
                else
                {
                    validatefname.Hide();
                }
                if (lastname == "" || lastname == null)
                {
                    validatelName.Show();
                    validatelName.ForeColor = Color.Red;
                    validatelName.Text = "Field cannot be empty";
                }
                else
                {
                    validatelName.Hide();
                }
                if (email == "" || email == null)
                {
                    validateEmail.Show();
                    validateEmail.ForeColor = Color.Red;
                    validateEmail.Text = "Field cannot be empty";
                }
                if (phoneNo == "" || phoneNo == null)
                {
                    validatephoneNO.Show();
                    validatephoneNO.ForeColor = Color.Red;
                    validatephoneNO.Text = "Field cannot be empty";
                }
                if (dob == "" || dob == null)
                {
                    validateDOB.Show();
                    validateDOB.ForeColor = Color.Red;
                    validateDOB.Text = "Field cannot be empty";
                }
                else
                {
                    validateDOB.Hide();
                }
                if (captchabox.Text == "" || captchabox.Text == null)
                {
                    validatecaptcha.Show();
                    validatecaptcha.ForeColor = Color.Red;
                    validatecaptcha.Text = "Field cannot be empty";
                }
                else
                {
                    validatecaptcha.Hide();
                }
                validation.Show();
                validation.ForeColor = Color.Red;
                validation.Text = "Check that all fields are filled in!";
            }

        }

        //REGISTER USER METHOD
        private void registerUser(string hashpassword)
        {
            string firstname = fName.Text;
            string lastname = lName.Text;
            string email = Email.Text;
            string phoneNo = PhoneNO.Text;
            string dob = dateTimePicker1.Text;
            
            AesEncryption aes = new AesEncryption();
            if (checkEmail())
            {
                if (checkEmail())
                {
                    validation.Show();
                    validation.ForeColor = Color.ForestGreen;
                    validation.Text = "Email has been used";
                }
            }
            else
            {
                using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
                {
                    con.Open();
                    //String query = "INSERT into Userinfo(phoneno., email, firstname, lastname, dob, username, password) values(@contact, @email, @firstName, @Lastname, @DOB, @userName, @hashedPassword)";
                    String query = "INSERT into Userinfo(username, password, email, firstname, lastname, fullName, dob, contact) values(@userName, @hashedPassword, @email, @firstName, @Lastname, @fullName, @DOB, @contact)";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@contact", aes.Encryptstring2(phoneNo, dob));
                    cmd.Parameters.AddWithValue("@email", aes.Encryptstring2(email, dob));
                    cmd.Parameters.AddWithValue("@firstName", firstname);
                    cmd.Parameters.AddWithValue("@Lastname", lastname);
                    cmd.Parameters.AddWithValue("@fullName", firstname + " " + lastname);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@userName", aes.Encryptstring2(username, dob));
                    cmd.Parameters.AddWithValue("@hashedPassword", hashpassword);
                    cmd.ExecuteReader();

                }
            }
            //log the registration done by the admin
            dblog.Log("User account "+username+" registered", "Registration", Logininfo.userid, Logininfo.email);
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

        //validateEmail
        private void Email_TextChanged(object sender, EventArgs e)
        {
            var regex = "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
            Match match = Regex.Match(Email.Text, regex, RegexOptions.IgnoreCase);
            if (Email.Text == string.Empty)
            {
                //"Please insert a proper email",
                validateEmail.Show();
                validateEmail.ForeColor = Color.Red;
                validateEmail.Text = "Please insert an email";
            }
            else if (Email.Text != string.Empty && !match.Success)
            {
                //"Please insert a proper email",
                validateEmail.Show();
                validateEmail.ForeColor = Color.Red;
                validateEmail.Text = "Please insert a proper email";
            }
            else if (Email.Text != string.Empty && match.Success)
            {
                if (checkEmail())
                {
                    validateEmail.Show();
                    validateEmail.ForeColor = Color.ForestGreen;
                    validateEmail.Text = "Email has been used";
                }
                else
                { 
                //"Email Validated and ok",
                validateEmail.Show();
                validateEmail.ForeColor = Color.ForestGreen;
                validateEmail.Text = "Email Validated";
                }
            }
        }

        //retrieval of email
        private bool checkEmail()
        {
            AesEncryption aes = new AesEncryption();
            bool exist = false;
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM Userinfo";
                MySqlCommand command = new MySqlCommand(query, con);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if(Email.Text == aes.Decryptstring(reader.GetString(reader.GetOrdinal("email")), reader.GetString(reader.GetOrdinal("userid"))))
                        {
                            exist = true;
                        }
                    }

                    if (reader != null)
                        reader.Close();
                }
            }
            return exist;
        }

        //validatenumber
        private void phonenumber_TextChanged(object sender, EventArgs e)
        {
            var regex = "((8|9)[0-9]{7})$";
            Match match = Regex.Match(PhoneNO.Text, regex, RegexOptions.IgnoreCase);

            if (PhoneNO.Text == string.Empty)
            {
                //"Please insert a proper phone number",
                validatephoneNO.Show();
                validatephoneNO.ForeColor = Color.Red;
                validatephoneNO.Text = "Please a proper phone number";
            }
            else if (PhoneNO.Text != string.Empty && !match.Success)
            {
                //"Please insert a proper phone number",
                validatephoneNO.Show();
                validatephoneNO.ForeColor = Color.Red;
                validatephoneNO.Text = "Please insert a proper phone number";
            }
            else if (PhoneNO.Text != string.Empty && match.Success)
            {
                //"Please insert a proper phone number",
                validatephoneNO.Show();
                validatephoneNO.ForeColor = Color.ForestGreen;
                validatephoneNO.Text = "Phone Number Validated";
            }
        }

        private void phoneno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

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
            msg.Subject = "Hello " + Firstname + " " + Lastname + "";
            msg.Body = "Hello " + Firstname + " " + Lastname + ", Your account has been registered for DataAsguard!";

            msg.Body += "<tr>";
            msg.Body += "<td>Your account details are given below: </td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Username: " + username + "</td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Please login with your username </td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Password: " + Password + "</td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Please try to login to your account!</td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>A request to verify your account details will occur including a change of password.</td>";
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
            catch(Exception e)
            {
                throw;
            }
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

        private void Logout_Click(object sender, EventArgs e)
        {
            Logininfo.userid = null;
            Logininfo.email = null;
            Logininfo.username = null;
            Login login = new Login();
            login.Show();
            Hide();

            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
        }

        private void AdminHome_Click(object sender, EventArgs e)
        {
            AdminProfile Profiles = new AdminProfile();
            Profiles.Show();
            Hide();
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
        }

        private Point[] GetRandomPoints()
        {
            Point[] points = { new Point(rand.Next(10, 150), rand.Next(10, 150)), new Point(rand.Next(10, 100), rand.Next(10, 100)) };
            return points;
        }

        string code;
        //gernate random text in the captcha
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

    }
}

