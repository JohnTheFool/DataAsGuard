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

        public AccountDetails()
        {
            InitializeComponent();
        }

        private void accountDetails_Shown(Object sender, EventArgs e)
        {
            userdataRetrieval();
            retrieveLogs();
            chartInitialized();
        }

        private void userdataRetrieval()
        {
            
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM Userinfo WHERE userid=@userid";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@userid", CSClass.Logininfo.userid.ToString());
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userid.Text = reader.GetString(reader.GetOrdinal("userid"));
                        Username.Text = aes.Decryptstring(reader.GetString(reader.GetOrdinal("username")), Logininfo.userid.ToString());
                        FName.Text = reader.GetString(reader.GetOrdinal("firstname")) + " " + reader.GetString(reader.GetOrdinal("lastname"));
                        Contact.Text = "****" + aes.Decryptstring(reader.GetString(reader.GetOrdinal("contact")), Logininfo.userid.ToString()).Substring(4, 4);
                        Email.Text = aes.Decryptstring(reader.GetString(reader.GetOrdinal("email")), Logininfo.userid.ToString());
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
                        data.Add(DateTime.ParseExact(reader.GetString(reader.GetOrdinal("logDateTime")),"dd/MM/yyyy HH:mm:ss",null));
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

                if(checkdate == checkoldDate)
                {
                    olddate = DateTime.Parse(data[i].ToString());
                    checkoldDate = olddate.ToString("dd/MM/yyyy");
                    count++;
                    if(i == data.Count-1) {
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
