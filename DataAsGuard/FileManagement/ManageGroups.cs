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
    public partial class ManageGroups : Form
    {
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();

        public ManageGroups()
        {
            InitializeComponent();
        }

        private void createGroupButton_Click(object sender, EventArgs e)
        {
            FileManagement.CreateNewGroup createNewGroup = new FileManagement.CreateNewGroup();
            createNewGroup.Show();
            Hide();
        }

        private void ViewGroups_Load(object sender, EventArgs e)
        {
            //Load all groups from MySql
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                adapter = new MySqlDataAdapter("SELECT * FROM da_schema.groupInfo", con);
                adapter.Fill(table);
                groupList.DataSource = table;
                groupList.DisplayMember = "groupName";
                groupList.ValueMember = "groupID";
                con.Close();
            }
        }

        private void groupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupInformation.Clear();
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                string curItem = groupList.SelectedValue.ToString();
                String query = "SELECT * FROM da_schema.groupInfo WHERE groupID = @idParam";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idParam", curItem);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    groupInformation.AppendText("Date Created: " + reader["dateCreated"].ToString());
                    groupInformation.AppendText(Environment.NewLine + "Group Creator: " + reader["groupCreator"].ToString());
                    groupInformation.AppendText(Environment.NewLine + "Group Description: " + reader["groupDescription"].ToString());
                }
                reader.Close();
                con.Close();
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Home view = new Home();
            view.Show();
            Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            FileManagementHub view = new FileManagementHub();
            view.Show();
            Hide();
        }
    }
}
