using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAsGuard.CSClass;
using DataAsGuard.Profiles.Users;
using MySql.Data.MySqlClient;

namespace DataAsGuard.Chat
{
    
    public partial class ChatRequest : Form
    {
        public ChatRequest()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        

       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string curruser = userList.SelectedItem.ToString();
            Chat chat = new Chat(curruser);
            chat.Show();
            Hide();
        }
        public string getNameOfId(string userid)
        {
            string meh = "";
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                //Select DISTINCT Sender from (Select * from da_schema.Messages where Reciever = @reciever AND key = @key)?

                String executeQuery = "Select fullName from Userinfo where userid = @id";
                MySqlCommand cmd = new MySqlCommand(executeQuery, con);
                //cmd.Parameters.AddWithValue("@reciever", Logininfo.username);
                cmd.Parameters.AddWithValue("@id", userid);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    meh = reader["fullName"].ToString();
                }
                con.Close();
            }
            return meh;
        }


        private void ChatRequest_Load(object sender, EventArgs e)
        {
            List<string> users = new List<string>();
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM da_schema.KeyList";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["user_id"].ToString() != "1" && reader["user_id"].ToString() != Logininfo.userid)
                    {
                        users.Add(getNameOfId(reader["user_id"].ToString()));
                    }
                }
                reader.Close();
                con.Close();
            }
            HashSet<string> uniqueuser = new HashSet<string>(users);
            foreach(string s in uniqueuser)
            {
                userList.Items.Add(s);
            }
        }
        
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            userList.Items.Clear();
            string find = textBox1.Text;
            Console.WriteLine(find);
            Console.WriteLine(textBox1.Text);
            List<string> users = new List<string>();
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM da_schema.KeyList";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["user_id"].ToString() != "1" && reader["user_id"].ToString() != Logininfo.userid)
                    {
                        users.Add(getNameOfId(reader["user_id"].ToString()));
                    }
                }

                reader.Close();
                con.Close();
            }
            users.Sort();

            HashSet<string> uniqueuser = new HashSet<string>(users);


            foreach (string s in uniqueuser)
            {
                Console.WriteLine(s);
                if (s.ToLower().Like("%"+find.ToLower()+"%" ))
                {
                    userList.Items.Add(s);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Hide();
        }

        private void ProfileButton_Click_1(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            Hide();
        }

        private void settingsButton_Click_1(object sender, EventArgs e)
        {
            Profilesettings settings = new Profilesettings();
            settings.Show();
            Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Chat Chat = new Chat();
            Chat.Show();
            Hide();
        }
    }
}
