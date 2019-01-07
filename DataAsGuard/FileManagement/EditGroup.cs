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
    public partial class EditGroup : Form
    {

        public EditGroup(String groupEdited)
        {
            InitializeComponent();
            groupName_Text.Text = groupEdited;  
        }

        private void EditGroup_Load(object sender, EventArgs e)
        {
            LoadUsersIntoMembersList();
        }

        private void LoadUsersIntoMembersList()
        {
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM groupUsers WHERE groupName = @nameParam";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("nameParam", groupName_Text.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    groupMembers.Items.Add(reader["userFullName"].ToString());
                }
                reader.Close();
                con.Close();
            }
        }
    }
}
