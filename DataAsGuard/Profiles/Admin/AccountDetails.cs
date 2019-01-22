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
            datalogGrid.ColumnCount = 7;
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
                        for (int i = 0; i < filelist.Count; i++)
                        {
                            bool contains = false;
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

                String query3 = "SELECT * FROM fileInfo where fileOwnerID = @userid";
                MySqlCommand command3 = new MySqlCommand(query3, con);
                command3.Parameters.AddWithValue("@userid", AdminSession.userid);
                using (MySqlDataReader reader = command3.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < filelist.Count; i++)
                        {
                            bool contains = false;
                            if (filelist[i].ToString() == reader.GetString(reader.GetOrdinal("fileid")))
                            {
                                contains = true;
                            }

                            if (contains == false && i == filelist.Count - 1)
                            {
                                filelist.Add(reader.GetString(reader.GetOrdinal("fileID")));
                                permissionlist.Add("True");
                                permissionlist.Add("True");
                                permissionlist.Add("True");
                            }
                        }
                    }

                    if (reader != null)
                        reader.Close();
                }

                String query2 = "SELECT * FROM fileInfo";
                MySqlCommand command2 = new MySqlCommand(query2, con);
                using (MySqlDataReader reader = command2.ExecuteReader())
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
                    cmd.Parameters.AddWithValue("@statusDate", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    dblog.Log("Account status changed(T -> L) by Admin", "Accounts", Logininfo.userid, Logininfo.email);
                }
                cmd.Parameters.AddWithValue("@userid", AdminSession.userid);
                cmd.ExecuteReader();
                con.Close();
            }
            
            userdataRetrieval();
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DateTime prevLockDate = DateTime.ParseExact(statusDate.Text, "dd/MM/yyyy HH:mm:ss", null);
            if (statusDate.Text == null || statusDate.Text == "" || statusDate.Text == "NULL")
            {
                MessageBox.Show("Account need to be lock for more than 7 days before able to be deleted");
            }
            else
            {
                //check if the previous lock date has already pass 7 days
                if (prevLockDate >= DateTime.Now.AddDays(-7))
                {
                    MessageBox.Show("Account need to be lock for more than 7 days before able to be deleted");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Delete the account?", "Are you sure?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
                        {
                            con.Open();
                            //delete userInfo
                            string deleteaccountQuery = "DELETE FROM Userinfo WHERE userid = @userid";
                            MySqlCommand deleteaccount = new MySqlCommand(deleteaccountQuery, con);
                            deleteaccount.Parameters.AddWithValue("@userid", AdminSession.userid);
                            deleteaccount.ExecuteNonQuery();
                            //may add deletion for other info relating to the user
                        }
                    }
                }
            }
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
