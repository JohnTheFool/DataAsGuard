using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAsGuard.CSClass;
using MySql.Data.MySqlClient;

namespace DataAsGuard.Chat
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
        }

        public Chat(string user)
        {
            InitializeComponent();
            userList.Items.Add(user);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Chat_Load(object sender, EventArgs e)
        {
            //only load user with messeges to the userlist
            List<string> SenderList = new List<string>();
            SenderList = SortDistinctSender();
            for (int i = 0; i < SenderList.Count; i++) {
                userList.Items.Add(SenderList[i]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #region Connection and Disconnection? Signal R how?
        public void Connect(string username)
        {
            //var id = Context.ConnectionId;

            //if (ConnectedUsers.Count(x => x.ConnectionId == id) == 0)
            //{
            //    //string UserImg = GetUserImage(userName);
            //    string logintime = DateTime.Now.ToString();
            //    //ConnectedUsers.Add(new Users { ConnectionId = id, UserName = userName, UserImage = UserImg, LoginTime = logintime });

            //    // send to caller
            //    //Clients.Caller.onConnected(id, userName, ConnectedUsers, CurrentMessage);

            //    // send to all except caller client
            //    //Clients.AllExcept(id).onNewUserConnected(id, userName, UserImg, logintime);
            //}
        }

        //public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        //{
        //    var item = ConnectedUsers.FirstOrDefault(x => x.ConnectionId == Context.ConnectionId);
        //    if (item != null)
        //    {
        //        ConnectedUsers.Remove(item);

        //        var id = Context.ConnectionId;
        //        Clients.All.onUserDisconnected(id, item.UserName);

        //    }
        //    return base.OnDisconnected(stopCalled);
        //}
        #endregion

        #region Message
        public List<RSAParameters> GetKeys(string recieverId)
        {
            List<EncryptClass> Keys = new List<EncryptClass>();
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String query = "SELECT * FROM da_schema.KeyList where user_id = @reciever";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@reciever", recieverId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Keys.Add(new EncryptClass { PublicIV = reader["iv"].ToString(), PublicKey = reader["key"].ToString() });
                }

                reader.Close();
                con.Close();
            }
            List<RSAParameters> RSAList = new List<RSAParameters>();
            for (int i = 0; i < Keys.Count; i++)
            {
                RSAList.Add(new RSAParameters { Modulus = Encoding.UTF8.GetBytes(Keys[i].PublicKey), Exponent = Encoding.UTF8.GetBytes(Keys[i].PublicIV) });
            }
            return RSAList;
        }

        public void SendMessage(string recieverId, string message, string time)
        {
            //change recieverid = currselected?
            List<RSAParameters> recieverKeys = new List<RSAParameters>();
            recieverKeys = GetKeys(recieverId);
            if (recieverKeys.Count != 0)
            {
                using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
                {
                    con.Open();
                    String executeQuery = "INSERT INTO da_schema.Messages(Sender,Reciever,Message,Time,key) VALUES (@Sender,@Reciever ,@Message, @Time,@key)";
                    MySqlCommand myCommand = new MySqlCommand(executeQuery, con);
                    myCommand.Parameters.AddWithValue("@Sender", Logininfo.username);
                    myCommand.Parameters.AddWithValue("@Reciever", recieverId);
                    myCommand.Parameters.AddWithValue("@Time", DateTime.Now);

                    for (int i = 0; i < recieverKeys.Count; i++)
                    {
                        message = EncrpytThis(message, recieverKeys[i]);
                        myCommand.Parameters.AddWithValue("@Message", message);
                        myCommand.Parameters.AddWithValue("@key", Encoding.UTF8.GetString(recieverKeys[i].Modulus));
                        myCommand.ExecuteNonQuery();

                    }
                    con.Close();
                }
            }

        }

        public List<Message> GetMessages()
        {
            //to generate chat?
            RSAParameters rsa = GetKeyFromContainer();
            List<Message> MessageList = new List<Message>();
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String executeQuery = "Select * from da_schema.Messages where Reciever = @reciever AND key = @key";
                MySqlCommand cmd = new MySqlCommand(executeQuery, con);
                cmd.Parameters.AddWithValue("@reciever", Logininfo.username);
                cmd.Parameters.AddWithValue("@key", Encoding.UTF8.GetString(rsa.Modulus));
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageList.Add(new Message { Sender = reader["Sender"].ToString(), Reciever = reader["Reciever"].ToString(),MessageText = reader["Message"].ToString()});  
                }
                con.Close();
            }
            return MessageList;
            //check if messageList is empty elsewhere
        }

        public List<string> SortDistinctSender()
        {
            RSAParameters rsa = GetKeyFromContainer();
            List<string> UniqueUserList = new List<string>();
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                //Select DISTINCT Sender from (Select * from da_schema.Messages where Reciever = @reciever AND key = @key)?
                String executeQuery = "Select DISTINCT Sender from da_schema.Messages where Reciever = @reciever AND key = @key";
                MySqlCommand cmd = new MySqlCommand(executeQuery, con);
                cmd.Parameters.AddWithValue("@reciever", Logininfo.username);
                cmd.Parameters.AddWithValue("@key", Encoding.UTF8.GetString(rsa.Modulus));
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UniqueUserList.Add(reader["Sender"].ToString());
                }
                con.Close();
            }
            return UniqueUserList;
        }
        #endregion

        #region encryption
        public string EncrpytThis(string text, RSAParameters rsaParam)
        {
            //revisit the site to confirm
            //this is the public key
            //load public key here
            //Initialize the byte arrays to the public key information.  
            //RSAParameters RSAParam = GetKeyFromContainer();
            //byte[] PublicKey = RSAParam.Modulus;

            //iv of the public key
            //byte[] Exponent = RSAParam.Exponent;


            //Maybe the final 2 lines need edit only
            //Create values to store encrypted symmetric keys.  
            //byte[] EncryptedSymmetricKey;
            //byte[] EncryptedSymmetricIV;

            //Create a new instance of the RSACryptoServiceProvider class.  
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

            ////Create a new instance of the RSAParameters structure.  
            //RSAParameters RSAKeyInfo = new RSAParameters();

            ////Set RSAKeyInfo to the public key values.   
            //RSAKeyInfo.Modulus = PublicKey;
            //RSAKeyInfo.Exponent = Exponent;

            //Import key parameters into RSA.  
            RSA.ImportParameters(rsaParam);


            //Create a new instance of the RijndaelManaged class.  
            //RijndaelManaged RM = new RijndaelManaged();

            //Encrypt the symmetric key and IV.  
            //EncryptedSymmetricKey = RSA.Encrypt(RM.Key, false);
            //EncryptedSymmetricIV = RSA.Encrypt(RM.IV, false);
            byte[] converted = Encoding.UTF8.GetBytes(text);
            byte[] EncryptedText = RSA.Encrypt(converted, false);

            string EncryptedString = Encoding.UTF8.GetString(EncryptedText);
            return EncryptedString;
        }

        public string Decrypt(string encrypted)
        {
            //Create a new instance of the RSACryptoServiceProvider class.  
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

            RSA.ImportParameters(GetFullKeyFromContainer());

            // Export the public key information and send it to a third party.  
            // Wait for the third party to encrypt some data and send it back.  
            byte[] converted = Encoding.UTF8.GetBytes(encrypted);
            byte[] decryptedbytes = RSA.Decrypt(converted, false);
            string decrypted = Encoding.UTF8.GetString(decryptedbytes);
            return decrypted;
            //Decrypt the symmetric key and IV.  
            //SymmetricKey = RSA.Decrypt(EncryptedSymmetricKey, false);
            //SymmetricIV = RSA.Decrypt(EncryptedSymmetricIV, false);
        }
        #endregion

        #region Key generation and log in 
        //example of what need to be done in login?
        public void LogIn()
        {
            //if getkeyfromcontainer("appname+userid") == "" *warning getkey will generate key so must check result and delete the key if it is empty*
            //genkey_saveincontainer -> save into db

            //might not need to generate new key pair as the containers method does generation too
            string containername = "DataAsGuard" + Logininfo.email;
            //Generate a public/private key pair.  
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            //Save the public key information to an RSAParameters structure.  
            RSAParameters RSAKeyInfo = RSA.ExportParameters(false);

            byte[] publickey = RSAKeyInfo.Modulus;
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String executeQuery = "INSERT INTO da_schema.KeyList(user_id,key,iv) VALUES (@userid,@key,@iv)";
                MySqlCommand myCommand = new MySqlCommand(executeQuery, con);
                myCommand.Parameters.AddWithValue("@userid", Logininfo.userid);
                myCommand.Parameters.AddWithValue("@key", Encoding.UTF8.GetString(publickey));
                myCommand.Parameters.AddWithValue("@iv", Encoding.UTF8.GetString(RSAKeyInfo.Exponent));
                myCommand.ExecuteNonQuery();
                con.Close();
            }
        }

        public static void GenKey_SaveInContainer()
        {
            string ContainerName = "DataAsGuard" + Logininfo.email;
            // Create the CspParameters object and set the key container   
            // name used to store the RSA key pair.  
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = ContainerName;

            // Create a new instance of RSACryptoServiceProvider that accesses  
            // the key container MyKeyContainerName.  
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            // Display the key information to the console.  
            Console.WriteLine("Key added to container: \n  {0}", rsa.ToXmlString(true));
        }

        public static RSAParameters GetKeyFromContainer()
        {
            string ContainerName = "DataAsGuard" + Logininfo.email;
            // Create the CspParameters object and set the key container   
            // name used to store the RSA key pair.  
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = ContainerName;

            // Create a new instance of RSACryptoServiceProvider that accesses  
            // the key container MyKeyContainerName.  
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            RSAParameters RSAParam = rsa.ExportParameters(false);
            return RSAParam;

            // Display the key information to the console.  
            //Console.WriteLine("Key retrieved from container : \n {0}", rsa.ToXmlString(true));
        }

        public static RSAParameters GetFullKeyFromContainer()
        {
            string ContainerName = "DataAsGuard" + Logininfo.email;

            // Create the CspParameters object and set the key container   
            // name used to store the RSA key pair.  
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = ContainerName;

            // Create a new instance of RSACryptoServiceProvider that accesses  
            // the key container MyKeyContainerName.  
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            RSAParameters RSAParam = rsa.ExportParameters(true);
            return RSAParam;

            // Display the key information to the console.  
            //Console.WriteLine("Key retrieved from container : \n {0}", rsa.ToXmlString(true));
        }

        public static void DeleteKeyFromContainer()
        {
            string ContainerName = "DataAsGuard" + Logininfo.email;

            // Create the CspParameters object and set the key container   
            // name used to store the RSA key pair.  
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = ContainerName;

            // Create a new instance of RSACryptoServiceProvider that accesses  
            // the key container.  
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            // Delete the key entry in the container.  
            rsa.PersistKeyInCsp = false;

            // Call Clear to release resources and delete the key from the container.  
            rsa.Clear();

            Console.WriteLine("Key deleted.");
        }
        /*
        //Generate a public/private key pair.  
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        //Save the public key information to an RSAParameters structure.  
        RSAParameters RSAKeyInfo = RSA.ExportParameters(false);


        */
        #endregion

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //on select change tab label and pull up chat
        }
    }
}
