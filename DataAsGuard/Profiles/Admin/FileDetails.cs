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

        public FileDetails()
        {
            InitializeComponent();
        }

        private void fileDetails_Shown(Object sender, EventArgs e)
        {
            userfilesRetrieval();
            retrieveLogs();
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
