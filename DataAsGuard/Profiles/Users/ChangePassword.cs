using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAsGuard.Profiles.Users
{
    public partial class ChangePassword : Form
    {
        Random rand = new Random();
        static string oldhashpassword;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Shown(Object sender, EventArgs e)
        {
            validateCaptcha.Hide();
            validatecPasword.Hide();
            validatePassword.Hide();
            strengthcheck.Hide();
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
                command.Parameters.AddWithValue("@userid", CSClass.Logininfo.userid);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        oldhashpassword = reader.GetString(reader.GetOrdinal("password"));

                    }

                    if (reader != null)
                        reader.Close();
                }

            }
        }

        //submit button
        private void Confirm_Click(object sender, EventArgs e)
        {
            //strength
            int strength = CheckPasswordstrength(Password.Text);
            
            string passwordvalue = Password.Text;
            string cpasswordvalue = CPassword.Text;

            bool checkCPassword = CheckPassword(passwordvalue);
            //generate new hash with new salt
            string hashpassword = passwordhash(passwordvalue);

            //check
            int passwordcheck = 0;

            //comparing old and new passwords with old salt
            byte[] hashBytes = Convert.FromBase64String(oldhashpassword);
            //retrieve salt from stored hash
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            /* Compute the hash on the password the user entered */
            var pbkdf2 = new Rfc2898DeriveBytes(passwordvalue, salt, 2000);
            byte[] hash = pbkdf2.GetBytes(20);
            /* Compare the results */
            //For loop check for any abnormality or differences if there is differences set passwordcheck = 1
            for (int i = 0; i < 20; i++)
            {
                //if password is not the same as old 
                if (hashBytes[i + 16] != hash[i])
                {
                    passwordcheck = 1;
                }
            }

            if (captchabox.Text == code.ToString())
            {
                //check strength of the password cannot be weak
                if (strength >= 3)
                {
                    //ensure that password == confirmpassword
                    if (passwordvalue == cpasswordvalue)
                    {
                        //check if all condition of password are met
                        if (checkCPassword == true)
                        {
                            //check if oldpassword is same as new password
                            if (passwordcheck == 0)
                            {
                                validateCaptcha.Hide();
                                validatecPasword.Hide();
                                validatePassword.ForeColor = Color.Red;
                                validatePassword.Text = "Old Password cannot be the same as new Password";
                                validatePassword.Show();
                            }
                            else
                            {
                                //update database with the new password and hash with salt
                                updatePassword(hashpassword);
                                changePasswordConfirm change = new changePasswordConfirm();
                                change.Show();
                                Hide();
                                //release resources uses by captcha to prevent issues
                                if (pictureBox1.Image != null)
                                {
                                    pictureBox1.Image.Dispose();
                                    pictureBox1.Image = null;
                                }
                            }
                        }
                        else
                        {
                            validatePassword.Show();
                            validatePassword.ForeColor = Color.Red;
                            validatePassword.Text = "Please ensure that Password contains 8-16 characters, 1 Lower Case, 1 Upper Case, 1 Number and at least 1 Special Character.";
                        }
                    }
                    else
                    {
                        validatePassword.Show();
                        validatePassword.ForeColor = Color.Red;
                        validatePassword.Text = "Password not match";
                        validatecPasword.Show();
                        validatecPasword.ForeColor = Color.Red;
                        validatecPasword.Text = "Password not match";
                    }
                }
                else
                {
                    validatePassword.Show();
                    validatePassword.ForeColor = Color.Red;
                    validatePassword.Text = "Password should not be Weak!";
                }
            }
            else
            {
                validateCaptcha.Show();
                validateCaptcha.ForeColor = Color.Red;
                validateCaptcha.Text = "Incorrect Entry";
            }

        }

        //Update Password
        public void updatePassword(string hashpassword)
        {
            //UPDATE PASSWORD TO DATABASE
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                string queryStr = "";
                queryStr = "UPDATE Userinfo set password=@conpassword where userid = @userid";

                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, con);
                cmd.Parameters.AddWithValue("@conpassword", hashpassword);
                cmd.Parameters.AddWithValue("@userid", CSClass.Logininfo.userid.ToString());
                cmd.ExecuteReader();
                con.Close();
            }
        }

        //passwordchecker
        public bool CheckPassword(string pass)
        {
            //min 8 chars, max 16 chars
            if (pass.Length < 8 || pass.Length > 16)
                return false;

            //No white space
            if (pass.Contains(" "))
                return false;

            //At least 1 upper case letter
            if (!pass.Any(char.IsUpper))
                return false;

            //At least 1 lower case letter
            if (!pass.Any(char.IsLower))
                return false;

            if (!pass.Any(char.IsNumber))
                return false;

            //No two similar chars consecutively
            for (int i = 0; i < pass.Length - 1; i++)
            {
                if (pass[i] == pass[i + 1])
                    return false;
            }

            //At least 1 special char
            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialCharactersArray = specialCharacters.ToCharArray();
            foreach (char c in specialCharactersArray)
            {
                if (pass.Contains(c))
                    return true;
            }
            return false;
        }

        //check password changes
        private void password_TextChanged(object sender, EventArgs e)
        {
            int strength = CheckPasswordstrength(Password.Text);
            bool checkpassword = CheckPassword(Password.Text);

            if (strength == 1)
            {
                strengthcheck.Show();
                strengthcheck.Text = "Very Weak";
                strengthcheck.ForeColor = Color.Red;
            }
            else if (strength == 2)
            {
                strengthcheck.Show();
                strengthcheck.Text = "Weak";
                strengthcheck.ForeColor = Color.Red;
            }
            else if (strength == 3)
            {
                strengthcheck.Show();
                strengthcheck.Text = "Good";
                strengthcheck.ForeColor = Color.OrangeRed;
            }
            else if (strength == 4)
            {
                strengthcheck.Show();
                strengthcheck.Text = "Very Good";
                strengthcheck.ForeColor = Color.Orange;
            }
            else if (strength == 5)
            {
                strengthcheck.Show();
                strengthcheck.Text = "Medium";
                strengthcheck.ForeColor = Color.YellowGreen;
            }
            else if (strength > 5)
            {
                strengthcheck.Show();
                strengthcheck.Text = "Excellent";
                strengthcheck.ForeColor = Color.Green;
            } 
        }

        private void password_onleave(object sender, EventArgs e)
        {
            bool checkpassword = CheckPassword(Password.Text);
            //if password text == old password
            if (Password.Text == oldPassword.Text)
            {
                validatePassword.Show();
                validatePassword.ForeColor = Color.Red;
                validatePassword.Text = "New password cannot be same as Old Password";
            }
            else
            {
                //check if password matches with confirm password
                if (Password.Text != CPassword.Text)
                {
                    //check if cPassword is null or empty field
                    if (CPassword.Text == "" || CPassword.Text == null)
                    {
                        //check if password got all the condition of 8-16 characters, 1 Lower Case, 1 Upper Case, 1 Number and at least 1 Special Character. and cpassword is still null
                        if (checkpassword == false)
                        {
                            validatePassword.Show();
                            validatePassword.ForeColor = Color.Red;
                            validatePassword.Text = "Please ensure that Password contains 8-16 characters, 1 Lower Case, 1 Upper Case, 1 Number and at least 1 Special Character.";
                            validatecPasword.Hide();
                        }
                        //else cpassword still null and condition is correct
                        else if (checkpassword == true)
                        {
                            validatePassword.Show();
                            validatePassword.ForeColor = Color.ForestGreen;
                            validatePassword.Text = "Ok!";
                            validatecPasword.Hide();
                        }
                    }
                    //check if cpassword and password does not matches with one another
                    else
                    {
                        validatePassword.Show();
                        validatePassword.ForeColor = Color.Red;
                        validatePassword.Text = "Password not match";
                    }
                }
                //if cpassword and password are equal
                else
                {
                    //cpassword and password matches and password matches condition
                    if (checkpassword == true)
                    {
                        validatePassword.Show();
                        validatePassword.ForeColor = Color.ForestGreen;
                        validatePassword.Text = "Ok!";
                    }
                    //cpassword and password matches but password does not matches the conditions
                    else if (checkpassword == false)
                    {
                        validatePassword.Show();
                        validatePassword.ForeColor = Color.Red;
                        validatePassword.Text = "Please ensure that Password contains 8-16 characters, 1 Lower Case, 1 Upper Case, 1 Number and at least 1 Special Character.";
                    }
                }
            }
        }


        private void cpassword_onleave(object sender, EventArgs e)
        {
            bool checkpassword = CheckPassword(Password.Text);
            //check if password matches with confirm password
            if (Password.Text != CPassword.Text)
            {
                //check if cPassword is null or empty field
                if (CPassword.Text == "" || CPassword.Text == null)
                {
                    //check if password got all the condition of 8-16 characters, 1 Lower Case, 1 Upper Case, 1 Number and at least 1 Special Character. and cpassword is still null
                    if (checkpassword == false)
                    {
                        validatePassword.Show();
                        validatePassword.ForeColor = Color.Red;
                        validatePassword.Text = "Please ensure that Password contains 8-16 characters, 1 Lower Case, 1 Upper Case, 1 Number and at least 1 Special Character.";
                        Hide();
                    }
                    //else condition is all available and cpassword is still null
                    else if (checkpassword == true)
                    {
                        validatePassword.Show();
                        validatePassword.ForeColor = Color.ForestGreen;
                        validatePassword.Text = "Ok!";
                        validatePassword.Hide();
                    }
                }
                //check if cpassword and password does not matches with one another
                else
                {
                    validatecPasword.Show();
                    validatecPasword.ForeColor = Color.Red;
                    validatecPasword.Text = "Password not match";
                }
            }
            else
            {
                //cpassword and password matches but password does not matches the conditions
                if (checkpassword == false)
                {
                    validatePassword.Show();
                    validatePassword.ForeColor = Color.Red;
                    validatePassword.Text = "Please ensure that Password contains 8-16 characters, 1 Lower Case, 1 Upper Case, 1 Number and at least 1 Special Character.";
                }
                if (CPassword.Text == "" || CPassword.Text == null || Password.Text == "" || Password.Text == null)
                {

                }
                else
                {
                    if (checkpassword == true)
                    {
                        if (oldPassword.Text == Password.Text)
                        {
                            validatePassword.Show();
                            validatePassword.ForeColor = Color.Red;
                            validatePassword.Text = "New password cannot be same as old password!";
                        }
                        else
                        {
                            //clear condition
                            validatePassword.Show();
                            validatePassword.ForeColor = Color.ForestGreen;
                            validatePassword.Text = "Ok!";
                        }
                    }
                    //cpassword and password matches
                    validatecPasword.Show();
                    validatecPasword.ForeColor = Color.ForestGreen;
                    validatecPasword.Text = "Match!";
                }
            }
        }

        //passwordchecker
        public int CheckPasswordstrength(string pass)
        {
            int strength = 0;

            //Password length
            if (pass.Length > 8 && pass.Length < 12)
            {
                strength += 1;
            }

            if (pass.Length >= 12)
            {
                strength += 1;
            }

            //At least 1 upper case letter
            if (pass.Any(char.IsUpper))
            {
                strength += 1;
            }

            //At least 1 numeric value
            if (pass.Any(char.IsNumber))
            {
                strength += 1;
            }

            //At least 1 lower case letter
            if (pass.Any(char.IsLower))
            {
                strength += 1;
            }

            //At least 1 special char
            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialCharactersArray = specialCharacters.ToCharArray();
            foreach (char c in specialCharactersArray)
            {
                if (pass.Contains(c))
                {
                    strength += 1;
                }
            }
            return strength;
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
            if (File.Exists("C:/Users/Desmond/Documents/OSPJ/DataAsGuard/DataAsGuard/Profiles/Admin/tempimage.jpg"))
            {

                try
                {
                    File.Delete("C:/Users/Desmond/Documents/OSPJ/DataAsGuard/DataAsGuard/Profiles/Admin/tempimage.jpg");
                    bitmap.Save("C:/Users/Desmond/Documents/OSPJ/DataAsGuard/DataAsGuard/Profiles/Admin/tempimage.jpg", ImageFormat.Jpeg);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {

                bitmap.Save("C:/Users/Desmond/Documents/OSPJ/DataAsGuard/DataAsGuard/Profiles/Admin/tempimage.jpg", ImageFormat.Jpeg);

            }
            bitmap.Dispose();
            pictureBox1.Image = Image.FromFile("C:/Users/Desmond/Documents/OSPJ/DataAsGuard/DataAsGuard/Profiles/Admin/tempimage.jpg");
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

    }
}

