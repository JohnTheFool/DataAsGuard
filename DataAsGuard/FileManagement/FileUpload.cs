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

namespace DataAsGuard.FileManagement
{
    public partial class FileUpload : Form
    {
        public FileUpload()
        {
            InitializeComponent();
        }

        private void BrowseButton_click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Word Documents|*.docx|Excel Worksheets|*.xlsx|PowerPoint Presentations|*.pptx|Office Files|*.docx;*.xlsx;*.pptx|All Files|*.*", // allowed file types
                Multiselect = false // allow/deny user to upload more than one file at a time
            };
            if (dialog.ShowDialog() == DialogResult.OK) // if OK clicked
            {
                String path = dialog.FileName; // get name of file
                String pathfileName = dialog.SafeFileName;
                var size = new FileInfo(dialog.FileName).Length;
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do wtv
                {
                    fileUploaded.Text = path;
                    fileSize.Text = size.ToString();
                    fileName.Text = pathfileName;
                }
            }
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            //insert into database
        }

        private void groupList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
