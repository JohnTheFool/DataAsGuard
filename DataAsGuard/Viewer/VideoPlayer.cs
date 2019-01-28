using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAsGuard.Viewer
{
    public partial class VideoPlayer : Form
    {
        public string videoPath { get; set; }
        public VideoPlayer()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(VideoPlayer_FormClosing);
        }

        private void VideoPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete(videoPath);
        }
        //private void chooseFileBtn_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFileDialog1 = new OpenFileDialog();
        //    if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
        //        this.filePathBox.Text = openFileDialog1.FileName;
        //        axWindowsMediaPlayer1.URL = filePathBox.Text;
        //    }
        //}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            //{
                axWindowsMediaPlayer1.fullScreen = true;
            //}
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            File.Delete(videoPath);
            Home home = new Home();
            home.Show();
            Hide();
        }

        private void videoLoad(object sender, EventArgs e)
        {
            //this.filePathBox.Text = this.videoPath;
            axWindowsMediaPlayer1.URL = this.videoPath;
        }
    }
}
