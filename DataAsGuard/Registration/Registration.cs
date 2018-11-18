using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataAsGuard.Registration
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Shown(Object sender, EventArgs e)
        {
            userdataRetrieval();
        }

        private void userdataRetrieval()
        {
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {

                con.Open();
                String query = "SELECT * FROM Userinfo WHERE userid='1'";
                MySqlCommand command = new MySqlCommand(query, con);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        name.Text = reader.GetString(reader.GetOrdinal("username"));
                        password.Text = reader.GetString(reader.GetOrdinal("password"));
                        phoneNo.Text = reader.GetInt32(reader.GetOrdinal("phoneno.")).ToString();
                        email.Text = reader.GetString(reader.GetOrdinal("email"));
                        DOB.Text = reader.GetString(reader.GetOrdinal("dob"));

                    }

                    if (reader != null)
                        reader.Close();
                }

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
