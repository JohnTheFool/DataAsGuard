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
    public partial class AdminProfile : Form
    {
        AesEncryption aes = new AesEncryption();
        DBLogger dblog = new DBLogger();

        public AdminProfile()
        {
            InitializeComponent();
        }

        private void Adminprofile_Load(object sender,EventArgs e)
        {
            retrieveAccounts();
        }

        private void retrieveAccounts()
        {
            dataAccountGrid.AllowUserToAddRows = false;
            dataAccountGrid.AllowUserToDeleteRows = false;
            dataAccountGrid.ColumnCount = 7;
            dataAccountGrid.Columns[0].Name = "Userid";
            dataAccountGrid.Columns[1].Name = "Username";
            dataAccountGrid.Columns[2].Name = "Email";
            dataAccountGrid.Columns[3].Name = "FullName";
            dataAccountGrid.Columns[4].Name = "Dob";
            dataAccountGrid.Columns[5].Name = "Contact";
            dataAccountGrid.Columns[6].Name = "Vflag";

            //add rows from db
            userdataRetrieval();

            ////ADD BUTTON COLUMN
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Unlock/Lock Btn";
            btn.Name = "UnlockLockbtn";
            btn.Text = "Unlock/Lock btn";
            btn.UseColumnTextForButtonValue = true;
            dataAccountGrid.Columns.Add(btn);

            ////ADD BUTTON COLUMN
            DataGridViewButtonColumn FullDetailsbtn = new DataGridViewButtonColumn();
            FullDetailsbtn.HeaderText = "Full Details";
            FullDetailsbtn.Name = "fDetails";
            FullDetailsbtn.Text = "Full Details";
            FullDetailsbtn.UseColumnTextForButtonValue = true;
            dataAccountGrid.Columns.Add(FullDetailsbtn);
        }

        //accountgrid buttons
        private void dataAccountGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            //check if the column is a button column and check if the column is where the button is when click 
            //column 7 is unlock and lock button
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
                    string vflag = row.Cells[6].Value.ToString();
                    if(vflag == "L")
                    {
                        updateAccountstatus(userid, vflag);
                        MessageBox.Show("Account status of user have been updated!");
                        dataAccountGrid.Rows.Clear();
                        dataAccountGrid.Refresh();
                        retrieveAccounts();
                        dblog.Log("Account status changed", "Accounts", Logininfo.userid, Logininfo.email);
                    }
                    else if(vflag == "F")
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
                        dblog.Log("Account status changed", "Accounts", Logininfo.userid, Logininfo.email);
                    }
                }
            }
        }

        private void updateAccountstatus(string userid, string vflag)
        {
            //UPDATE PASSWORD TO DATABASE
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                string queryStr = "";
                queryStr = "UPDATE Userinfo set verificationflag=@vflag where userid = @userid";

                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, con);
                if (vflag == "L")
                {
                    //lock to unlock
                    cmd.Parameters.AddWithValue("@vflag", "T");
                }
                else if (vflag == "T")
                {
                    //unlock to lock
                    cmd.Parameters.AddWithValue("@vflag", "L");
                }
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.ExecuteReader();
                con.Close();
            }
        }

        private void userdataRetrieval()
        {
            AesEncryption aes = new AesEncryption();

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
                        row.Add(reader.GetString(reader.GetOrdinal("dob")));
                        row.Add(aes.Decryptstring(reader.GetString(reader.GetOrdinal("contact")), reader.GetString(reader.GetOrdinal("userid"))));
                        row.Add(reader.GetString(reader.GetOrdinal("verificationflag")));
                        dataAccountGrid.Rows.Add(row.ToArray());
                    }

                    if (reader != null)
                        reader.Close();
                }
            }
        }

        private void chgpass_Click(object sender, EventArgs e)
        {
            AdminChangePassword chgpassword = new AdminChangePassword();
            chgpassword.Show();
            Hide();
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

        private void changePassword_Click(object sender, EventArgs e)
        {
            AdminChangePassword changePassword = new AdminChangePassword();
            changePassword.Show();
            Hide();
        }

        
    }
}
