using DataAsGuard.CSClass;
using MySql.Data.MySqlClient;
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
using DataAsGuard.Viewer;
using Microsoft.Office.Interop.Word;
using Steganography;
using System.Drawing.Imaging;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using iTextSharp.text.pdf;
using System.Collections;
using Microsoft.Office.Core;

namespace DataAsGuard.FileManagement
{
    public partial class FileManagementHub : Form
    {
        private Bitmap bmp = null;
        public Image GetImg { get; set; }
        string tempFileName;
        int fileID = 0;
        List<int> groupIDList = new List<int>();
        DBLogger dblog = new DBLogger();

        public FileManagementHub()
        {
            InitializeComponent();
        }

        private void FileManagementHub_Load(object sender, EventArgs e)
        {
            LoadFileInfoFromDB();
        }

        private bool CheckFileLock(string fileName)
        {
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                string lockNo;
                bool aValue = false;
                String fileQuery = "SELECT * FROM fileInfo WHERE fileName = @nameParam";
                MySqlCommand getFilecmd = new MySqlCommand(fileQuery, con);
                getFilecmd.Parameters.AddWithValue("@nameParam", fileName);
                MySqlDataReader reader = getFilecmd.ExecuteReader();
                if (reader.Read())
                {
                    lockNo = reader["fileLock"].ToString();
                    if (lockNo == "0")
                    {
                        //openFileButton.Enabled = true;
                        aValue = false;
                    }
                    else if (lockNo == "1")
                    {
                        //openFileButton.Enabled = false;
                        aValue = true;
                    }
                }
                reader.Close();
                con.Close();
                Console.WriteLine(aValue);
                return aValue;
            }
        }

        private void LoadFileInfoFromDB()
        {
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM da_schema.fileInfo";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    fileList.Items.Add(reader["fileName"].ToString());
                }
                reader.Close();
                con.Close();
            }
        }

        private void fileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileInformation.Clear();
            userPermGrid.Rows.Clear();
            userPermGrid.Refresh();
            groupPermGrid.Rows.Clear();
            groupPermGrid.Refresh();

            editUserPermButton.Enabled = false;
            editGroupPermButton.Enabled = false;
            openFileButton.Enabled = false;
            deleteFileButton.Enabled = false;
            downloadFileButton.Enabled = false;
            transferOwnershipButton.Enabled = false;

            ArrayList userPermRow = new ArrayList();
            ArrayList groupPermRow = new ArrayList();

            string fileOwnerID = null;
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                try
                {
                    string curItem = fileList.SelectedItem.ToString();

                    //Retrieve file info from DB
                    String fileInfoquery = "SELECT * FROM fileInfo WHERE fileName = @nameParam";
                    MySqlCommand fileInfocmd = new MySqlCommand(fileInfoquery, con);
                    fileInfocmd.Parameters.AddWithValue("@nameParam", curItem);
                    MySqlDataReader reader = fileInfocmd.ExecuteReader();
                    if (reader.Read())
                    {
                        fileInformation.AppendText("Date Created: " + reader["dateCreated"].ToString());
                        fileInformation.AppendText(Environment.NewLine + "File Owner: " + reader["fileOwner"].ToString());
                        fileInformation.AppendText(Environment.NewLine + "File Description: " + reader["description"].ToString());
                        fileOwnerID = reader["fileOwnerID"].ToString();
                        fileID = Convert.ToInt32(reader["fileID"]);
                    }
                    reader.Close();

                    //Get user permissions for dataGrid
                    String userpermQuery = "SELECT * FROM userFilePermissions WHERE fileID = @idParam";
                    MySqlCommand getPermcmd = new MySqlCommand(userpermQuery, con);
                    getPermcmd.Parameters.AddWithValue("@idParam", fileID);
                    MySqlDataReader permreader = getPermcmd.ExecuteReader();
                    while (permreader.Read())
                    {
                        userPermRow.Add(Convert.ToInt32(permreader["userID"]));
                        userPermRow.Add(Convert.ToInt32(permreader["readPermission"]));
                        userPermRow.Add(Convert.ToInt32(permreader["editPermission"]));
                        userPermRow.Add(Convert.ToInt32(permreader["downloadPermission"]));
                    }
                    permreader.Close();

                    //Get group permissions for dataGrid
                    String grouppermQuery = "SELECT * FROM groupFilePermissions WHERE fileID = @idParam";
                    MySqlCommand getGroupPermcmd = new MySqlCommand(grouppermQuery, con);
                    getGroupPermcmd.Parameters.AddWithValue("@idParam", fileID);
                    MySqlDataReader permreader2 = getGroupPermcmd.ExecuteReader();
                    while (permreader2.Read())
                    {
                        groupPermRow.Add(Convert.ToInt32(permreader2["groupID"]));
                        groupPermRow.Add(Convert.ToInt32(permreader2["readPermission"]));
                        groupPermRow.Add(Convert.ToInt32(permreader2["editPermission"]));
                        groupPermRow.Add(Convert.ToInt32(permreader2["downloadPermission"]));
                    }
                    permreader2.Close();

                    for (int i = 0; i < userPermRow.Count - 3; i += 4)
                    {
                        //Get user name from userID
                        String userQuery = "SELECT * FROM Userinfo WHERE userid = @idParam";
                        MySqlCommand userQueryCmd = new MySqlCommand(userQuery, con);
                        userQueryCmd.Parameters.AddWithValue("@idParam", userPermRow[i]);
                        MySqlDataReader permreader3 = userQueryCmd.ExecuteReader();
                        if (permreader3.Read())
                        {
                            userPermRow[i] = permreader3["fullName"].ToString();
                        }
                        permreader3.Close();

                        if (Convert.ToInt32(userPermRow[i + 1]) == 1)
                            userPermRow[i + 1] = "Yes";
                        else
                            userPermRow[i + 1] = "No";

                        if (Convert.ToInt32(userPermRow[i + 2]) == 1)
                            userPermRow[i + 2] = "Yes";
                        else
                            userPermRow[i + 2] = "No";

                        if (Convert.ToInt32(userPermRow[i + 3]) == 1)
                            userPermRow[i + 3] = "Yes";
                        else
                            userPermRow[i + 3] = "No";

                        ArrayList newRow = new ArrayList();
                        newRow.Add(userPermRow[i]);
                        newRow.Add(userPermRow[i+1]);
                        newRow.Add(userPermRow[i+2]);
                        newRow.Add(userPermRow[i+3]);
                        userPermGrid.Rows.Add(newRow.ToArray());
                        newRow.Clear();
                    }

                    for (int i = 0; i < groupPermRow.Count - 3; i += 4)
                    {
                        //Get group name from groupID
                        String groupQuery = "SELECT * FROM groupInfo WHERE groupID = @idParam";
                        MySqlCommand groupQueryCmd = new MySqlCommand(groupQuery, con);
                        groupQueryCmd.Parameters.AddWithValue("@idParam", groupPermRow[i]);
                        MySqlDataReader permreader4 = groupQueryCmd.ExecuteReader();
                        if (permreader4.Read())
                        {
                            groupPermRow[i] = permreader4["groupName"].ToString();
                        }
                        permreader4.Close();

                        if (Convert.ToInt32(groupPermRow[i + 1]) == 1)
                            groupPermRow[i + 1] = "Yes";
                        else
                            groupPermRow[i + 1] = "No";

                        if (Convert.ToInt32(groupPermRow[i + 2]) == 1)
                            groupPermRow[i + 2] = "Yes";
                        else
                            groupPermRow[i + 2] = "No";

                        if (Convert.ToInt32(groupPermRow[i + 3]) == 1)
                            groupPermRow[i + 3] = "Yes";
                        else
                            groupPermRow[i + 3] = "No";

                        ArrayList newRow = new ArrayList();
                        newRow.Add(groupPermRow[i]);
                        newRow.Add(groupPermRow[i + 1]);
                        newRow.Add(groupPermRow[i + 2]);
                        newRow.Add(groupPermRow[i + 3]);
                        groupPermGrid.Rows.Add(newRow.ToArray());
                        newRow.Clear();
                    }

                    if (Logininfo.userid == fileOwnerID)
                    {
                        //If owner of file, allow all buttons
                        editUserPermButton.Enabled = true;
                        editGroupPermButton.Enabled = true;
                        openFileButton.Enabled = true;
                        deleteFileButton.Enabled = true;
                        downloadFileButton.Enabled = true;
                        transferOwnershipButton.Enabled = true;
                    }

                    //Check user permissions for the file
                    else
                    {
                        String userPermsQuery = "SELECT * FROM userFilePermissions WHERE fileID = @fileIDParam AND userID = @userIDParam";
                        MySqlCommand userPermsCmd = new MySqlCommand(userPermsQuery, con);
                        userPermsCmd.Parameters.AddWithValue("@userIDParam", Logininfo.userid);
                        userPermsCmd.Parameters.AddWithValue("@fileIDParam", fileID);
                        MySqlDataReader reader2 = userPermsCmd.ExecuteReader();
                        if (reader2.Read())
                        {
                            if (Convert.ToInt32(reader2["readPermission"]) == 1)
                            {
                                openFileButton.Enabled = true;
                            }
                            if (Convert.ToInt32(reader2["editPermission"]) == 1)
                            {
                                //Check with Solo
                            }
                            if (Convert.ToInt32(reader2["downloadPermission"]) == 1)
                            {
                                downloadFileButton.Enabled = true;
                            }
                        }
                        reader2.Close();

                        //Check user's groups
                        String userGroupsQuery = "SELECT * FROM groupUsers WHERE userID = @userIDParam";
                        MySqlCommand userGroupsCmd = new MySqlCommand(userGroupsQuery, con);
                        userGroupsCmd.Parameters.AddWithValue("@userIDParam", Logininfo.userid);
                        MySqlDataReader reader3 = userGroupsCmd.ExecuteReader();
                        while (reader3.Read())
                        {
                            groupIDList.Add(Convert.ToInt32(reader3["groupID"]));
                        }
                        reader3.Close();

                        //Check group permissions for all the user's groups
                        for (int i = 0; i < groupIDList.Count; i++)
                        {
                            String groupPermsQuery = "SELECT * FROM groupFilePermissions WHERE fileID = @fileIDParam AND groupID = @groupIDParam";
                            MySqlCommand groupPermsCmd = new MySqlCommand(groupPermsQuery, con);
                            groupPermsCmd.Parameters.AddWithValue("@fileIDParam", fileID);
                            groupPermsCmd.Parameters.AddWithValue("@groupIdParam", groupIDList[i]);
                            MySqlDataReader reader4 = groupPermsCmd.ExecuteReader();
                            while (reader4.Read())
                            {
                                if (Convert.ToInt32(reader4["readPermission"]) == 1)
                                {
                                    openFileButton.Enabled = true;
                                }
                                if (Convert.ToInt32(reader4["editPermission"]) == 1)
                                {
                                    //Check with Solo
                                }
                                if (Convert.ToInt32(reader4["downloadPermission"]) == 1)
                                {
                                    downloadFileButton.Enabled = true;
                                }
                            }
                            reader4.Close();
                        }


                    }
                }
                catch (NullReferenceException)
                {
                    //Do nothing
                }
                con.Close();

            }
        }

        public bool IsFileLock(string filePath)
        {
            FileStream stream = null;
            try
            {
                stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                stream.Close();
            }
            catch (IOException)
            {
                return true;
            }
            //finally
            //{
            //    if (stream != null)
            //        stream.Close();
            //}
            return false;
        }

        private string setLock(string fileName)
        {
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();

                string lockNo = "1";
                String fileLockQuery = "UPDATE da_schema.fileInfo SET fileLock = '1' WHERE fileName = @lockNo";
                MySqlCommand fileLockCmd = new MySqlCommand(fileLockQuery, con);
                fileLockCmd.Parameters.AddWithValue("@lockNo", fileName);
                fileLockCmd.ExecuteNonQuery();
                return lockNo;
            }
        }

        private string releaseLock(string fileName)
        {
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();

                string lockNo = "0";
                String fileLockQuery = "UPDATE da_schema.fileInfo SET fileLock = '0' WHERE fileName = @lockNo";
                MySqlCommand fileLockCmd = new MySqlCommand(fileLockQuery, con);
                fileLockCmd.Parameters.AddWithValue("@lockNo", fileName);
                fileLockCmd.ExecuteNonQuery();
                return lockNo;
            }
        }

        async System.Threading.Tasks.Task PutTaskDelay()
        {
            await System.Threading.Tasks.Task.Delay(5000);
        }

        public Boolean UpdateFileToDb(string readFile,string fileName)
        {
            byte[] fileBytes = null;
            Boolean success = false;
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                    try
                    {
                        fileBytes = File.ReadAllBytes(readFile);
                        String executeQuery = "UPDATE da_schema.fileInfo SET file = @fileParam WHERE fileName = @fileName";
                        MySqlCommand myCommand = new MySqlCommand(executeQuery, con);
                        myCommand.Parameters.AddWithValue("@fileParam", fileBytes);
                        myCommand.Parameters.AddWithValue("@fileName", fileName);
                        myCommand.ExecuteNonQuery();
                        success = true;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error file could not be read, please try again.");
                        success = false;
                    }
                con.Close();
            }

            //if (success)
            //{
            //    dblog.fileLog("File '" + fileName + "' uploaded to database.", "FileActions", Logininfo.userid.ToString(), Logininfo.email.ToString(), fileID.ToString());
            //}

            return success;
        }

        private string CheckWriteOnlyUser(string userId, string fileName)
        {
            string isWrite = "";
            string fileId = "";
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String fileIdQuery = "SELECT fileID FROM da_schema.fileInfo WHERE fileName = @nameParam";
                MySqlCommand getFileIdcmd = new MySqlCommand(fileIdQuery, con);
                getFileIdcmd.Parameters.AddWithValue("@nameParam", fileName);
                MySqlDataReader reader = getFileIdcmd.ExecuteReader();
                if (reader.Read())
                {
                    fileId = reader["fileId"].ToString();
                }
                reader.Close();

                String fileWritePermQuery = "SELECT editPermission FROM da_schema.userFilePermissions WHERE fileID = @fileParam AND userID = @userIdParam";
                MySqlCommand getFilePermcmd = new MySqlCommand(fileWritePermQuery, con);
                getFilePermcmd.Parameters.AddWithValue("@fileParam", fileId);
                getFilePermcmd.Parameters.AddWithValue("@userIdParam", userId);
                MySqlDataReader reader2 = getFilePermcmd.ExecuteReader();
                if (reader2.Read())
                {
                    isWrite = reader2["editPermission"].ToString();
                }
                reader2.Close();
                con.Close();
                return isWrite;
            }
        }

        private string GetFileId(string fileName)
        {
            string fileId = "";
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();

                // Get FIle ID
                String fileIdQuery = "SELECT * FROM da_schema.fileInfo WHERE fileName = @nameParam";
                MySqlCommand getFileIdcmd = new MySqlCommand(fileIdQuery, con);
                getFileIdcmd.Parameters.AddWithValue("@nameParam", fileName);
                MySqlDataReader reader = getFileIdcmd.ExecuteReader();
                if (reader.Read())
                {
                    fileId = reader["fileId"].ToString();
                }
                reader.Close();
                con.Close();
            }
            return fileId;
        }

        private List<string> GetGroupId(string userId)
        {
            List<string> groupIdList = new List<string>();
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String grpIdQuery = "SELECT * FROM da_schema.groupUsers WHERE userID = @userParam";
                MySqlCommand getGroupIdcmd = new MySqlCommand(grpIdQuery, con);
                getGroupIdcmd.Parameters.AddWithValue("@userParam", userId);
                MySqlDataReader reader2 = getGroupIdcmd.ExecuteReader();
                //while (reader2.HasRows)
                //{
                while (reader2.Read())
                {
                    groupIdList.Add(reader2["groupID"].ToString());
                }
                reader2.Close();
                con.Close();
            }
            return groupIdList;
        }

        private string CheckWriteOnlyGroup(string fileId, string groupId)
        {
            string isWrite = "";
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();

                String fileWritePermQuery = "SELECT * FROM da_schema.groupFilePermissions WHERE groupID = @groupIdParam AND fileID = @fileIdParam";
                MySqlCommand getFilePermcmd = new MySqlCommand(fileWritePermQuery, con);
                getFilePermcmd.Parameters.AddWithValue("@fileIdParam", fileId);
                //for (int i = 0; i < groupIdList.Count; i++)
                //{
                getFilePermcmd.Parameters.AddWithValue("@groupIdParam", groupId);
                MySqlDataReader reader3 = getFilePermcmd.ExecuteReader();
                if (reader3.Read())
                {
                    isWrite = reader3["editPermission"].ToString();
                }
                reader3.Close();
                con.Close();
            }
            return isWrite;
        }

        //public string nameOfFile { get; set; }
        //public string fileExtension { get;  set; }
        //public string tempFileName { get; set; }
        //public string bobo { get; set; }


        private async void openFileButton_Click(object sender, EventArgs e)
        {
            string nameOfFile = fileList.SelectedItem.ToString();
            string fileExtension = Path.GetExtension(nameOfFile);
            tempFileName = Path.GetTempFileName() + "." + fileExtension;
            //if (IsFileLock(tempFileName) == true)
            //{
            //    MessageBox.Show("open");
            //}
                if (CheckFileLock(nameOfFile) == false)
            {
                setLock(nameOfFile);
                byte[] fileBytes = new byte[] { 0x0 };
                using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
                {
                    con.Open();
                    String fileQuery = "SELECT * FROM fileInfo WHERE fileName = @nameParam";
                    MySqlCommand getFilecmd = new MySqlCommand(fileQuery, con);
                    getFilecmd.Parameters.AddWithValue("@nameParam", fileList.SelectedItem.ToString());
                    MySqlDataReader reader = getFilecmd.ExecuteReader();
                    if (reader.Read())
                    {
                        fileBytes = (byte[])reader["file"];
                    }
                    reader.Close();
                    File.WriteAllBytes(tempFileName, fileBytes);
                    if (fileExtension == ".txt")
                    {
                        object readOnly = false;
                        string isWriteGroup = "";
                        string isWrite = CheckWriteOnlyUser(CSClass.Logininfo.userid, nameOfFile);
                        string fileId = GetFileId(nameOfFile);
                        List<string> groupId = GetGroupId(CSClass.Logininfo.userid);
                        //CheckWriteOnlyGroup("4", "Excel Schedule.xlsx");
                        for (int i = 0; i < groupId.Count; i++)
                        {
                            if (CheckWriteOnlyGroup(fileId, groupId[i]) == "True")
                            {
                                isWriteGroup = "True";
                            }
                        }
                        string hu = File.ReadAllText(tempFileName); ;
                        DocEd dd = new DocEd();
                        dd.GetText = hu;
                        dd.GetIsWriteUser = isWrite;
                        dd.GetIsWriteGroup = isWriteGroup;
                        dd.GetReadFile = tempFileName;
                        dd.GetSaveFile = nameOfFile;
                        dd.Show();
                        this.Hide();
                    }
                    else if (fileExtension == ".jpeg" || fileExtension == ".jpg" || fileExtension == ".png")
                    {
                        ImgViewer.ImgViewerForm imgView = new ImgViewer.ImgViewerForm();
                        imgView.path = tempFileName;
                        imgView.Show();
                        this.Hide();
                    }
                    else if (fileExtension == ".mp4")
                    {
                        VideoPlayer vd = new VideoPlayer();
                        vd.videoPath = tempFileName;
                        vd.Show();
                        this.Hide();
                    }
                    else if (fileExtension == ".doc" || fileExtension == ".docx")
                    {
                        object readOnly = false;
                        string isWriteGroup = "";
                        string isWrite = CheckWriteOnlyUser(CSClass.Logininfo.userid, nameOfFile);
                        string fileId = GetFileId(nameOfFile);
                        List<string> groupId = GetGroupId(CSClass.Logininfo.userid);
                        //CheckWriteOnlyGroup("4", "Excel Schedule.xlsx");
                        for (int i = 0; i < groupId.Count; i++)
                        {
                            if (CheckWriteOnlyGroup(fileId, groupId[i]) == "True")
                            {
                                isWriteGroup = "True";
                            }
                        }
                        if (isWrite == "True" || isWriteGroup == "True")
                        {
                            readOnly = false;
                        }
                        else
                        {
                            readOnly = true;
                        }
                        object fileName = tempFileName;
                        object missing = System.Reflection.Missing.Value;
                        var applicationWord = new Microsoft.Office.Interop.Word.Application();
                        applicationWord.Visible = true;
                        //object gg = applicationWord.DocumentBeforeSave();
                        applicationWord.Options.SavePropertiesPrompt = false;
                        applicationWord.Options.SaveNormalPrompt = false;
                        applicationWord.DisplayAlerts = WdAlertLevel.wdAlertsNone;
                        applicationWord.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
                        //applicationWord.DocumentBeforeClose += new EventHandler(process_Exited);
                        //var process = Process.GetProcessesByName(tempFileName);
                        //process[0].Exited += new EventHandler(process_Exited);
                    }
                    else if (fileExtension == ".xlsx")
                    {
                        object readOnly = false;
                        string isWriteGroup = "";
                        string isWriteUser = CheckWriteOnlyUser(CSClass.Logininfo.userid, nameOfFile);
                        //string isWriteGroup = CheckWriteOnlyGroup(, nameOfFile);
                        string fileId = GetFileId(nameOfFile);
                        List<string> groupId = GetGroupId(CSClass.Logininfo.userid);
                        //CheckWriteOnlyGroup("4", "Excel Schedule.xlsx");
                        for (int i = 0; i < groupId.Count; i++)
                        {
                            if (CheckWriteOnlyGroup(fileId, groupId[i]) == "True")
                            {
                                isWriteGroup = "True";
                                //MessageBox.Show("TRUE");
                            }
                        }
                        if (isWriteUser == "True" || isWriteGroup == "True")
                        {
                            readOnly = false;
                        }
                        else
                        {
                            readOnly = true;
                        }
                        string fileName = tempFileName;
                        object missing = System.Reflection.Missing.Value;
                        var applicationExcel = new Microsoft.Office.Interop.Excel.Application();
                        applicationExcel.Visible = true;
                        applicationExcel.Workbooks.Open(fileName, missing, readOnly, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing);
                    }
                    else if (fileExtension == ".pptx")
                    {
                        string fileName = tempFileName;
                        string isWriteGroup = "";
                        MsoTriState readOnly = MsoTriState.msoFalse;
                        string isWrite = CheckWriteOnlyUser(CSClass.Logininfo.userid, nameOfFile);
                        string fileId = GetFileId(nameOfFile);
                        List<string> groupId = GetGroupId(CSClass.Logininfo.userid);
                        //CheckWriteOnlyGroup("4", "Excel Schedule.xlsx");
                        for (int i = 0; i < groupId.Count; i++)
                        {
                            if (CheckWriteOnlyGroup(fileId, groupId[i]) == "True")
                            {
                                isWriteGroup = "True";
                            }
                        }
                        if (isWrite == "True" || isWriteGroup == "True")
                        {
                            readOnly = MsoTriState.msoFalse;
                        }
                        else
                        {
                            readOnly = MsoTriState.msoTrue;
                        }
                        object missing = System.Reflection.Missing.Value;
                        Microsoft.Office.Interop.PowerPoint.Application applicationPPT = new Microsoft.Office.Interop.PowerPoint.Application();
                        applicationPPT.Presentations.Open(fileName, readOnly, MsoTriState.msoTrue, MsoTriState.msoTrue);
                        // JUST GREAT MSOTRISTATE NOT WORKING
                    }
                    else
                    {
                        //File.WriteAllBytes(tempFileName, fileBytes);
                        //var process = Process.Start(tempFileName);
                        //process.Exited += new EventHandler(process_Exited);
                    }
                    //MessageBox.Show(tempFileName);
                    dblog.fileLog("Opened file '" + fileList.SelectedItem.ToString() + "'.", "FileActions", Logininfo.userid.ToString(), Logininfo.email.ToString(), fileID.ToString());
                    if (fileExtension == ".docx" || fileExtension == ".xlsx" || fileExtension == ".pptx")
                    {
                        await PutTaskDelay();
                        while (IsFileLock(tempFileName) == true)
                        {

                        }
                        UpdateFileToDb(tempFileName, nameOfFile);
                        //if (IsFileLock(tempFileName) == true)
                        //{
                        //    MessageBox.Show("open");
                        //}
                    }
                    //if (IsFileLock(tempFileName) == false)
                    //{
                    //    MessageBox.Show("close");
                    //}
                    releaseLock(nameOfFile);
                    //MessageBox.Show(nameOfFile);
                }
            }
            else
            {
                MessageBox.Show("File is in use! Please try again later");
            }
        }
        //using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
        //{
        //    string lockNo;
        //    con.Open();
        //    // Get File Lock
        //    String getFileLockQuery = "SELECT fileLock FROM fileInfo WHERE fileName = @getLock";
        //    MySqlCommand getLockcmd = new MySqlCommand(getFileLockQuery, con);
        //    getLockcmd.Parameters.AddWithValue("@getLock", fileList.SelectedItem.ToString());
        //    MySqlDataReader fileLockReader = getLockcmd.ExecuteReader();
        //    if (fileLockReader.Read())
        //    {
        //        lockNo = fileLockReader["fileLock"].ToString();
        //        if(lockNo == "1")
        //        {
        //            MessageBox.Show("File is in use! Please Wait to use the file!");
        //            fileLockReader.Close();
        //        }

        //        else if (lockNo == "0")
        //        {
        //            fileLockReader.Close();
        //            //String fileLockQuery = "UPDATE da_schema.fileInfo SET fileLock = '1' WHERE fileName = @lockNo";
        //            //MySqlCommand fileLockCmd = new MySqlCommand(fileLockQuery, con);
        //            //fileLockCmd.Parameters.AddWithValue("@lockNo", nameOfFile);
        //            //fileLockCmd.ExecuteNonQuery();


        //            byte[] fileBytes = new byte[] { 0x0 };
        //            //con.Open();
        //            String fileQuery = "SELECT * FROM fileInfo WHERE fileName = @nameParam";
        //            MySqlCommand getFilecmd = new MySqlCommand(fileQuery, con);
        //            getFilecmd.Parameters.AddWithValue("@nameParam", fileList.SelectedItem.ToString());
        //            MySqlDataReader reader = getFilecmd.ExecuteReader();
        //            if (reader.Read())
        //            {
        //                fileBytes = (byte[])reader["file"];
        //            }
        //            reader.Close();
        //            File.WriteAllBytes(this.tempFileName, fileBytes);
        //            if (this.fileExtension == ".txt")
        //            {
        //                doc.Show();
        //            }
        //System.Diagnostics.Process process = new System.Diagnostics.Process();
        //process.StartInfo.FileName = tempFileName;
        //process.Start();
        //var process = Process.Start(tempFileName);
        //process.Exited += (s, ev) => { process.Kill();
        //process.Close();
        //process.Exited += (s, ev) =>
        //{
        //    process.Kill();
        //    File.Delete(tempFileName);
        //    //String releaseLockQuery = "UPDATE da_schema.fileInfo SET fileLock = '0' WHERE fileName = @lockNo";
        //    //MySqlCommand releaseLockCmd = new MySqlCommand(releaseLockQuery, con);
        //    //releaseLockCmd.Parameters.AddWithValue("@lockNo", nameOfFile);
        //    //releaseLockCmd.ExecuteNonQuery();
        //    fileLockQuery = "UPDATE da_schema.fileInfo SET fileLock = '0' WHERE fileName = @lockNo";
        //    fileLockCmd = new MySqlCommand(fileLockQuery, con);
        //    fileLockCmd.Parameters.AddWithValue("@lockNo", nameOfFile);
        //    fileLockCmd.ExecuteNonQuery();
        //};
        //process.Exited += (s, ev) => process.Kill();
        //String releaseLockQuery = "UPDATE da_schema.fileInfo SET fileLock = '0' WHERE fileName = @lockNo";
        //MySqlCommand releaseLockCmd = new MySqlCommand(releaseLockQuery, con);
        //releaseLockCmd.Parameters.AddWithValue("@lockNo", nameOfFile);
        //releaseLockCmd.ExecuteNonQuery();
        //    }
        //}
        //        }

        //byte[] fileBytes = new byte[] { 0x0 };
        //using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
        //{
        //    con.Open();
        //    String fileQuery = "SELECT * FROM fileInfo WHERE fileName = @nameParam";
        //    MySqlCommand getFilecmd = new MySqlCommand(fileQuery, con);
        //    getFilecmd.Parameters.AddWithValue("@nameParam", fileList.SelectedItem.ToString());
        //    MySqlDataReader reader = getFilecmd.ExecuteReader();
        //    if (reader.Read())
        //    {
        //        fileBytes = (byte[])reader["file"];
        //    }
        //    reader.Close();
        //    File.WriteAllBytes(tempFileName, fileBytes);
        //    var process = Process.Start(tempFileName);
        //    process.Exited += (s, ev) => File.Delete(tempFileName);
        //}
        //}

        private void process_Exited(object s, EventArgs e)
        {
            File.Delete(tempFileName);
        }

        private void deleteFileButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete the selected file " + fileList.SelectedItem.ToString() + "? All content and permissions related to this file will be lost.", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
                {

                    con.Open();
                    string deletefileQuery = "DELETE FROM fileInfo WHERE fileName = @nameParam";
                    MySqlCommand deleteFilecmd = new MySqlCommand(deletefileQuery, con);
                    deleteFilecmd.Parameters.AddWithValue("@nameParam", fileList.SelectedItem.ToString());
                    deleteFilecmd.ExecuteNonQuery();

                    string deleteuserPermsQuery = "DELETE FROM userFilePermissions WHERE fileID = @idParam";
                    MySqlCommand deleteUserPermCmd = new MySqlCommand(deleteuserPermsQuery, con);
                    deleteUserPermCmd.Parameters.AddWithValue("idParam", fileID);
                    deleteUserPermCmd.ExecuteNonQuery();

                    string deletegroupPermsQuery = "DELETE FROM groupFilePermissions WHERE fileID = @idParam";
                    MySqlCommand deletegroupPermsCmd = new MySqlCommand(deletegroupPermsQuery, con);
                    deletegroupPermsCmd.Parameters.AddWithValue("idParam", fileID);
                    deletegroupPermsCmd.ExecuteNonQuery();

                    //Log Deletion
                    dblog.fileLog("Deleted file '" + fileList.SelectedItem.ToString() + "'.", "FileActions", Logininfo.userid.ToString(), Logininfo.email.ToString(), fileID.ToString());
                }
                FileManagementHub view = new FileManagementHub();
                view.Show();
                Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                //nothing
            }
        }

        private void manageGroupsButton_Click(object sender, EventArgs e)
        {
            FileManagement.ManageGroups view = new FileManagement.ManageGroups();
            view.Show();
            Hide();
        }

        private void editUserPermButton_Click(object sender, EventArgs e)
        {
            FileManagement.EditUserPermissions view = new FileManagement.EditUserPermissions(fileList.SelectedItem.ToString());
            view.Show();
            Hide();
        }

        private void editGroupPermButton_Click(object sender, EventArgs e)
        {
            FileManagement.EditGroupPermissions view = new FileManagement.EditGroupPermissions(fileList.SelectedItem.ToString());
            view.Show();
            Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Home view = new Home();
            view.Show();
            Hide();
        }

        private void permissionGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fileDoubleClick(object sender, MouseEventArgs e)
        {
            //int index = this.fileList.IndexFromPoint(e.Location);
            //if (index != System.Windows.Forms.ListBox.NoMatches)
            //{
                //For changing back to original file
                //Directory.CreateDirectory(Path.GetDirectoryName(fileName));
                //using (Stream file = File.Create(fileName))
                //{
                //file.Write(buffer, 0, buffer.Length);
                //}

                //Opening the file
                //Process process = new Process();
                //process.StartInfo.FileName = path;
                //process.Start();
                //using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
                //{
                //    byte[] buffer;
                //    con.Open();
                //    string curItem = fileList.SelectedItem.ToString();
                //    //Retrieve group info from DB
                //    String groupInfoquery = "SELECT * FROM fileInfo WHERE fileLock = @nameParam";
                //    MySqlCommand groupInfocmd = new MySqlCommand(groupInfoquery, con);
                //    groupInfocmd.Parameters.AddWithValue("@nameParam", curItem);
                //    MySqlDataReader reader = groupInfocmd.ExecuteReader();
                //    if (reader.Read())
                //    {
                //        buffer = (byte[])reader["file"];
                //        if (reader["fileLock"].ToString() == "1")
                //        {
                //            MessageBox.Show("File is in use!");
                //        }
                //        else
                //        {

                //            Directory.CreateDirectory(Path.GetDirectoryName(reader["fileName"].ToString()));
                //            using (Stream file = File.Create(reader["fileName"].ToString()))

                //            {
                //                file.Write(buffer, 0, buffer.Length);
                //            }
                //            var applicationWord = new Microsoft.Office.Interop.Word.Application();
                //            applicationWord.Visible = true;
                //            applicationWord.Documents.Open(file);
                //        }
                //    }
                //    reader.Close();
                //}

            //}
        }

        private void imgDownload(string tempFileName, string saveFileName)
        {
            string text = DataAsGuard.CSClass.Logininfo.username;
            string password = "Ilovethispic123";
            bmp = (Bitmap)Image.FromFile(tempFileName);
            text = Crypto.EncryptStringAES(text, password);
            bmp = SteganographyHelper.embedText(text, bmp);
            bmp.Save(saveFileName, ImageFormat.Png);
        }

        private void WriteMeta(string filePath, string originalFileName)
        {
            // Write properties to file
            var file = ShellFile.FromFilePath(filePath);

            // Read and Write:

            string[] oldAuthors = file.Properties.System.Author.Value;
            string oldTitle = file.Properties.System.Title.Value;

            file.Properties.System.Copyright.Value = "©COPYRIGHT DATAASGUARD";
            file.Properties.System.Company.Value = "DATAASGUARD";
            file.Properties.System.Title.Value = originalFileName;
            //file.Properties.System.Author.Value = new string[] { Owner of the file };
            file.Properties.System.Comment.Value = DataAsGuard.CSClass.Logininfo.username;

            // Alternate way to Write:
            ShellPropertyWriter propertyWriter = file.Properties.GetPropertyWriter();
            //propertyWriter.WriteProperty(SystemProperties.System.Author, new string[] { "Author" });
            //propertyWriter.WriteProperty(SystemProperties.System.Comment, new string[] { "Comment" });
            propertyWriter.Close();
        }

        private void videoMeta(string videoPath)
        {
            TagLib.File videoFile = TagLib.File.Create(videoPath);
            TagLib.Mpeg4.AppleTag customTag = (TagLib.Mpeg4.AppleTag)videoFile.GetTag(TagLib.TagTypes.Apple);
            customTag.SetDashBox("User", "Downloaded", DataAsGuard.CSClass.Logininfo.username);
            videoFile.Save();
            videoFile.Dispose();
            //string tokenValue = customTag.GetDashBox("User", "Downloaded");
            //MessageBox.Show(tokenValue);
        }

        private void pdfMeta(string readPath, string writePath, string orgFileName)
        {
            PdfReader reader = new PdfReader(readPath);
            iTextSharp.text.Rectangle size = reader.GetPageSizeWithRotation(1);
            iTextSharp.text.Document document = new iTextSharp.text.Document(size);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(writePath, FileMode.Create, FileAccess.Write));
            document.AddTitle(orgFileName);
            document.AddAuthor(DataAsGuard.CSClass.Logininfo.username);
            document.AddCreator("Owner of the file");
            document.Open();
            PdfContentByte cb = writer.DirectContent;
            for (int pageNumber = 1; pageNumber <= reader.NumberOfPages; pageNumber++)
            {
                document.NewPage();
                PdfImportedPage page = writer.GetImportedPage(reader, pageNumber);
                cb.AddTemplate(page, 0, 0);
            }
            document.Close();

            //PdfReader reader2 = new PdfReader(writePath);
            //string s = reader2.Info["Title"];
            //MessageBox.Show(s);
        }

        private void downloadFileButton_Click(object sender, EventArgs e)
        {
            string nameOfFile = fileList.SelectedItem.ToString();
            string fileExtension = Path.GetExtension(nameOfFile);
            string tempFileName = System.IO.Path.GetTempFileName() + "." + fileExtension;

            byte[] fileBytes = new byte[] { 0x0 };
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String fileQuery = "SELECT * FROM fileInfo WHERE fileName = @nameParam";
                MySqlCommand getFilecmd = new MySqlCommand(fileQuery, con);
                getFilecmd.Parameters.AddWithValue("@nameParam", fileList.SelectedItem.ToString());
                MySqlDataReader reader = getFilecmd.ExecuteReader();
                if (reader.Read())
                {
                    fileBytes = (byte[])reader["file"];
                }
                reader.Close();
                File.WriteAllBytes(tempFileName, fileBytes);
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents;Word Docx;PPTX;XLSX;Png;MP4;All |*.txt;*.docx;*pptx;*xlsx;*.png;*mp4;*.*", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        switch (fileExtension)
                        {
                            case ".txt":
                                string storeText= File.ReadAllText(tempFileName);
                                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                                {
                                    sw.WriteLineAsync(storeText);
                                    MessageBox.Show("File Saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                                    startInfo.FileName = "cmd.exe";
                                    //startInfo.Arguments = "/C echo 'SECRET MSG' > C:\\Users\\Solomon\\Documents\\something.txt:SOMETHING";
                                    //Write Hidden text to file
                                    startInfo.Arguments = "/C echo " + DataAsGuard.CSClass.Logininfo.username + " > " + sfd.FileName + ":DS1";
                                    process.StartInfo = startInfo;
                                    process.Start();
                                }
                                MessageBox.Show("File Downloaded!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case ".png":
                                imgDownload(tempFileName, sfd.FileName);
                                MessageBox.Show("File Downloaded!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case ".jpg":
                                imgDownload(tempFileName, sfd.FileName);
                                MessageBox.Show("File Downloaded!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case ".docx":
                                File.WriteAllBytes(sfd.FileName, fileBytes);
                                WriteMeta(sfd.FileName, nameOfFile);
                                MessageBox.Show("File Downloaded!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case ".pptx":
                                File.WriteAllBytes(sfd.FileName, fileBytes);
                                WriteMeta(sfd.FileName, nameOfFile);
                                MessageBox.Show("File Downloaded!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case ".xlsx":
                                File.WriteAllBytes(sfd.FileName, fileBytes);
                                WriteMeta(sfd.FileName, nameOfFile);
                                MessageBox.Show("File Downloaded!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case ".mp4":
                                File.WriteAllBytes(sfd.FileName, fileBytes);
                                videoMeta(sfd.FileName);
                                MessageBox.Show("File Downloaded!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case ".pdf":
                                pdfMeta(tempFileName, sfd.FileName, nameOfFile);
                                MessageBox.Show("File Downloaded!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            default:
                                throw new ArgumentOutOfRangeException(fileExtension);
                        }
                    }
                }
            }
        }

        private void transferOwnershipButton_Click(object sender, EventArgs e)
        {
            TransferOwnerUserList view = new TransferOwnerUserList(fileList.SelectedItem.ToString());
            view.Show();
            view.FormClosed += view_FormClosed;
        }

        private void view_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileManagementHub view = new FileManagementHub();
            view.Show();
            Hide();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Home view = new Home();
            view.Show();
            Hide();
        }
    }
}
