using DataAsGuard.CSClass;
using DataAsGuard.Viewer;
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
    public partial class AdminProfile : Form
    {
        AesEncryption aes = new AesEncryption();
        DBLogger dblog = new DBLogger();

        public AdminProfile()
        {
            InitializeComponent();
        }

        private void Adminprofile_Load(object sender, EventArgs e)
        {
            retrieveAccounts();
            retrieveLogs();
            retrieveFiles();
            timer1.Start();
        }

        //timeout
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Logininfo.GetIdleTime() >= 10000 && Logininfo.GetIdleTime() < 10100)
            {   //30 secs, Time to wait before locking

                Logininfo.userid = null;
                Logininfo.email = null;
                Logininfo.username = null;
                FormCollection fc = Application.OpenForms;

                foreach (Form frm in fc)
                {
                    frm.Hide();
                }
                Login login = new Login();
                login.Show();
                Hide();

                MessageBox.Show("Due to idling, you have been log out.");
                timer1.Stop();
            }
        }

        //accounts tab
        private void retrieveAccounts()
        {
            dataAccountGrid.AllowUserToAddRows = false;
            dataAccountGrid.AllowUserToDeleteRows = false;
            dataAccountGrid.ColumnCount = 6;
            dataAccountGrid.Columns[0].Name = "Userid";
            dataAccountGrid.Columns[1].Name = "Username";
            dataAccountGrid.Columns[2].Name = "Email";
            dataAccountGrid.Columns[3].Name = "FullName";
            dataAccountGrid.Columns[4].Name = "Contact";
            dataAccountGrid.Columns[5].Name = "Vflag";

            //add rows from db
            userdataRetrieval();

            ////ADD BUTTON COLUMN
            DataGridViewButtonColumn FullDetailsbtn = new DataGridViewButtonColumn();
            FullDetailsbtn.HeaderText = "Full Details";
            FullDetailsbtn.Name = "fDetails";
            FullDetailsbtn.Text = "Full Details";
            FullDetailsbtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            FullDetailsbtn.UseColumnTextForButtonValue = true;
            dataAccountGrid.Columns.Add(FullDetailsbtn);

            ////ADD BUTTON COLUMN
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Unlock/Lock Btn";
            btn.Name = "UnlockLockbtn";
            btn.Text = "Unlock/Lock btn";
            btn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            btn.UseColumnTextForButtonValue = true;
            dataAccountGrid.Columns.Add(btn);

        }

        //account with filter
        private void retrieveAccounts2(string listvalue, ArrayList searchvalue)
        {
            dataAccountGrid.AllowUserToAddRows = false;
            dataAccountGrid.AllowUserToDeleteRows = false;
            dataAccountGrid.ColumnCount = 7;
            dataAccountGrid.Columns[0].Name = "Userid";
            dataAccountGrid.Columns[1].Name = "Username";
            dataAccountGrid.Columns[2].Name = "Email";
            dataAccountGrid.Columns[3].Name = "FullName";
            dataAccountGrid.Columns[4].Name = "Contact";
            dataAccountGrid.Columns[5].Name = "Vflag";

            //add rows from db
            userdataRetrieval2(listvalue, searchvalue);

            ////ADD BUTTON COLUMN
            DataGridViewButtonColumn FullDetailsbtn = new DataGridViewButtonColumn();
            FullDetailsbtn.HeaderText = "Full Details";
            FullDetailsbtn.Name = "fDetails";
            FullDetailsbtn.Text = "Full Details";
            FullDetailsbtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            FullDetailsbtn.UseColumnTextForButtonValue = true;
            dataAccountGrid.Columns.Add(FullDetailsbtn);

            ////ADD BUTTON COLUMN
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Unlock/Lock Btn";
            btn.Name = "UnlockLockbtn";
            btn.Text = "Unlock/Lock btn";
            btn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            btn.UseColumnTextForButtonValue = true;
            dataAccountGrid.Columns.Add(btn);

        }

        //accountgrid buttons
        private void dataAccountGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            //check if the column is a button column and check if the column is where the button is when click 
            //column 7 is Details button link to a more comprehensive information about the user
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataAccountGrid.Rows[e.RowIndex];
                //TODO - Button Clicked - Execute Code Here
                //MessageBox.Show(row.Cells[0].Value.ToString());

                string userid = row.Cells[0].Value.ToString();

                //mainly for admin to know which account to properly check on to get a clearer information
                AdminSession.userid = userid;
                AccountDetails accountdetails = new AccountDetails();
                accountdetails.Show();
                Hide();
            }

            //check if the column is a button column and check if the column is where the button is when click 
            //column 8 is unlock and lock button
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataAccountGrid.Rows[e.RowIndex];
                //TODO - Button Clicked - Execute Code Here
                //MessageBox.Show(row.Cells[0].Value.ToString());

                string userid = row.Cells[0].Value.ToString();
                if (userid == "1")
                {
                    //admin is not application to status changes mainly for testting purpose
                    //string vflag = row.Cells[6].Value.ToString();
                    //if (vflag == "L")
                    //{
                    //    updateAccountstatus(userid, vflag);
                    //    MessageBox.Show("Account status of user have been updated!");
                    //    dataAccountGrid.Rows.Clear();
                    //    dataAccountGrid.Refresh();
                    //    retrieveAccounts();
                    //}
                    //else if (vflag == "F")
                    //{
                    //    MessageBox.Show(row.Cells[1].Value.ToString() + "user have not verify");
                    //}
                    //else if (vflag == "T")
                    //{
                    //    updateAccountstatus(userid, vflag);
                    //    MessageBox.Show("Account status of user have been updated!");
                    //    dataAccountGrid.Rows.Clear();
                    //    dataAccountGrid.Refresh();
                    //    retrieveAccounts();
                    //}
                }
                else
                {
                    string vflag = row.Cells[5].Value.ToString();
                    if (vflag == "L")
                    {
                        updateAccountstatus(userid, vflag);
                        MessageBox.Show("Account status of user have been updated!");
                        dataAccountGrid.Rows.Clear();
                        dataAccountGrid.Refresh();
                        retrieveAccounts();
                        dblog.Log("Account status changed(L -> T) by Admin", "Accounts", Logininfo.userid, Logininfo.email);
                    }
                    else if (vflag == "F")
                    {
                        MessageBox.Show(row.Cells[1].Value.ToString() + "user have not verify");
                    }
                    else if (vflag == "T")
                    {
                        updateAccountstatus(userid, vflag);
                        MessageBox.Show("Account status of user have been updated!");
                        dataAccountGrid.Rows.Clear();
                        dataAccountGrid.Refresh();
                        retrieveAccounts();
                        dblog.Log("Account status changed(T -> L) by Admin", "Accounts", Logininfo.userid, Logininfo.email);
                    }
                }
            }

        }

        //account
        private void updateAccountstatus(string userid, string vflag)
        {
            //UPDATE PASSWORD TO DATABASE
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                string queryStr = "";
                queryStr = "UPDATE Userinfo set verificationflag=@vflag, statusDate=@statusDate where userid = @userid";

                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, con);
                if (vflag == "L")
                {
                    //lock to unlock
                    cmd.Parameters.AddWithValue("@vflag", "T");
                    cmd.Parameters.AddWithValue("@statusDate", "NULL");
                }
                else if (vflag == "T")
                {
                    //unlock to lock
                    cmd.Parameters.AddWithValue("@vflag", "L");
                    cmd.Parameters.AddWithValue("@statusDate", DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm:ss"));
                }
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.ExecuteReader();
                con.Close();
            }
        }

        //retrieve account
        private void userdataRetrieval()
        {
            AesEncryption aes = new AesEncryption();
            int count = 0;
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM Userinfo";
                MySqlCommand command = new MySqlCommand(query, con);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ArrayList row = new ArrayList();
                        row.Add(reader.GetInt32(reader.GetOrdinal("userid")));
                        row.Add(aes.Decryptstring(reader.GetString(reader.GetOrdinal("username")), reader.GetString(reader.GetOrdinal("userid"))));
                        row.Add(aes.Decryptstring(reader.GetString(reader.GetOrdinal("email")), reader.GetString(reader.GetOrdinal("userid"))));
                        row.Add(reader.GetString(reader.GetOrdinal("firstname")) + " " + reader.GetString(reader.GetOrdinal("lastname")));
                        row.Add(aes.Decryptstring(reader.GetString(reader.GetOrdinal("contact")), reader.GetString(reader.GetOrdinal("userid"))));
                        row.Add(reader.GetString(reader.GetOrdinal("verificationflag")));
                        dataAccountGrid.Rows.Add(row.ToArray());
                        count++;
                    }
                    noOfAccounts.Text = count.ToString();
                    if (reader != null)
                        reader.Close();
                }
            }
        }

        //retrieve account based on  filter
        private void userdataRetrieval2(string listvalue, ArrayList searchfield)
        {
            AesEncryption aes = new AesEncryption();

            for (int i = 0; i < searchfield.Count; i++)
            {
                using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
                {
                    con.Open();
                    String query = "SELECT * FROM Userinfo where userid = @searchfield";
                    MySqlCommand command = new MySqlCommand(query, con);
                    command.Parameters.AddWithValue("@searchfield", searchfield[i].ToString());
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ArrayList row = new ArrayList();
                            row.Add(reader.GetInt32(reader.GetOrdinal("userid")));
                            row.Add(aes.Decryptstring(reader.GetString(reader.GetOrdinal("username")), reader.GetString(reader.GetOrdinal("userid"))));
                            row.Add(aes.Decryptstring(reader.GetString(reader.GetOrdinal("email")), reader.GetString(reader.GetOrdinal("userid"))));
                            row.Add(reader.GetString(reader.GetOrdinal("firstname")) + " " + reader.GetString(reader.GetOrdinal("lastname")));
                            row.Add(aes.Decryptstring(reader.GetString(reader.GetOrdinal("contact")), reader.GetString(reader.GetOrdinal("userid"))));
                            row.Add(reader.GetString(reader.GetOrdinal("verificationflag")));
                            dataAccountGrid.Rows.Add(row.ToArray());
                        }

                        if (reader != null)
                            reader.Close();
                    }
                }
            }
        }

        //account fields filter
        private void accountFilter_TextChanged(object sender, EventArgs e)
        {
            string accountlistvalue = accountList.Text.ToString();
            string searchfield = accountFilter.Text;
            ArrayList userid = new ArrayList();
            if (dataAccountGrid.RowCount == 0)
            {
                retrieveAccounts();
            }
            for (int i = 0; i < dataAccountGrid.RowCount; i++)
            {
                if (accountlistvalue == "Username")
                {
                    if (dataAccountGrid.Rows[i].Cells[1].Value.ToString().Contains(searchfield))
                    {
                        userid.Add(dataAccountGrid.Rows[i].Cells[0].Value.ToString());
                    }
                }
                else if (accountlistvalue == "Email")
                {
                    if (dataAccountGrid.Rows[i].Cells[2].Value.ToString().Contains(searchfield))
                    {
                        userid.Add(dataAccountGrid.Rows[i].Cells[0].Value.ToString());
                    }
                }
                else if (accountlistvalue == "FullName")
                {
                    if (dataAccountGrid.Rows[i].Cells[3].Value.ToString().Contains(searchfield))
                    {
                        userid.Add(dataAccountGrid.Rows[i].Cells[0].Value.ToString());
                    }
                }
                else if (accountlistvalue == "Contact")
                {
                    if (dataAccountGrid.Rows[i].Cells[5].Value.ToString().Contains(searchfield))
                    {
                        userid.Add(dataAccountGrid.Rows[i].Cells[0].Value.ToString());
                    }
                }
            }

            dataAccountGrid.Rows.Clear();
            dataAccountGrid.Refresh();
            retrieveAccounts2(accountlistvalue, userid);
        }


        //FILES!!!
        //Files grid retrival
        private void retrieveFiles()
        {
            dataFilesGrid.AllowUserToAddRows = false;
            dataFilesGrid.AllowUserToDeleteRows = false;

            dataFilesGrid.ColumnCount = 7;
            dataFilesGrid.Columns[0].Name = "Fileid";
            dataFilesGrid.Columns[1].Name = "FileName";
            dataFilesGrid.Columns[2].Name = "Filesize";
            dataFilesGrid.Columns[3].Name = "DateCreated";
            dataFilesGrid.Columns[4].Name = "Fileownerid";
            dataFilesGrid.Columns[5].Name = "FileOwner";
            dataFilesGrid.Columns[6].Name = "Description";

            //add rows from db
            userFilesRetrieval();

            ////ADD BUTTON COLUMN
            DataGridViewButtonColumn FullDetailsbtn = new DataGridViewButtonColumn();
            FullDetailsbtn.HeaderText = "Full Details";
            FullDetailsbtn.Name = "fDetails";
            FullDetailsbtn.Text = "Full Details";
            FullDetailsbtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            FullDetailsbtn.UseColumnTextForButtonValue = true;
            dataFilesGrid.Columns.Add(FullDetailsbtn);
        }

        private void retrieveFiles2(string listvalue, ArrayList searchfield)
        {
            dataFilesGrid.AllowUserToAddRows = false;
            dataFilesGrid.AllowUserToDeleteRows = false;

            dataFilesGrid.ColumnCount = 7;
            dataFilesGrid.Columns[0].Name = "Fileid";
            dataFilesGrid.Columns[1].Name = "FileName";
            dataFilesGrid.Columns[2].Name = "Filesize";
            dataFilesGrid.Columns[3].Name = "DateCreated";
            dataFilesGrid.Columns[4].Name = "Fileownerid";
            dataFilesGrid.Columns[5].Name = "FileOwner";
            dataFilesGrid.Columns[6].Name = "Description";

            //add rows from db
            userFilesRetrieval2(listvalue, searchfield);

            ////ADD BUTTON COLUMN
            DataGridViewButtonColumn FullDetailsbtn = new DataGridViewButtonColumn();
            FullDetailsbtn.HeaderText = "Full Details";
            FullDetailsbtn.Name = "fDetails";
            FullDetailsbtn.Text = "Full Details";
            FullDetailsbtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            FullDetailsbtn.UseColumnTextForButtonValue = true;
            dataFilesGrid.Columns.Add(FullDetailsbtn);
        }

        //Files
        private void userFilesRetrieval()
        {
            int count = 0;
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM fileInfo";
                MySqlCommand command = new MySqlCommand(query, con);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ArrayList row = new ArrayList();
                        row.Add(reader.GetInt32(reader.GetOrdinal("fileID")));
                        row.Add(reader.GetString(reader.GetOrdinal("fileName")));
                        row.Add(reader.GetString(reader.GetOrdinal("fileSize")));
                        row.Add(reader.GetString(reader.GetOrdinal("dateCreated")));
                        row.Add(reader.GetString(reader.GetOrdinal("fileOwnerID")));
                        row.Add(reader.GetString(reader.GetOrdinal("fileOwner")));
                        row.Add(reader.GetString(reader.GetOrdinal("Description")));
                        dataFilesGrid.Rows.Add(row.ToArray());
                        count++;
                    }
                    noOfFilesCreated.Text = count.ToString();
                    if (reader != null)
                        reader.Close();
                }
            }
        }

        private void userFilesRetrieval2(string listvalue, ArrayList searchfield)
        {
            for (int i = 0; i < searchfield.Count; i++)
            {
                using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
                {
                    con.Open();
                    String query = "SELECT * FROM fileInfo where fileID = @searchfield";
                    MySqlCommand command = new MySqlCommand(query, con);
                    command.Parameters.AddWithValue("@searchfield", searchfield[i].ToString());
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ArrayList row = new ArrayList();
                            row.Add(reader.GetInt32(reader.GetOrdinal("fileID")));
                            row.Add(reader.GetString(reader.GetOrdinal("fileName")));
                            row.Add(reader.GetString(reader.GetOrdinal("fileSize")));
                            row.Add(reader.GetString(reader.GetOrdinal("dateCreated")));
                            row.Add(reader.GetString(reader.GetOrdinal("fileOwnerID")));
                            row.Add(reader.GetString(reader.GetOrdinal("fileOwner")));
                            row.Add(reader.GetString(reader.GetOrdinal("Description")));
                            dataFilesGrid.Rows.Add(row.ToArray());
                        }

                        if (reader != null)
                            reader.Close();
                    }
                }
            }
        }

        //accountgrid buttons
        private void dataFilesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            //check if the column is a button column and check if the column is where the button is when click 
            //column 7 is Details button link to a more comprehensive information about the user
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataFilesGrid.Rows[e.RowIndex];
                //TODO - Button Clicked - Execute Code Here
                //MessageBox.Show(row.Cells[0].Value.ToString());

                string Fileid = row.Cells[0].Value.ToString();

                //mainly for admin to know which account to properly check on to get a clearer information
                AdminSession.fileID = Fileid;
                FileDetails FileDetails = new FileDetails();
                FileDetails.Show();
                Hide();
            }

        }

        //account fields filter
        private void filesFilter_TextChanged(object sender, EventArgs e)
        {
            string filesvalue = filesList.Text.ToString();
            string searchfield = filesFilter.Text;
            ArrayList fileid = new ArrayList();
            if (dataFilesGrid.RowCount == 0)
            {
                retrieveFiles();
            }
            for (int i = 0; i < dataFilesGrid.RowCount; i++)
            {
                 if (filesvalue == "Filename")
                 {
                    if (dataFilesGrid.Rows[i].Cells[1].Value.ToString().Contains(searchfield))
                    {
                        fileid.Add(dataFilesGrid.Rows[i].Cells[0].Value.ToString());
                    }
                 }
                else if (filesvalue == "FileOwner")
                {
                    if (dataFilesGrid.Rows[i].Cells[5].Value.ToString().Contains(searchfield))
                    {
                        fileid.Add(dataFilesGrid.Rows[i].Cells[0].Value.ToString());
                    }
                }
                else if (filesvalue == "Fileownerid")
                {
                    if (dataFilesGrid.Rows[i].Cells[4].Value.ToString().Contains(searchfield))
                    {
                        fileid.Add(dataFilesGrid.Rows[i].Cells[0].Value.ToString());
                    }
                }
            }
            if(filesvalue == "" || filesvalue == null)
            {
                
            }
            else
            {
                dataFilesGrid.Rows.Clear();
                dataFilesGrid.Refresh();
                retrieveFiles2(filesvalue, fileid);
            }
        }


        //LOGS!!!
        //log grid retrival
        private void retrieveLogs()
        {
            dataLogGrid.AllowUserToAddRows = false;
            dataLogGrid.AllowUserToDeleteRows = false;
            
            dataLogGrid.ColumnCount = 7;
            dataLogGrid.Columns[0].Name = "Logid";
            dataLogGrid.Columns[1].Name = "Loginfo";
            dataLogGrid.Columns[2].Name = "Logtype";
            dataLogGrid.Columns[3].Name = "Logdatetime";
            dataLogGrid.Columns[4].Name = "Userid";
            dataLogGrid.Columns[5].Name = "Email";
            dataLogGrid.Columns[6].Name = "FileID";

            //add rows from db
            userLogRetrieval();
        }

        //log with filter for type
        private void retrieveLogs2(string type)
        {
            dataLogGrid.AllowUserToAddRows = false;
            dataLogGrid.AllowUserToDeleteRows = false;

            dataLogGrid.ColumnCount = 7;
            dataLogGrid.Columns[0].Name = "Logid";
            dataLogGrid.Columns[1].Name = "Loginfo";
            dataLogGrid.Columns[2].Name = "Logtype";
            dataLogGrid.Columns[3].Name = "Logdatetime";
            dataLogGrid.Columns[4].Name = "Userid";
            dataLogGrid.Columns[5].Name = "Email";
            dataLogGrid.Columns[6].Name = "FileID";

            //add rows from db
            userLogRetrieval2(type);
        }

        //log
        private void userLogRetrieval()
        {
            int count = 0;
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM logInfo";
                MySqlCommand command = new MySqlCommand(query, con);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ArrayList row = new ArrayList();
                        row.Add(reader.GetInt32(reader.GetOrdinal("logid")));
                        row.Add(reader.GetString(reader.GetOrdinal("loginfo")));
                        row.Add(reader.GetString(reader.GetOrdinal("logtype")));
                        row.Add(reader.GetString(reader.GetOrdinal("logdatetime")));
                        //userid field
                        if (reader.IsDBNull(reader.GetOrdinal("userid")))
                        {
                            row.Add("Null");
                        }
                        else
                        {
                            row.Add(reader.GetString(reader.GetOrdinal("userid")));
                        }
                        //email field
                        if (reader.IsDBNull(reader.GetOrdinal("email")))
                        {
                            row.Add("Null");
                        }
                        else
                        {
                            row.Add(reader.GetString(reader.GetOrdinal("email")));
                        }
                        //fileID
                        if (reader.IsDBNull(reader.GetOrdinal("fileID")))
                        {
                            row.Add("Null");
                        }
                        else
                        {
                            row.Add(reader.GetString(reader.GetOrdinal("fileID")));
                        }
                        dataLogGrid.Rows.Add(row.ToArray());
                        count++;
                    }
                    noOfGeneralLogs.Text = count.ToString();
                    if (reader != null)
                        reader.Close();
                }
            }
        }

        //log with filter by type
        private void userLogRetrieval2(string type)
        {
            if (type == "All")
            {
                userLogRetrieval();
            }
            else
            {
                using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
                {
                    con.Open();
                    String query = "SELECT * FROM logInfo where logType = @logtype";
                    MySqlCommand command = new MySqlCommand(query, con);
                    command.Parameters.AddWithValue("@logtype", type);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ArrayList row = new ArrayList();
                            row.Add(reader.GetInt32(reader.GetOrdinal("logid")));
                            row.Add(reader.GetString(reader.GetOrdinal("loginfo")));
                            row.Add(reader.GetString(reader.GetOrdinal("logtype")));
                            row.Add(reader.GetString(reader.GetOrdinal("logdatetime")));
                            //userid
                            if (reader.IsDBNull(reader.GetOrdinal("userid")))
                            {
                                row.Add("Null");
                            }
                            else
                            {
                                row.Add(reader.GetString(reader.GetOrdinal("userid")));
                            }
                            //email
                            if (reader.IsDBNull(reader.GetOrdinal("email")))
                            {
                                row.Add("Null");
                            }
                            else
                            {
                                row.Add(reader.GetString(reader.GetOrdinal("email")));
                            }
                            //fileID
                            if (reader.IsDBNull(reader.GetOrdinal("fileID")))
                            {
                                row.Add("Null");
                            }
                            else
                            {
                                row.Add(reader.GetString(reader.GetOrdinal("fileID")));
                            }

                            dataLogGrid.Rows.Add(row.ToArray());
                        }

                        if (reader != null)
                            reader.Close();
                    }
                }
            }
        }

        //logsChanges
        private void logsFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string logListvalue = logTypeList.Text.ToString();
            if (dataLogGrid.RowCount == 0)
            {
                retrieveLogs();
            }
            

            dataLogGrid.Rows.Clear();
            dataLogGrid.Refresh();
            retrieveLogs2(logListvalue);
        }

        //buttons 

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

        private void changePassword_Click(object sender, EventArgs e)
        {
            AdminChangePassword changePassword = new AdminChangePassword();
            changePassword.Show();
            Hide();
        }

        private void metaAdmin_Click(object sender, EventArgs e)
        {
            MetaAdmin view = new MetaAdmin();
            view.Show();
            Hide();
        }
    }
}
