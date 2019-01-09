using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAsGuard;
using Steganography;

namespace DataAsGuard.ImgViewer
{
    public partial class ImgViewerForm : Form
    {
        private Bitmap bmp = null;
        private string extractedText = string.Empty;
        public string path { get; set; }
        Image imgOriginal;  //Delcare imgOriginal Variable
        public ImgViewerForm()
        {
            InitializeComponent();
        }

        Image Zoom(Image img, Size size)    //Image Zoom function
        {
            Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size.Width / 100), img.Height + (img.Height * size.Height / 100));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }

        // DB Stuff
        //DbClass dbCon = new DbClass();
        ////string queryStr = "SELECT username FROM da_schema.Userinfo";
        //List<string> dataDisplay = new List<string>();
        //dataDisplay = dbCon.DbRetrieve("Userinfo", "username");
        //    MessageBox.Show("Connection Open ! ");
        //    foreach (string i in dataDisplay)
        //    {
        //        MessageBox.Show(i);
        //    }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void opnFile_Click(object sender, EventArgs e)  //Function for button to open file
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "JPEG;JPG;PNG|*.jpeg;*.jpg;*.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    showPic.Image = Image.FromFile(ofd.FileName);
                    imgOriginal = showPic.Image;
                }
            }
        }

        private void zoom_Scroll(object sender, EventArgs e)    //For Zoom Scroller
        {
            if (zoom.Value > 0)
            {
                showPic.Image = Zoom(imgOriginal, new Size(zoom.Value, zoom.Value));
            }
        }

        private void ImgViewerForm_FormClosing(object sender, FormClosingEventArgs e)   //Show img
        {
            if (showPic.Image != null)
            {
                showPic.Dispose();
            }
        }

        private void fileNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImgViewerForm_Load(object sender, EventArgs e)
        {
            showPic.Image = Image.FromFile(this.path);
            imgOriginal = showPic.Image;
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            //Hide Text
            string text = DataAsGuard.CSClass.Logininfo.username;
            string password = "Ilovethispic123";
            bmp = (Bitmap)showPic.Image;
            text = Crypto.EncryptStringAES(text, password);
            bmp = SteganographyHelper.embedText(text, bmp);

            //Save image
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Png Image|*.png|Bitmap Image|*.bmp";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                switch (save_dialog.FilterIndex)
                {
                    case 0:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Png);
                        }
                        break;
                    case 1:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Bmp);
                        }
                        break;
                }

            }
        }
    }
}
