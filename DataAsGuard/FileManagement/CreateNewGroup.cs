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

namespace DataAsGuard.FileManagement
{
    public partial class CreateNewGroup : Form
    {
        public CreateNewGroup()
        {
            InitializeComponent();
        }

        private void createGroupButton_Click(object sender, EventArgs e)
        {
            InsertGroupInfoIntoDatabase();

        }

        private void InsertGroupInfoIntoDatabase()
        {
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {

                con.Open();
                String executeQuery = "INSERT INTO groupInfo(groupName, groupDescription) VALUES (@groupNameParam, @groupDescParam)";
                MySqlCommand myCommand = new MySqlCommand(executeQuery, con);
                myCommand.Parameters.AddWithValue("@groupNameParam", this.groupName_Text.Text);
                myCommand.Parameters.AddWithValue("@groupDescParam", this.groupDescription_Text.Text);
                myCommand.ExecuteNonQuery();
                con.Close();
            }

            System.Windows.Forms.MessageBox.Show("Successfully created group.");
            FileManagement.CreateNewGroup view = new FileManagement.CreateNewGroup();
            view.Show();
            Hide();
        }
    }
}
