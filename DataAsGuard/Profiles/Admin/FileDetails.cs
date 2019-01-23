using DataAsGuard.CSClass;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAsGuard.Profiles.Admin
{
    public partial class FileDetails : Form
    {

        AesEncryption aes = new AesEncryption();
        DBLogger dblog = new DBLogger();
        ArrayList grouplist = new ArrayList();
        ArrayList individualUserlist = new ArrayList();

        public FileDetails()
        {
            InitializeComponent();
        }

        private void fileDetails_Shown(Object sender, EventArgs e)
        {
            userfilesRetrieval();
            retrieveLogs();
            chartInitialized();
            groupInfo();
            individualuserInfo();
        }

        //userfileDetails
        private void userfilesRetrieval()
        {

            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM fileInfo WHERE fileID=@fileID";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@fileID", AdminSession.fileID.ToString());
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        fileID.Text = reader.GetString(reader.GetOrdinal("fileID"));
                        filename.Text = reader.GetString(reader.GetOrdinal("fileName"));
                        fileOwnerid.Text = reader.GetString(reader.GetOrdinal("fileOwnerID"));
                        fileOwner.Text = reader.GetString(reader.GetOrdinal("fileOwner"));
                        dateCreated.Text = reader.GetString(reader.GetOrdinal("dateCreated"));
                        //description.Text = reader.GetString(reader.GetOrdinal("description"));
                        fileSize.Text = reader.GetString(reader.GetOrdinal("fileSize"));
                        fileLock.Text = reader.GetString(reader.GetOrdinal("fileLock"));
                        if (reader.IsDBNull(reader.GetOrdinal("description")))
                        {
                            description.Text = "NULL";
                        }
                        else
                        {
                            description.Text = reader.GetString(reader.GetOrdinal("description"));
                        }
                    }

                    if (reader != null)
                        reader.Close();
                }
            }
        }

        //retrievelogInfo
        private void retrieveLogs()
        {
            datalogGrid.AllowUserToAddRows = false;
            datalogGrid.AllowUserToDeleteRows = false;
            datalogGrid.ColumnCount = 7;
            datalogGrid.Columns[0].Name = "Logid";
            datalogGrid.Columns[1].Name = "Loginfo";
            datalogGrid.Columns[2].Name = "Logtype";
            datalogGrid.Columns[3].Name = "Logdatetime";
            datalogGrid.Columns[4].Name = "Userid";
            datalogGrid.Columns[5].Name = "Email";
            datalogGrid.Columns[6].Name = "FileID";

            //add rows from db
            userLogRetrieval();
        }

        //log retrieval need to modify for file changes
        //either recreate a new log version for files only or add it in the first field and if contains
        private void userLogRetrieval()
        {

            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();

                //need to modify for file changes
                //might consider putting another field for log or put inside loginfo and look through
                String query = "SELECT * FROM logInfo where fileID = @fileID";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@fileID", AdminSession.fileID);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ArrayList row = new ArrayList();
                        row.Add(reader.GetInt32(reader.GetOrdinal("logid")));
                        row.Add(reader.GetString(reader.GetOrdinal("loginfo")));
                        row.Add(reader.GetString(reader.GetOrdinal("logtype")));
                        row.Add(reader.GetString(reader.GetOrdinal("logdatetime")));
                        row.Add(reader.GetString(reader.GetOrdinal("userid")));
                        row.Add(reader.GetString(reader.GetOrdinal("email")));

                        if (reader.IsDBNull(reader.GetOrdinal("fileID"))){
                            row.Add("NULL");
                        }
                        else
                        {
                            row.Add(reader.GetString(reader.GetOrdinal("fileID")));
                        }
                        
                        datalogGrid.Rows.Add(row.ToArray());
                    }

                    if (reader != null)
                        reader.Close();
                }
            }
        }

        private void groupInfo()
        {
            //Load all groups from MySql
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM groupFilePermissions where fileID = @fileID";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@fileID", AdminSession.fileID);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        grouplist.Add(reader.GetString(reader.GetOrdinal("groupID")));
                    }

                    if (reader != null)
                        reader.Close();
                }

                String query2 = "SELECT * FROM groupInfo";
                MySqlCommand command2 = new MySqlCommand(query2, con);
                using (MySqlDataReader reader = command2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < grouplist.Count; i++)
                        {
                            if (grouplist[i].ToString() == reader.GetString(reader.GetOrdinal("groupID")))
                            {
                                groupList.Items.Add(reader.GetString(reader.GetOrdinal("groupName")));
                            }
                        }
                    }

                    if (reader != null)
                        reader.Close();
                }
            }

        }

        private void groupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupPermissionInformation.Clear();
            membersList.Items.Clear();
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                string curItem = groupList.SelectedItem.ToString();
                string groupid = null;
                //Retrieve group members from DB
                String getGroupMembersquery = "SELECT * FROM groupUsers WHERE groupName = @nameParam";
                MySqlCommand groupMemberscmd = new MySqlCommand(getGroupMembersquery, con);
                groupMemberscmd.Parameters.AddWithValue("@nameParam", curItem);
                MySqlDataReader reader2 = groupMemberscmd.ExecuteReader();
                while (reader2.Read())
                {
                    membersList.Items.Add(reader2["userFullName"].ToString());
                    groupid = reader2.GetString(reader2.GetOrdinal("groupID"));
                }
                reader2.Close();

                String groupInfoquery = "SELECT * FROM groupFilePermissions WHERE groupID = @groupid and fileid=@fileid";
                MySqlCommand groupInfocmd = new MySqlCommand(groupInfoquery, con);
                groupInfocmd.Parameters.AddWithValue("@groupid", groupid);
                groupInfocmd.Parameters.AddWithValue("@fileid", AdminSession.fileID);
                MySqlDataReader reader = groupInfocmd.ExecuteReader();
                while (reader.Read())
                {
                    groupPermissionInformation.AppendText("Readable: " + reader.GetString(reader.GetOrdinal("readPermission")));
                    groupPermissionInformation.AppendText(Environment.NewLine + "Editable: " + reader.GetString(reader.GetOrdinal("editPermission")));
                    groupPermissionInformation.AppendText(Environment.NewLine + "Downloadable: " + reader.GetString(reader.GetOrdinal("downloadPermission")));
                }

                con.Close();
            }
        }

        private void individualuserInfo()
        {
            //Load all groups from MySql
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM userFilePermissions where fileID = @fileID";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@fileID", AdminSession.fileID);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        individualUserlist.Add(reader.GetString(reader.GetOrdinal("userID")));
                    }

                    if (reader != null)
                        reader.Close();
                }

                String query2 = "SELECT * FROM Userinfo";
                MySqlCommand command2 = new MySqlCommand(query2, con);
                using (MySqlDataReader reader = command2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < individualUserlist.Count; i++)
                        {
                            if (individualUserlist[i].ToString() == reader.GetString(reader.GetOrdinal("userid")))
                            {
                                IndividualList.Items.Add(aes.Decryptstring(reader.GetString(reader.GetOrdinal("username")), reader.GetString(reader.GetOrdinal("userid"))));
                            }
                        }
                    }

                    if (reader != null)
                        reader.Close();
                }
            }

        }

        private void Individual_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userid = null;
            userPermissionInfo.Clear();
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                string curItem = IndividualList.SelectedItem.ToString();
                //find the particular userid of the selected username
                String getUsersquery = "SELECT * FROM Userinfo";
                MySqlCommand userMemberscmd = new MySqlCommand(getUsersquery, con);
                MySqlDataReader reader2 = userMemberscmd.ExecuteReader();
                while (reader2.Read())
                {
                    if(aes.Decryptstring(reader2.GetString(reader2.GetOrdinal("username")), reader2.GetString(reader2.GetOrdinal("userid"))) == curItem){ 
                        userid = reader2.GetString(reader2.GetOrdinal("userid"));
                        break;
                    }
                }
                reader2.Close();

                //retrieve the permission relating to the particular user.
                String query = "SELECT * FROM userFilePermissions where fileID = @fileID and userID = @userid";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@fileID", AdminSession.fileID);
                command.Parameters.AddWithValue("@userid", userid);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userPermissionInfo.AppendText("Readable: " + reader.GetString(reader.GetOrdinal("readPermission")));
                        userPermissionInfo.AppendText(Environment.NewLine + "Editable: " + reader.GetString(reader.GetOrdinal("editPermission")));
                        userPermissionInfo.AppendText(Environment.NewLine + "Downloadable: " + reader.GetString(reader.GetOrdinal("downloadPermission")));
                    }

                    if (reader != null)
                        reader.Close();
                }

                con.Close();
                
            }
        }

        private void chartInitialized()
        {
            ArrayList data = new ArrayList();

            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM logInfo where logtype = @fileActions AND fileID=@fileID";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@fileActions", "FileActions");
                command.Parameters.AddWithValue("@fileID", AdminSession.fileID);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        if (reader.GetString(reader.GetOrdinal("logInfo")).Contains("Opened"))
                        {
                            if (reader.IsDBNull(reader.GetOrdinal("fileID")))
                            {

                            }
                            else
                            {
                                data.Add(DateTime.ParseExact(reader.GetString(reader.GetOrdinal("logDateTime")), "dd/MM/yyyy HH:mm:ss", null));
                            }
                        }
                    }

                    if (reader != null)
                        reader.Close();
                }
            }
            int count = 0;
            ArrayList xvalue = new ArrayList();
            ArrayList yvalue = new ArrayList();
            DateTime olddate = new DateTime();
            string checkoldDate = null;
            for (int i = 0; i < data.Count; i++)
            {

                DateTime date = DateTime.Parse(data[i].ToString());
                string checkdate = date.ToString("dd/MM/yyyy");

                if (checkoldDate == null)
                {
                    olddate = DateTime.Parse(data[i].ToString());
                    checkoldDate = olddate.ToString("dd/MM/yyyy");
                }

                if (checkdate == checkoldDate)
                {
                    olddate = DateTime.Parse(data[i].ToString());
                    checkoldDate = olddate.ToString("dd/MM/yyyy");
                    count++;
                    if (i == data.Count - 1)
                    {
                        xvalue.Add(checkoldDate);
                        yvalue.Add(count);
                    }
                }
                else
                {
                    xvalue.Add(checkoldDate);
                    yvalue.Add(count);
                    olddate = DateTime.Parse(data[i].ToString());
                    checkoldDate = olddate.ToString("dd/MM/yyyy");
                    count = 1;
                    if (i == data.Count - 1)
                    {
                        xvalue.Add(checkoldDate);
                        yvalue.Add(count);
                    }
                }
            }


            //chart1.ChartAreas.AxisX.Interval = 1;
            for (int u = 0; u < xvalue.Count; u++)
            {
                chart1.Series["Series1"].Points.AddXY(xvalue[u], yvalue[u]);
            }
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 90;
            chart1.ChartAreas[0].AxisX.Interval = 1;
        }

        private void Lockbtn_Click(object sender, EventArgs e)
        {
            //UPDATE Lock TO DATABASE
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                string queryStr = "";
                queryStr = "UPDATE fileInfo set fileLock=@fileLock where fileID = @fileID";

                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, con);
                if (fileLock.Text == "2")
                {
                    //lock to unlock
                    cmd.Parameters.AddWithValue("@fileLock", "0");
                    dblog.fileLog("File status changed(Lock -> Unlock) by Admin", "Files", Logininfo.userid, Logininfo.email, AdminSession.fileID);
                }
                else if (fileLock.Text == "0")
                {
                    //unlock to lock
                    cmd.Parameters.AddWithValue("@fileLock", "2");
                    dblog.fileLog("file status changed(Unlock -> Lock) by Admin", "Files", Logininfo.userid, Logininfo.email, AdminSession.fileID);
                }
                cmd.Parameters.AddWithValue("@fileID", AdminSession.fileID);
                cmd.ExecuteReader();
                con.Close();
            }
            userfilesRetrieval();
        }

        private void AddUsers_Click(object sender, EventArgs e)
        {
            //Users.ConfirmationDetails confirmationDetails = new Users.ConfirmationDetails();
            //confirmationDetails.Show();

            Registration Registration = new Registration();
            Registration.Show();
            Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Logininfo.userid = null;
            Logininfo.email = null;
            Logininfo.username = null;
            Login login = new Login();
            login.Show();
            Hide();
        }

        private void AdminHome_Click(object sender, EventArgs e)
        {
            AdminProfile Profiles = new AdminProfile();
            Profiles.Show();
            Hide();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            AdminProfileSettings settings = new AdminProfileSettings();
            settings.Show();
            Hide();
        }

        
    }
    
}
