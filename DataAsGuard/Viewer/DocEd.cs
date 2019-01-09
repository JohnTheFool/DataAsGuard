using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAsGuard;
using DataAsGuard.FileManagement;
using DataAsGuard.Profiles;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using MySql.Data.MySqlClient;
using Microsoft.Office.Interop.Word;

namespace DataAsGuard.Viewer
{
    public partial class DocEd : Form
    {
        public string GetText { get; set; }

        public string GetUsername { get; set; }

        public DocEd()
        {
            InitializeComponent();
        }

        Color colour = Color.Black;
        bool isUnderline = true;
        bool isBold = true;
        bool isItalic = true;
        private void btnSave_Click(object sender, EventArgs e)
        {
            //rtfBox.SelectionColor = colour;
            //if (check)
            //    rtfBox.SelectedText = txtValue.Text;
            //else
            //    rtfBox.AppendText(Environment.NewLine + txtValue.Text);
            //check = false;
            //txtValue.Clear();
            //txtValue.Focus();
            //rtfBox.SelectAll();
            //rtfBox.SelectionColor = colour;
            //rtfBox.SelectionBackColor = rtfBox.BackColor;
            //rtfBox.DeselectAll();

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents;Word Document;RTF |*.txt;*.docx;*.rtf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    rtfBox.SaveFile(sfd.FileName);
                    //using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    //{
                    //    await sw.WriteLineAsync(rtfBox.Text);
                    //    MessageBox.Show("File Saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                }
            }
        }

        private void pColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colour = colorDialog1.Color;
                pColor.BackColor = colour;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Hide();
        }

        private void boldBtn_Click(object sender, EventArgs e)
        {
            //rtfBox.SelectionFont = new Font(rtfBox.Font.FontFamily, rtfBox.Font.Size, FontStyle.Bold);

            int selstart = rtfBox.SelectionStart;
            int sellength = rtfBox.SelectionLength;

            // Set font of selected text
            // You can use FontStyle.Bold | FontStyle.Italic to apply more than one style
            if (isBold)
            {
                rtfBox.SelectionFont = new System.Drawing.Font(rtfBox.Font, FontStyle.Bold);
                isBold = false;
            }

            else
            {
                rtfBox.SelectionFont = new System.Drawing.Font(rtfBox.Font, FontStyle.Regular);
                isBold = true;
            }

            // Set cursor after selected text
            rtfBox.SelectionStart = rtfBox.SelectionStart + rtfBox.SelectionLength;
            rtfBox.SelectionLength = 0;
            // Set font immediately after selection
            rtfBox.SelectionFont = rtfBox.Font;

            // Reselect previous text
            rtfBox.Select(selstart, sellength);
        }

        private void colorSelectBtn_Click(object sender, EventArgs e)
        {
            int selstart = rtfBox.SelectionStart;
            int sellength = rtfBox.SelectionLength;
            rtfBox.SelectionColor = colour;
            rtfBox.SelectionStart = rtfBox.SelectionStart + rtfBox.SelectionLength;
            rtfBox.SelectionLength = 0;
            rtfBox.Select(selstart, sellength);
        }

        //private void txtValue_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        rtfBox.SelectionColor = colour;
        //        if (check)
        //            rtfBox.SelectedText = txtValue.Text;
        //        else
        //            rtfBox.AppendText(Environment.NewLine + txtValue.Text);
        //        check = false;
        //        txtValue.Clear();
        //        txtValue.Focus();
        //    }
        //}

        private void DocEd_Load(object sender, EventArgs e)
        {
            rtfBox.Text = this.GetText;
            //FileManagement.FileManagementHub n = new FileManagement.FileManagementHub();
            //string something = n.store;
            //Console.WriteLine(something);
            //MessageBox.Show(this.MyProperty);
            //Console.WriteLine(this.MyProperty);
            //Console.WriteLine(n.dope());
            //string rtfbox;
            //byte[] fileBytes = new byte[] { 0x0 };
            //using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            //{
            //    con.Open();
            //    String fileQuery = "SELECT * FROM fileInfo WHERE fileName = @nameParam";
            //    MySqlCommand getFilecmd = new MySqlCommand(fileQuery, con);
            //    getFilecmd.Parameters.AddWithValue("@nameParam", n.nameOfFile);
            //    MySqlDataReader reader = getFilecmd.ExecuteReader();
            //    if (reader.Read())
            //    {
            //        fileBytes = (byte[])reader["file"];
            //        Console.WriteLine(fileBytes);
            //    }
            //    reader.Close();
            //    string somethin = n.tempFileName + n.fileExtension;
            //    File.WriteAllBytes(n.tempFileName, fileBytes);
            //    Console.WriteLine(somethin);
            //    var process = Process.Start(n.tempFileName);
            //    process.Exited += (s, ev) => File.Delete(n.tempFileName);
            //    var stream = new StreamReader(new MemoryStream(fileBytes));
            //    rtfbox = stream.ReadLine();
            //    rtfBox.Text = rtfbox;

            //}
            //rtfbox = File.ReadAllText(n.nameOfFile);
            //Console.WriteLine(n.tempFileName);
            //rtfBox.Text = n.bobo;

        }

        private void italicBtn_Click(object sender, EventArgs e)
        {
            //rtfBox.SelectionFont = new Font(rtfBox.Font.FontFamily, rtfBox.Font.Size, FontStyle.Bold);
            int selstart = rtfBox.SelectionStart;
            int sellength = rtfBox.SelectionLength;

            // Set font of selected text
            // You can use FontStyle.Bold | FontStyle.Italic to apply more than one style
            if (isItalic)
            {
                rtfBox.SelectionFont = new System.Drawing.Font(rtfBox.Font, FontStyle.Italic);
                isItalic = false;
            }
            else
            {
                rtfBox.SelectionFont = new System.Drawing.Font(rtfBox.Font, FontStyle.Regular);
                isItalic = true;
            }
            // Set cursor after selected text
            rtfBox.SelectionStart = rtfBox.SelectionStart + rtfBox.SelectionLength;
            rtfBox.SelectionLength = 0;
            // Set font immediately after selection
            rtfBox.SelectionFont = rtfBox.Font;
            // Reselect previous text
            rtfBox.Select(selstart, sellength);
        }

        private void underlineBtn_Click(object sender, EventArgs e)
        {
            int selstart = rtfBox.SelectionStart;
            int sellength = rtfBox.SelectionLength;
            if (isUnderline)
            {
                rtfBox.SelectionFont = new System.Drawing.Font(rtfBox.Font, FontStyle.Underline);
                isUnderline = false;
            }
            else
            {
                rtfBox.SelectionFont = new System.Drawing.Font(rtfBox.Font, FontStyle.Regular);
                isUnderline = true;
            }
            rtfBox.SelectionStart = rtfBox.SelectionStart + rtfBox.SelectionLength;
            rtfBox.SelectionLength = 0;
            rtfBox.SelectionFont = rtfBox.Font;
            rtfBox.Select(selstart, sellength);
        }

        private void CreateDocument(string header, string footer, string content)
        {
            try
            {
                //Create an instance for word app
                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                //Set animation status for word application
                winword.ShowAnimation = false;

                //Set status for word application is to be visible or not.
                winword.Visible = false;

                //Create a missing variable for missing value
                object missing = System.Reflection.Missing.Value;

                //Create a new document
                Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                //Add header into the document
                foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
                {
                    //Get the header range and add the header details.
                    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue;
                    headerRange.Font.Size = 10;
                    headerRange.Text = header;
                }

                //Add the footers into the document
                foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
                {
                    //Get the footer range and add the footer details.
                    Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
                    footerRange.Font.Size = 10;
                    footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    footerRange.Text = footer;
                }

                //adding text to document
                document.Content.SetRange(0, 0);
                document.Content.Text = "Content" + Environment.NewLine;

                //Add paragraph with Heading 1 style
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading1 = "Heading 1";
                para1.Range.set_Style(ref styleHeading1);
                para1.Range.Text = "Para 1 text";
                para1.Range.InsertParagraphAfter();

                //Add paragraph with Heading 2 style
                Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading2 = "Heading 2";
                para2.Range.set_Style(ref styleHeading2);
                para2.Range.Text = "Para 2 text";
                para2.Range.InsertParagraphAfter();

                //Create a 5X5 table and insert some dummy record
                Table firstTable = document.Tables.Add(para1.Range, 5, 5, ref missing, ref missing);

                firstTable.Borders.Enable = 1;
                foreach (Row row in firstTable.Rows)
                {
                    foreach (Cell cell in row.Cells)
                    {
                        //Header row
                        if (cell.RowIndex == 1)
                        {
                            cell.Range.Text = "Column " + cell.ColumnIndex.ToString();
                            cell.Range.Font.Bold = 1;
                            //other format properties goes here
                            cell.Range.Font.Name = "verdana";
                            cell.Range.Font.Size = 10;
                            //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                            
                            cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                            //Center alignment for the Header cells
                            cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                        }
                        //Data row
                        else
                        {
                            cell.Range.Text = (cell.RowIndex - 2 + cell.ColumnIndex).ToString();
                        }
                    }
                }

                //Save the document
                object filename = @"C:\\Users\\Solomon\\Documents\\test.docx";
                document.SaveAs2(ref filename);
                document.Close(ref missing, ref missing, ref missing);
                document = null;
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;
                MessageBox.Show("Document created successfully !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rtfBox_KeyDown(object sender, KeyEventArgs e)
        {
            //using (MySqlConnection conn = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            //{
            //    conn.Open();
            //    //Retrieve group info from DB
            //    String query = "SELECT * FROM groupFilePermissions WHERE readPermission == '0'";
            //    MySqlCommand cmd = new MySqlCommand(query, conn);
            //    MySqlDataReader reader = cmd.ExecuteReader();
            //    if (reader.Read())
            //    {

            //    }
            //    reader.Close();
            //    if (e.Control && e.KeyCode == Keys.C)
            //    {
            //        e.SuppressKeyPress = true;
            //    }
            //}
        }

        public bool IsFileLock(string filePath)
            {
                FileStream stream = null;
                try
                {
                    stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                }
                catch (IOException)
                {
                    return true;
                }
                finally
                {
                    if (stream != null)
                        stream.Close();
                }
                return false;
            }

            private void openToolStripMenuItem_Click(object sender, EventArgs e)
            {
            //FileManagementHub open = new FileManagementHub();
            //open.Show();
            //this.Hide();
            //string fileExtension = Path.GetExtension(nameOfFile);
            //string tempFileName = System.IO.Path.GetTempFileName() + "." + fileExtension;
            rtfBox.Clear();
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Text Files;RTF;DOCX|*.txt;*.rtf;*.docx";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                var extension = Path.GetExtension(open_dialog.FileName);
                string rtfbox;
                switch (extension.ToLower())
                {
                    case ".rtf":
                        if (IsFileLock(open_dialog.FileName))
                        {
                            MessageBox.Show("File is in use!");
                        }
                        else
                        {
                            rtfbox = File.ReadAllText(open_dialog.FileName);     //Read content
                            rtfBox.Rtf = rtfbox;                                //Display content in rtf file in rtb
                        }

                        break;
                    case ".txt":
                        if (IsFileLock(open_dialog.FileName))
                        {
                            MessageBox.Show("File is in use!");
                        }
                        else
                        {
                            rtfbox = File.ReadAllText(open_dialog.FileName);
                            rtfBox.Text = rtfbox;
                        }
                        break;
                    case ".docx":
                        if (IsFileLock(open_dialog.FileName))
                        {
                            MessageBox.Show("File is in use!");
                        }
                        else
                        {
                            object readOnly = true;
                            object fileName = open_dialog.FileName;
                            object missing = System.Reflection.Missing.Value;
                            var applicationWord = new Microsoft.Office.Interop.Word.Application();
                            applicationWord.Visible = true;
                            //object gg = applicationWord.DocumentBeforeSave();
                            applicationWord.Options.SavePropertiesPrompt = false;
                            applicationWord.Options.SaveNormalPrompt = false;
                            applicationWord.DisplayAlerts = WdAlertLevel.wdAlertsNone;
                            applicationWord.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
                            //object doNotSaveChanges = Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges;
                            //applicationWord.ActiveDocument.Close(ref doNotSaveChanges, ref missing, ref missing);
                        }


                        break;
                    default:
                        throw new ArgumentOutOfRangeException(extension);
                }
            }
        }

            private void saveToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            private void testBtn_Click(object sender, EventArgs e)
            {
                // Write properties to file
                string filePath = @"C:\\Users\Solomon\\Pictures\\Test1.docx";
                var file = ShellFile.FromFilePath(filePath);

                // Read and Write:

                string[] oldAuthors = file.Properties.System.Author.Value;
                string oldTitle = file.Properties.System.Title.Value;

                file.Properties.System.Comment.Value = "©COPYRIGHT DATAASGUARD";
                file.Properties.System.Title.Value = "Seolhyun";

                // Alternate way to Write:

                ShellPropertyWriter propertyWriter = file.Properties.GetPropertyWriter();
                //propertyWriter.WriteProperty(SystemProperties.System.Comment, new string[] { "Comment" });
                propertyWriter.Close();

                // Read File extended properties
                List<string> arrHeaders = new List<string>();
                List<Tuple<int, string, string>> attributes = new List<Tuple<int, string, string>>();

                Shell32.Shell shell = new Shell32.Shell();
                var strFileName = @"C:\Users\Solomon\Pictures\Test1.docx";
                Shell32.Folder objFolder = shell.NameSpace(System.IO.Path.GetDirectoryName(strFileName));
                Shell32.FolderItem folderItem = objFolder.ParseName(System.IO.Path.GetFileName(strFileName));


                for (int i = 0; i < short.MaxValue; i++)
                {
                    string header = objFolder.GetDetailsOf(null, i);
                    if (String.IsNullOrEmpty(header))
                        break;
                    arrHeaders.Add(header);
                }

                // The attributes list below will contain a tuple with attribute index, name and value
                // Once you know the index of the attribute you want to get, 
                // you can get it directly without looping, like this:
                var Authors = objFolder.GetDetailsOf(folderItem, 20);

                for (int i = 0; i < arrHeaders.Count; i++)
                {
                    var attrName = arrHeaders[i];
                    var attrValue = objFolder.GetDetailsOf(folderItem, i);
                    var attrIdx = i;

                    attributes.Add(new Tuple<int, string, string>(attrIdx, attrName, attrValue));

                    Console.WriteLine("{0}\t{1}: {2}", i, attrName, attrValue);
                }
                Console.ReadLine();
            }

        private async void downloadBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(DataAsGuard.CSClass.Logininfo.username);
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents; |*.txt;", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var extension = Path.GetExtension(sfd.FileName);
                    switch (extension.ToLower())
                    {
                        case ".rtf":
                            rtfBox.SaveFile(sfd.FileName);
                            MessageBox.Show("File Saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case ".txt":
                            using (StreamWriter sw = new StreamWriter(sfd.FileName))
                            {
                                await sw.WriteLineAsync(rtfBox.Text);
                                MessageBox.Show("File Saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            System.Diagnostics.Process process = new System.Diagnostics.Process();
                            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                            startInfo.FileName = "cmd.exe";
                            //startInfo.Arguments = "/C echo 'SECRET MSG' > C:\\Users\\Solomon\\Documents\\something.txt:SOMETHING";
                            //Write Hidden text to file
                            startInfo.Arguments = "/C echo " + DataAsGuard.CSClass.Logininfo.username + " > " + sfd.FileName + ":DS1";
                            process.StartInfo = startInfo;
                            process.Start();
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(extension);
                    }
                }
            }
        }
    }
    }

