using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataAsGuard.Profiles.Admin
{
    public partial class RegistrationDetails : Form
    {

        private Random rand = new Random();

        public RegistrationDetails()
        {
            InitializeComponent();
        }

        private void Registration_Shown(Object sender, EventArgs e)
        {
            //userdataRetrieval();
            CreateImage();
        }

        private void userdataRetrieval()
        {
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {

                con.Open();
                String query = "SELECT * FROM Userinfo WHERE userid='1'";
                MySqlCommand command = new MySqlCommand(query, con);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        name.Text = reader.GetString(reader.GetOrdinal("username"));
                        phoneNo.Text = reader.GetInt32(reader.GetOrdinal("phoneno.")).ToString();
                        email.Text = reader.GetString(reader.GetOrdinal("email"));
                        DOB.Text = reader.GetString(reader.GetOrdinal("dob"));

                    }

                    if (reader != null)
                        reader.Close();
                }

            }
        }

        //SMTP PROTOCOL AFTER REGISTERING
        public static void sendMsg(string Email, string Password, string Firstname, string Lastname, string Username)
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
            msg.Body = "Hello " + Firstname + " " + Lastname + ", Your Account has been Registered for DataAsguard!";

            msg.Body += "<tr>";
            msg.Body += "<td>Your Account Details are given below: </td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>User Name: " + Username + "</td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>User Name: " + Password + "</td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Please check your login to your account!</td>";
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

            string fromAddress = "\"DataAsguard \" <dataasguard@gmail.com";
            msg.From = new MailAddress(fromAddress);
            msg.IsBodyHtml = true;

            try
            {
                smtp.Send(msg);
            }
            catch
            {
                throw;
            }

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (captchabox.Text == code.ToString())
            {
                RegistrationConfirm Confirm = new RegistrationConfirm();
                Confirm.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("Incorrect entry");
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
            if (File.Exists("C:/Users/Desmond/Documents/OSPJ/DataAsGuard/DataAsGuard/Profiles/Admin/tempimage.jpg"))
            {

                try
                {
                    File.Delete("C:/Users/Desmond/Documents/OSPJ/DataAsGuard/DataAsGuard/Profiles/Admin/tempimage.jpg");
                    bitmap.Save("C:/Users/Desmond/Documents/OSPJ/DataAsGuard/DataAsGuard/Profiles/Admin/tempimage.jpg",ImageFormat.Jpeg);

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

            if (String.IsNullOrEmpty(code))
            {
                string alphabets = "abcdefghijklmnopqrstuvwxyz1234567890";

                Random r = new Random();
                for (int j = 0; j <= 5; j++)
                {

                    randomText.Append(alphabets[r.Next(alphabets.Length)]);
                }

                code = randomText.ToString();
            }

            return code;
        }

    }
}
