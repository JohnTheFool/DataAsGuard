using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAsGuard.FileManagement
{
    public partial class EditUserPermissions : Form
    {

        MySqlDataAdapter adapter;
        DataTable table = new DataTable();

        public EditUserPermissions()
        {
            InitializeComponent();
        }

        private void EditUserPermissions_Load(object sender, EventArgs e)
        {
            //Load user list
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                adapter = new MySqlDataAdapter("SELECT * FROM da_schema.Userinfo", con);
                adapter.Fill(table);
                userList.DataSource = table;
                userList.DisplayMember = "fullName";
                userList.ValueMember = "userid";
                con.Close();
            }
        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            userSelectedLabel.Text = null;
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                string curItem = userList.SelectedValue.ToString();
                String query = "SELECT * FROM da_schema.Userinfo WHERE userid = @idParam";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idParam", curItem);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userSelectedLabel.Text = reader["fullName"].ToString();
                } 
                reader.Close();
                con.Close();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FileManagementHub view = new FileManagement.FileManagementHub();
            view.Show();
            Hide();
        }
    }
}
