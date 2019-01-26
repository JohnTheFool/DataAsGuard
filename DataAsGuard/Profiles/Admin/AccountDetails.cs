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
    public partial class AccountDetails : Form
    {
        AesEncryption aes = new AesEncryption();
        DBLogger dblog = new DBLogger();
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();
        ArrayList grouplist = new ArrayList();
        ArrayList filelist = new ArrayList();
        ArrayList permissionlist = new ArrayList();

        public AccountDetails()
        {
            InitializeComponent();
        }

        private void accountDetails_Shown(Object sender, EventArgs e)
        {
            userdataRetrieval();
            retrieveLogs();
            groupInfo();
            chartInitialized();
            chartInitialized2();
            retrieveFileAccess();
        }

        private void userdataRetrieval()
        {
            
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM Userinfo WHERE userid=@userid";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@userid", AdminSession.userid.ToString());
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userid.Text = reader.GetString(reader.GetOrdinal("userid"));
                        Username.Text = aes.Decryptstring(reader.GetString(reader.GetOrdinal("username")), AdminSession.userid.ToString());
                        FName.Text = reader.GetString(reader.GetOrdinal("firstname")) + " " + reader.GetString(reader.GetOrdinal("lastname"));
                        Contact.Text = "****" + aes.Decryptstring(reader.GetString(reader.GetOrdinal("contact")), AdminSession.userid.ToString()).Substring(4, 4);
                        Email.Text = aes.Decryptstring(reader.GetString(reader.GetOrdinal("email")), AdminSession.userid.ToString());
                        DOB.Text = reader.GetString(reader.GetOrdinal("dob"));
                        vflag.Text = reader.GetString(reader.GetOrdinal("verificationflag"));
                        if (reader.IsDBNull(reader.GetOrdinal("statusDate")))
                        {
                            statusDate.Text = "NULL";
                        }
                        else
                        {
                            statusDate.Text = reader.GetString(reader.GetOrdinal("statusDate"));
                        }
                    }

                    if (reader != null)
                        reader.Close();
                }
            }
        }

        private void retrieveLogs()
        {
            datalogGrid.AllowUserToAddRows = false;
            datalogGrid.AllowUserToDeleteRows = false;
            datalogGrid.ColumnCount = 6;
            datalogGrid.Columns[0].Name = "logid";
            datalogGrid.Columns[1].Name = "loginfo";
            datalogGrid.Columns[2].Name = "logtype";
            datalogGrid.Columns[3].Name = "logdatetime";
            datalogGrid.Columns[4].Name = "userid";
            datalogGrid.Columns[5].Name = "email";

            //add rows from db
            userLogRetrieval();
        }

        private void userLogRetrieval()
        {

            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM logInfo where userid = @userid";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@userid", AdminSession.userid);
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
                        datalogGrid.Rows.Add(row.ToArray());
                    }

                    if (reader != null)
                        reader.Close();
                }
            }
        }

        //for login frequency
        private void chartInitialized()
        {
            ArrayList data = new ArrayList();

            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM logInfo where logtype = @logtype AND userid=@userid";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@logtype", "LogonSuccess");
                command.Parameters.AddWithValue("@userid", AdminSession.userid);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        data.Add(DateTime.ParseExact(reader.GetString(reader.GetOrdinal("logDateTime")), "dd/MM/yyyy HH:mm:ss", null));
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
                //compare dates if the same date collate under count and place into chart
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

        //for fail login 
        private void chartInitialized2()
        {
            ArrayList data = new ArrayList();

            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM logInfo where logtype = @logtype AND userid=@userid";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@logtype", "LogonFailure");
                command.Parameters.AddWithValue("@userid", AdminSession.userid);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        data.Add(DateTime.ParseExact(reader.GetString(reader.GetOrdinal("logDateTime")), "dd/MM/yyyy HH:mm:ss", null));
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
                //compare dates if the same date collate under count and place into chart
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
                chart2.Series["Series1"].Points.AddXY(xvalue[u], yvalue[u]);
            }
            chart2.ChartAreas[0].AxisX.LabelStyle.Angle = 90;
            chart2.ChartAreas[0].AxisX.Interval = 1;
        }

        private void groupInfo()
        {
            //Load all groups from MySql
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM groupUsers where userid = @userid";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@userid", AdminSession.userid);
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

        private void retrieveFileAccess()
        {
            filegrid.AllowUserToAddRows = false;
            filegrid.AllowUserToDeleteRows = false;
            filegrid.ColumnCount = 7;
            filegrid.Columns[0].Name = "fileid";
            filegrid.Columns[1].Name = "filename";
            filegrid.Columns[2].Name = "fileOwnerID";
            filegrid.Columns[3].Name = "fileOwner";
            filegrid.Columns[4].Name = "readPermission";
            filegrid.Columns[5].Name = "editPermission";
            filegrid.Columns[6].Name = "downloadPermission";

            //add rows from db
            userfileAccessibleRetrieval();
        }

        private void userfileAccessibleRetrieval()
        {

            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM groupFilePermissions";
                MySqlCommand command = new MySqlCommand(query, con);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < grouplist.Count; i++)
                        {
                            if (grouplist[i].ToString() == reader.GetString(reader.GetOrdinal("groupID")))
                            {
                                filelist.Add(reader.GetString(reader.GetOrdinal("fileID")));
                                permissionlist.Add(reader.GetString(reader.GetOrdinal("readPermission")));
                                permissionlist.Add(reader.GetString(reader.GetOrdinal("editPermission")));
                                permissionlist.Add(reader.GetString(reader.GetOrdinal("downloadPermission")));
                            }
                        }
                    }

                    if (reader != null)
                        reader.Close();
                }

                String query1 = "SELECT * FROM userFilePermissions where userid = @userid";
                MySqlCommand command1 = new MySqlCommand(query1, con);
                command1.Parameters.AddWithValue("@userid", AdminSession.userid);
                using (MySqlDataReader reader = command1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bool contains = false;
                        for (int i = 0; i < filelist.Count; i++)
                        {
                            if (filelist[i].ToString() == reader.GetString(reader.GetOrdinal("fileid")))
                            {
                                contains = true;
                            }
                            
                            if(contains == false && i == filelist.Count - 1)
                            {
                                filelist.Add(reader.GetString(reader.GetOrdinal("fileID")));
                                permissionlist.Add(reader.GetString(reader.GetOrdinal("readPermission")));
                                permissionlist.Add(reader.GetString(reader.GetOrdinal("editPermission")));
                                permissionlist.Add(reader.GetString(reader.GetOrdinal("downloadPermission")));
                            }
                        }
                    }

                    if (reader != null)
                        reader.Close();
                }

                //String query2 = "SELECT * FROM fileInfo where fileOwnerID = @userid";
                //MySqlCommand command2 = new MySqlCommand(query2, con);
                //command2.Parameters.AddWithValue("@userid", AdminSession.userid);
                //using (MySqlDataReader reader = command2.ExecuteReader())
                //{
                //    while (reader.Read())
                //    {
                //        if (filelist.Count == 0)
                //        {
                //            filelist.Add(reader.GetString(reader.GetOrdinal("fileID")));
                //            permissionlist.Add("True");
                //            permissionlist.Add("True");
                //            permissionlist.Add("True");
                //        }
                //        else
                //        {
                //            for (int i = 0; i < filelist.Count; i++)
                //            {

                //                bool contains = false;
                //                if (filelist[i].ToString() == reader.GetString(reader.GetOrdinal("fileid")))
                //                {
                //                    contains = true;
                //                }

                //                if (contains == false && i == filelist.Count - 1)
                //                {
                //                    filelist.Add(reader.GetString(reader.GetOrdinal("fileID")));
                //                    permissionlist.Add("True");
                //                    permissionlist.Add("True");
                //                    permissionlist.Add("True");
                //                }
                //            }
                //        }
                //    }

                //    if (reader != null)
                //        reader.Close();
                //}

                String query3 = "SELECT * FROM fileInfo";
                MySqlCommand command3 = new MySqlCommand(query3, con);
                using (MySqlDataReader reader = command3.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < filelist.Count; i++)
                        {
                            if (filelist[i].ToString() == reader.GetString(reader.GetOrdinal("fileID")))
                            {
                                ArrayList row = new ArrayList();
                                row.Add(reader.GetInt32(reader.GetOrdinal("fileid")));
                                row.Add(reader.GetString(reader.GetOrdinal("filename")));
                                row.Add(reader.GetString(reader.GetOrdinal("fileOwnerID")));
                                row.Add(reader.GetString(reader.GetOrdinal("fileOwner")));
                                row.Add(permissionlist[0].ToString());
                                row.Add(permissionlist[1].ToString());
                                row.Add(permissionlist[2].ToString());
                                permissionlist.RemoveRange(0, 3);
                                filegrid.Rows.Add(row.ToArray());
                            }
                        }
                    }

                    if (reader != null)
                        reader.Close();
                }
            }
        }

        private void Lockbtn_Click(object sender, EventArgs e)
        {
            //UPDATE PASSWORD TO DATABASE
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                string queryStr = "";
                queryStr = "UPDATE Userinfo set verificationflag=@vflag, statusDate=@statusDate where userid = @userid";

                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, con);
                if (vflag.Text == "L")
                {
                    //lock to unlock
                    cmd.Parameters.AddWithValue("@vflag", "T");
                    cmd.Parameters.AddWithValue("@statusDate", "NULL");
                    dblog.Log("Account status changed(L -> T) by Admin", "Accounts", Logininfo.userid, Logininfo.email);
                }
                else if (vflag.Text == "T")
                {
                    //unlock to lock
                    cmd.Parameters.AddWithValue("@vflag", "L");
                    cmd.Parameters.AddWithValue("@statusDate", DateTime.Now.ToString("dd'/'MM'/'yyyy HH: mm:ss"));
                    dblog.Log("Account status changed(T -> L) by Admin", "Accounts", Logininfo.userid, Logininfo.email);
                }
                cmd.Parameters.AddWithValue("@userid", AdminSession.userid);
                cmd.ExecuteReader();
                con.Close();
            }
            
            userdataRetrieval();
            
        }

        //might change to archive
        private void archive_Click(object sender, EventArgs e)
        {
            bool containgroup = false;
            bool containfile = false;
            DateTime prevLockDate = DateTime.ParseExact(statusDate.Text, "dd'/'MM'/'yyyy HH:mm:ss", null);
            if(vflag.Text == "A")
            {
                MessageBox.Show("User had been Archived.");
            }
            else if (statusDate.Text == null || statusDate.Text == "" || statusDate.Text == "NULL")
            {
                MessageBox.Show("Account need to be lock for more than 7 days before able to be deleted");
            }
            else
            {
                //check if the previous lock date has already pass 7 days
                if (prevLockDate >= DateTime.Now.AddDays(-7) && vflag.Text != "L")
                {
                    MessageBox.Show("Account need to be lock for more than 7 days before able to be deleted");
                }
                else
                {
                    //check existing group Ownership
                    using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
                    {
                        con.Open();
                        String query = "SELECT * FROM groupInfo where groupCreatorID = @groupcreatorID";
                        MySqlCommand command = new MySqlCommand(query, con);
                        command.Parameters.AddWithValue("@groupcreatorID", AdminSession.userid);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader.GetString(reader.GetOrdinal("groupCreatorID")) != null)
                                {
                                    //
                                    containgroup = true;
                                }
                            }

                            if (reader != null)
                                reader.Close();
                        }
                    }
                    //check existing file Ownership
                    using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
                    {
                        con.Open();
                        String query = "SELECT * FROM fileInfo where fileOwnerID = @fileOwnerID";
                        MySqlCommand command = new MySqlCommand(query, con);
                        command.Parameters.AddWithValue("@fileOwnerID", AdminSession.userid);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader.GetString(reader.GetOrdinal("fileOwnerID")) != null)
                                {
                                    //contain currently Own a file
                                    containfile = true;
                                }
                            }

                            if (reader != null)
                                reader.Close();
                        }
                    }
                    //if they are both false run archive
                    if (containgroup == false && containfile == false)
                    {
                        DialogResult dialogResult = MessageBox.Show("Archive the account? You will not be able to unlock it.", "Are you sure?", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
                            {
                                con.Open();
                                //archive userInfo
                                string archiveaccountQuery = "UPDATE Userinfo set verificationflag=@vflag, statusDate=@statusDate where userid = @userid";
                                MySqlCommand archiveaccount = new MySqlCommand(archiveaccountQuery, con);
                                archiveaccount.Parameters.AddWithValue("@vflag", "A");
                                archiveaccount.Parameters.AddWithValue("@statusDate", DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm:ss"));
                                archiveaccount.Parameters.AddWithValue("@userid", AdminSession.userid);
                                archiveaccount.ExecuteNonQuery();
                                //may add deletion for other info relating to the user
                                dblog.Log("Account status changed(L -> A) by Admin", "Accounts", Logininfo.userid, Logininfo.email);
                                dblog.Log("User is Archived:" + AdminSession.userid, "Accounts", Logininfo.userid, Logininfo.email);

                                string deleteGroupUserQuery = "Delete FROM groupUsers where userID = @userid";
                                MySqlCommand deleteGroupUser = new MySqlCommand(deleteGroupUserQuery, con);
                                deleteGroupUser.Parameters.AddWithValue("@userid", AdminSession.userid);
                                deleteGroupUser.ExecuteNonQuery();

                                string deletefileUserQuery = "Delete FROM userFilePermissions where userID = @userid";
                                MySqlCommand deletefileUserPermission = new MySqlCommand(deletefileUserQuery, con);
                                deletefileUserPermission.Parameters.AddWithValue("@userid", AdminSession.userid);
                                deletefileUserPermission.ExecuteNonQuery();

                                MessageBox.Show("User have been archived.");
                                AccountDetails accountdetails = new AccountDetails();
                                accountdetails.Show();
                                Hide();
                            }
                        }
                    }
                    else
                    {
                        if(containgroup && containfile)
                        {
                            MessageBox.Show("User contains ownership of both files and group. Please request to change ownership before archiving");
                        }
                        else if (containgroup)
                        {
                            MessageBox.Show("User contains ownership of group. Please request to change ownership of group before archiving");
                        }
                        else if (containfile)
                        {
                            MessageBox.Show("User contains ownership of files. Please request to change ownership of file before archiving");
                        }
                    }
                }
            }
        }


        private void AddUsers_Click(object sender, EventArgs e)
        {

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
