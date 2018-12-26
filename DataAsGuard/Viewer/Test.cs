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
using DataAsGuard.DB;
using DSOFile;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;

namespace DataAsGuard.Viewer
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FileInfo oFileInfo = new FileInfo("C:\\Users\\Solomon\\Downloads\\Files\\testdoc.docx");

            //if (oFileInfo != null || oFileInfo.Length == 0)
            //{
            //    MessageBox.Show("My File's Name: \"" + oFileInfo.Name + "\"");
            //    // For calculating the size of files it holds.
            //    MessageBox.Show("myFile total Size: " + oFileInfo.Length.ToString());
            //}

            //string user = System.IO.File.GetAccessControl("C:\\Users\\Solomon\\Downloads\\Files\\atext.txt").GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();
            //MessageBox.Show(user);
            //var myObject = ShellObject.FromParsingName("C:\\Users\\Solomon\\Downloads\\Files\\atext.txt");
            //IShellProperty prop = myObject.Properties.GetProperty("Type");

            object yourValue = "I LOVE AOA";
            OleDocumentProperties myFile = new DSOFile.OleDocumentProperties();
            myFile.Open(@"C:\\Users\\Solomon\\Downloads\\Files\\new.txt", false, DSOFile.dsoFileOpenOptions.dsoOptionDefault);
            foreach (DSOFile.CustomProperty property in myFile.CustomProperties)
            {
                if (property.Name == "ACE OF ANGELS")
                {
                    //Property exists
                    //End the task here (return;) oder edit the property
                    property.set_Value(yourValue);
                }
            }
            myFile.CustomProperties.Add("ACE OF ANGELS", ref yourValue);
            myFile.Save();
            myFile.Close(true);
            MessageBox.Show("Saved!");
            //DbClass dbCon = new DbClass();

            //List<string> dataDisplay = new List<string>();

            //dataDisplay = dbCon.DbRetrieve("Userinfo", "sh_9513");

            //foreach(string i in dataDisplay)
            //{
            //    Console.WriteLine(i);
            //    MessageBox.Show(i);
            //}
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    foreach (var prop in new ShellPropertyCollection(@"C:\\Users\\Solomon\\Pictures\\erms.png"))
        //    {
        //        Console.WriteLine(prop.CanonicalName + "=" + prop.ValueAsObject);
        //    }
        //}
    }
}
