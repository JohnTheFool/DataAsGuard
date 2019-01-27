using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAsGuard.CSClass;
using DataAsGuard.Profiles.Users;
using iTextSharp.text;
using Microsoft.AspNet.SignalR.Client;
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
            if ((ListBox.NoMatches == userList.FindStringExact(user)))
            {
                userList.Items.Add(user);
            }
            else
            {
                richTextBox1.Clear();
                richTextBox1.ReadOnly = true;
                string userSelected = userList.Text.ToString();
                List<Message> messagelist = GetMessages(getIdoffullName(userSelected));
                username.Text = userSelected;
                Console.WriteLine("Messagecount:" + messagelist.Count);
                if (messagelist.Count != 0)
                {
                    for (int i = 0; i < messagelist.Count(); i++)
                    {
                        if (messagelist[i].Sender == Logininfo.userid)
                        {
                            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                            richTextBox1.AppendText(getNameOfId(Logininfo.userid) + ":" + Environment.NewLine + messagelist[i].MessageText);
                            
                        }
                        else
                        {
                            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                            richTextBox1.AppendText(username.Text + ":" + Environment.NewLine + messagelist[i].MessageText);
                           
                        }
                        richTextBox1.AppendText(Environment.NewLine);
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Chat_Load(object sender, EventArgs e)
        {
            //only load user with messeges to the userlist
            List<string> SenderList = getuniquesender();
            Console.WriteLine("senderlist" + SenderList.Count);
            foreach(string s in SenderList)
            {
                //Console.WriteLine(s);
                if (s != Logininfo.userid && (ListBox.NoMatches == userList.FindStringExact(s)))
                {
                    //try adding coloured item when for notifications
                    //Console.WriteLine("im stupid");
                    userList.Items.Add(getNameOfId(s));
                }
            }
            richTextBox1.ReadOnly = true;

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
                    Keys.Add(new EncryptClass { PublicIV = reader["iv"].ToString(), PublicKey = reader["keyval"].ToString() });
                }

                reader.Close();
                con.Close();
            }
            List<RSAParameters> RSAList = new List<RSAParameters>();
            for (int i = 0; i < Keys.Count; i++)
            {
                RSAList.Add(new RSAParameters { Modulus = Convert.FromBase64String(Keys[i].PublicKey), Exponent = Convert.FromBase64String(Keys[i].PublicIV) });
            }
            return RSAList;
        }
        public void SendPrivateMessage(string fromUserId, string message, string CurrentDateTime)
        {
            var hubConnection = new HubConnection("");
        }

        public void SendMessage(string recieverId, string message)
        {
            
            EncrpytThis(message, recieverId);
            
            //ChatHub.HubContext.Clients.User(recieverId).SendPrivateMessage(recieverId, message);
            //new change use encrpytthis to add into db ... edit this to make it so that happends
            //change recieverid = currselected?
            //List<RSAParameters> recieverKeys = new List<RSAParameters>();
            //recieverKeys = GetKeys(recieverId);
            //if (recieverKeys.Count != 0)
            //{
            //    using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            //    {
            //        con.Open();
            //        String executeQuery = "INSERT INTO da_schema.Messages(Sender,Reciever,Message,Time,key) VALUES (@Sender,@Reciever ,@Message, @Time,@key)";
            //        MySqlCommand myCommand = new MySqlCommand(executeQuery, con);
            //        myCommand.Parameters.AddWithValue("@Sender", Logininfo.username);
            //        myCommand.Parameters.AddWithValue("@Reciever", recieverId);
            //        myCommand.Parameters.AddWithValue("@Time", DateTime.Now);

            //        for (int i = 0; i < recieverKeys.Count; i++)
            //        {
            //            message = EncrpytThis(message, recieverKeys[i]);
            //            myCommand.Parameters.AddWithValue("@Message", message);
            //            myCommand.Parameters.AddWithValue("@key", Encoding.UTF8.GetString(recieverKeys[i].Modulus));
            //            myCommand.ExecuteNonQuery();

            //        }
            //        con.Close();
            //    }
            //}

        }

        public List<Message> GetMessages(string user)
        {
            //to generate chat?
            RSAParameters rsa = GetKeyFromContainer();
            List<Message> MessageList = new List<Message>();
            RSACryptoServiceProvider RSAD = new RSACryptoServiceProvider();
            RSAD.ImportParameters(GetFullKeyFromContainer());
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                //getmessage = from user to me/ me to user
                String executeQuery = "Select * from da_schema.Messages where (keyval = @key and Sender = @sender) or (fromkey = @key1 and Sender = @sender1 and Reciever = @reciever)";
                MySqlCommand cmd = new MySqlCommand(executeQuery, con);
                cmd.Parameters.AddWithValue("@sender", user);
                cmd.Parameters.AddWithValue("@key", Convert.ToBase64String(rsa.Modulus));
                cmd.Parameters.AddWithValue("@key1", Convert.ToBase64String(rsa.Modulus));
                cmd.Parameters.AddWithValue("@sender1", Logininfo.userid);
                cmd.Parameters.AddWithValue("@reciever", user);
                MySqlDataReader reader = cmd.ExecuteReader();
                //checkthis
                while (reader.Read())
                {
                    Message message = new Message { Sender = reader["Sender"].ToString(), Reciever = reader["Reciever"].ToString(), MessageText = reader["Message"].ToString(), Time = reader["Time"].ToString(), fromkey = reader["fromkey"].ToString(), otherkey = reader["keyval"].ToString() };
                    if (!MessageList.Contains(message))
                    {
                        MessageList.Add(message);
                    }
                }
                Console.WriteLine("MessageList" + MessageList.Count());
                reader.Close();
                con.Close();
            }
            
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String executeQuery = "select * from SymKey where (intendedkey = @reciever AND senderpub = @sender) OR (intendedkey = @reciever1 AND senderpub = @sender1)";
                MySqlCommand mycmd = new MySqlCommand(executeQuery, con);
                mycmd.Parameters.AddWithValue("@reciever",Convert.ToBase64String(rsa.Modulus));
                mycmd.Parameters.AddWithValue("@sender1", Convert.ToBase64String(rsa.Modulus));
                mycmd.Parameters.AddWithValue("@reciever1", "");
                mycmd.Parameters.AddWithValue("@sender", "");
                //change the logic? its working but this decryption is slowaf cuz per message so change to get all keys from parties and then search keylist?
                //bool flag = false;
                for (int i = 0; i < MessageList.Count(); i++)
                {
                    if (MessageList[i].fromkey.Equals(Convert.ToBase64String(rsa.Modulus)))
                    {
                        mycmd.Parameters["@reciever1"].Value = MessageList[i].otherkey;
                        mycmd.Parameters["@sender"].Value = MessageList[i].otherkey;
                    }
                    else
                    {
                        mycmd.Parameters["@reciever1"].Value = MessageList[i].fromkey;
                        mycmd.Parameters["@sender"].Value = MessageList[i].fromkey;
                    }
                    MySqlDataReader reader = mycmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader["sender"].ToString().Equals(Logininfo.userid))
                        {
                            RijndaelManaged RM = new RijndaelManaged();
                            RM.Key = RSAD.Decrypt(Convert.FromBase64String(reader["sendersym"].ToString()),false);
                            RM.IV = RSAD.Decrypt(Convert.FromBase64String(reader["senderiv"].ToString()), false);
                            MessageList[i].MessageText = Decrpyt(MessageList[i].MessageText, RM);
                            //Console.WriteLine("Test me");
                        }
                        else 
                        {
                            RijndaelManaged RM = new RijndaelManaged();
                            RM.Key = RSAD.Decrypt(Convert.FromBase64String(reader["symkey"].ToString()), false);
                            RM.IV = RSAD.Decrypt(Convert.FromBase64String(reader["symiv"].ToString()), false);
                            MessageList[i].MessageText = Decrpyt(MessageList[i].MessageText, RM);
                            //Console.WriteLine("fuck me");
                        }
                    }
                    else { Console.WriteLine("Scream"); }
                    reader.Close();
                }
                con.Close();
            }
            return MessageList;
            //check if messageList is empty elsewhere
        }
        public string getIdoffullName(string fullName)
        {
            string meh = "";
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                //Select DISTINCT Sender from (Select * from da_schema.Messages where Reciever = @reciever AND key = @key)?

                String executeQuery = "Select userid from Userinfo where fullName = @id";
                MySqlCommand cmd = new MySqlCommand(executeQuery, con);
                //cmd.Parameters.AddWithValue("@reciever", Logininfo.username);
                cmd.Parameters.AddWithValue("@id", fullName);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    meh = reader["userid"].ToString();
                }
                con.Close();
            }
            return meh;
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

        //is unique chat?
        public List<string> getuniquesender()
        {
            List<string> UniqueUserList = new List<string>();
            RSAParameters rsa = GetKeyFromContainer();
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                //Select DISTINCT Sender from (Select * from da_schema.Messages where Reciever = @reciever AND key = @key)?
                
                String executeQuery = "Select Distinct Sender, Reciever from da_schema.Messages where keyval = @key OR fromkey = @key1";
                MySqlCommand cmd = new MySqlCommand(executeQuery, con);
                //cmd.Parameters.AddWithValue("@reciever", Logininfo.username);
                cmd.Parameters.AddWithValue("@key", Convert.ToBase64String(rsa.Modulus));
                cmd.Parameters.AddWithValue("@key1", Convert.ToBase64String(rsa.Modulus));
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string s = reader["Sender"].ToString();
                    string r = reader["Reciever"].ToString();
                    if (UniqueUserList.Contains(r) == false && s.Equals(Logininfo.userid))
                    {
                        UniqueUserList.Add(reader["Reciever"].ToString());
                    }
                    else if(UniqueUserList.Contains(s) == false && !s.Equals(Logininfo.userid))
                    {
                        UniqueUserList.Add(s);
                    }
                }
                
                con.Close();
            }
            return UniqueUserList;
        }
        #endregion

        #region encryption
        public class encryptedsym{
            public string symkey { get; set; }
            public string symiv { get; set; }
            public string relatedkey { get; set; }
            //related key = their key cuz i alr know my key and i need to decrypt myside of the key matching their key and encrypt message with the decrypted side of my key
        }

        public List<encryptedsym> EqualityChecker(string reciever)
        {
            List<RSAParameters> keylist = GetKeys(reciever);
            RSAParameters mykey = GetKeyFromContainer();
            List<encryptedsym> symkeylist = new List<encryptedsym>();
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                

                if (keylist.Count != 0)
                {
                    //sql not working?
                    //string executeQuery = "select * from SymKey where (intendedkey = @reciever AND senderpub = @sender) OR (intendedkey = @reciever1 AND senderpub = @sender1)";
                    //MySqlCommand cmd = new MySqlCommand(executeQuery, con);
                    //cmd.Parameters.AddWithValue("@reciever1", Convert.ToBase64String(mykey.Modulus));
                    //cmd.Parameters.AddWithValue("@sender",Convert.ToBase64String(mykey.Modulus));
                    //cmd.Parameters.AddWithValue("@reciever", "");
                    //cmd.Parameters.AddWithValue("@sender1", "");
                    for (int i = 0; i < keylist.Count(); i++)
                    {
                        con.Open();
                        string executeQuery = "select * from SymKey where (intendedkey = @reciever AND senderpub = @sender) OR (intendedkey = @reciever1 AND senderpub = @sender1)";
                        MySqlCommand cmd = new MySqlCommand(executeQuery, con);
                        cmd.Parameters.AddWithValue("@reciever1", Convert.ToBase64String(mykey.Modulus));
                        cmd.Parameters.AddWithValue("@sender", Convert.ToBase64String(mykey.Modulus));
                        cmd.Parameters.AddWithValue("@reciever", "");
                        cmd.Parameters.AddWithValue("@sender1", "");
                        cmd.Parameters["@reciever"].Value = Convert.ToBase64String(keylist[i].Modulus);
                        cmd.Parameters["@sender1"].Value = Convert.ToBase64String(keylist[i].Modulus);
                        //cmd.Parameters.AddWithValue("@reciever", Convert.ToBase64String(keylist[i].Modulus));
                        //cmd.Parameters.AddWithValue("@sender1", Convert.ToBase64String(keylist[i].Modulus));
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string sender = reader["sender"].ToString();
                            if (sender == Logininfo.userid)
                            {
                                symkeylist.Add(new encryptedsym { symkey = reader["sendersym"].ToString(), symiv = reader["senderiv"].ToString(), relatedkey = reader["intendedkey"].ToString() });
                            }
                            else
                            {
                                symkeylist.Add(new encryptedsym { symkey = reader["symkey"].ToString(), symiv = reader["symiv"].ToString(), relatedkey = reader["senderpub"].ToString() });
                            }
                        }
                        else
                        {
                            if (!Convert.ToBase64String(keylist[i].Modulus).Equals(Convert.ToBase64String(mykey.Modulus)))
                            {
                                symkeylist.Add(GenSymKey(reciever, keylist[i]));
                            }
                        }
                        con.Close();
                    }
                   
                }
                //con.Close();
            }
            return symkeylist;
        }

        //use this to send symmetric to db instead of message
        //generate single key
        public encryptedsym GenSymKey(string reciever, RSAParameters recieverkey)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSACryptoServiceProvider RSAin = new RSACryptoServiceProvider();
            //RSA.ImportParameters();
            byte[] EncryptedSymmetricKey;
            byte[] EncryptedSymmetricIV;
            encryptedsym returnsym = new encryptedsym();

            RSAin.ImportParameters(GetKeyFromContainer());
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String executeQuery = "INSERT INTO da_schema.SymKey(reciever,symkey,symiv,intendedkey,sender,sendersym,senderiv,senderpub) VALUES (@reciever,@symkey,@symiv,@intended,@sender,@sendersym,@senderiv,@senderpub)";
                MySqlCommand myCommand = new MySqlCommand(executeQuery, con);
                myCommand.Parameters.AddWithValue("@reciever", reciever);
                //add own sym key in
                myCommand.Parameters.AddWithValue("@sender", Logininfo.userid);
                
                myCommand.Parameters.AddWithValue("@senderpub", Convert.ToBase64String(GetKeyFromContainer().Modulus));

                RijndaelManaged RM = new RijndaelManaged();
                RSA.ImportParameters(recieverkey);
                EncryptedSymmetricKey = RSA.Encrypt(RM.Key, false);
                EncryptedSymmetricIV = RSA.Encrypt(RM.IV, false);
                myCommand.Parameters.AddWithValue("@sendersym", Convert.ToBase64String(RSAin.Encrypt(RM.Key,false)));
                myCommand.Parameters.AddWithValue("@senderiv", Convert.ToBase64String(RSAin.Encrypt(RM.IV, false)));
                myCommand.Parameters.AddWithValue("@symkey", Convert.ToBase64String(EncryptedSymmetricKey));
                myCommand.Parameters.AddWithValue("@symiv", Convert.ToBase64String(EncryptedSymmetricIV));
                myCommand.Parameters.AddWithValue("@intended", Convert.ToBase64String(recieverkey.Modulus));
                //Console.WriteLine(reciever);
                //Console.WriteLine(Logininfo.username);
                myCommand.ExecuteNonQuery();
                returnsym = new encryptedsym { symkey = Convert.ToBase64String(RSAin.Encrypt(RM.Key, false)) 
                                                , symiv = Convert.ToBase64String(RSAin.Encrypt(RM.IV, false)),
                                                    relatedkey = Convert.ToBase64String(recieverkey.Modulus)
                };

                con.Close();
            }
            return returnsym;
        }
        //what happen to multiple acc with one user?
        //redo to encrypt message
        //send message from here?
        public void EncrpytThis(string text, string reciever)
        {
            List<encryptedsym> intialkeylist = EqualityChecker(reciever);
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(GetFullKeyFromContainer());
            List<encryptedsym> SendtoSelfList = EqualityChecker(Logininfo.userid);
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String executeQuery = "INSERT INTO da_schema.Messages(Sender,Reciever,Message,Time,keyval,fromkey) VALUES (@Sender,@Reciever ,@Message, @Time,@key,@fromkey)";
                MySqlCommand myCommand = new MySqlCommand(executeQuery, con);
                myCommand.Parameters.AddWithValue("@Sender", Logininfo.userid);
                myCommand.Parameters.AddWithValue("@Reciever", reciever);
                myCommand.Parameters.AddWithValue("@Time", DateTime.Now);
                myCommand.Parameters.AddWithValue("@fromkey",Convert.ToBase64String(RSA.ExportParameters(false).Modulus));
                myCommand.Parameters.AddWithValue("@Message", "");
                myCommand.Parameters.AddWithValue("@key", "");
                for (int i = 0; i < intialkeylist.Count; i++)
                {
                    using (RijndaelManaged RM = new RijndaelManaged())
                    {
                        //how do i know to send to which account ... add related key to encryptedsym
                        RM.Key = RSA.Decrypt(Convert.FromBase64String(intialkeylist[i].symkey), false);
                        RM.IV = RSA.Decrypt(Convert.FromBase64String(intialkeylist[i].symiv), false);
                        //myCommand.Parameters.AddWithValue("@Message",(Convert.ToBase64String(EncryptStringToBytes(text, RM.Key, RM.IV))));
                        //myCommand.Parameters.AddWithValue("@key", intialkeylist[i].relatedkey);
                        myCommand.Parameters["@Message"].Value = (Convert.ToBase64String(EncryptStringToBytes(text, RM.Key, RM.IV)));
                        myCommand.Parameters["@key"].Value = intialkeylist[i].relatedkey;
                        myCommand.ExecuteNonQuery();
                    }
                }
                if(SendtoSelfList.Count() >= 1)
                {
                    executeQuery = "INSERT INTO da_schema.Messages(Sender,Reciever,Message,Time,keyval,fromkey) VALUES (@Sender,@Reciever ,@Message, @Time,@key,@fromkey)";
                    myCommand = new MySqlCommand(executeQuery, con);
                    myCommand.Parameters.AddWithValue("@Sender", Logininfo.userid);
                    myCommand.Parameters.AddWithValue("@Reciever", reciever);
                    myCommand.Parameters.AddWithValue("@Time", DateTime.Now);
                    myCommand.Parameters.AddWithValue("@fromkey", Convert.ToBase64String(RSA.ExportParameters(false).Modulus));
                    myCommand.Parameters.AddWithValue("@Message", "");
                    myCommand.Parameters.AddWithValue("@key", "");
                    for (int i =0;i< SendtoSelfList.Count(); i++)
                    {
                        using (RijndaelManaged RM = new RijndaelManaged())
                        {
                            RM.Key = RSA.Decrypt(Convert.FromBase64String(SendtoSelfList[i].symkey), false);
                            RM.IV = RSA.Decrypt(Convert.FromBase64String(SendtoSelfList[i].symiv), false);
                            myCommand.Parameters["@Message"].Value = (Convert.ToBase64String(EncryptStringToBytes(text, RM.Key, RM.IV)));
                            myCommand.Parameters["@key"].Value = SendtoSelfList[i].relatedkey;
                            
                            myCommand.ExecuteNonQuery();
                        }
                    }
                }
                con.Close();
            }
            /*return encryptedmessages;
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
            //RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

            ////Create a new instance of the RSAParameters structure.  
            //RSAParameters RSAKeyInfo = new RSAParameters();

            ////Set RSAKeyInfo to the public key values.   
            //RSAKeyInfo.Modulus = PublicKey;
            //RSAKeyInfo.Exponent = Exponent;

            //Import key parameters into RSA.  
            //RSA.ImportParameters(rsaParam);


            //Create a new instance of the RijndaelManaged class.  
            //RijndaelManaged RM = new RijndaelManaged();

            //Encrypt the symmetric key and IV.  
            //EncryptedSymmetricKey = RSA.Encrypt(RM.Key, false);
            //EncryptedSymmetricIV = RSA.Encrypt(RM.IV, false);
            //byte[] converted = Encoding.UTF8.GetBytes(text);
            //byte[] EncryptedText = RSA.Encrypt(converted, false);

            //string EncryptedString = Encoding.UTF8.GetString(EncryptedText);
            return EncryptedString;
            */
        }

        public string Decrpyt(string encrypted, RijndaelManaged myRijndael)
        {
            
            //Create a new instance of the RSACryptoServiceProvider class.  
            

            // Export the public key information and send it to a third party.  
            // Wait for the third party to encrypt some data and send it back.  
            //byte[] converted = Encoding.UTF8.GetBytes(encrypted);
            //byte[] decryptedbytes = RSA.Decrypt(converted, false);
            //string decrypted = Encoding.UTF8.GetString(decryptedbytes);
            string roundtrip = DecryptStringFromBytes(Convert.FromBase64String(encrypted), myRijndael.Key, myRijndael.IV);
            return roundtrip;
            //return decrypted;
            //Decrypt the symmetric key and IV.  
            //SymmetricKey = RSA.Decrypt(EncryptedSymmetricKey, false);
            //SymmetricIV = RSA.Decrypt(EncryptedSymmetricIV, false);
        }
        
        static byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments. 
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;
            // Create an RijndaelManaged object 
            // with the specified key and IV. 
            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for encryption. 
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }


            // Return the encrypted bytes from the memory stream. 
            return encrypted;

        }

        static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments. 
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold 
            // the decrypted text. 
            string plaintext = null;

            // Create an RijndaelManaged object 
            // with the specified key and IV. 
            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for decryption. 
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream 
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return plaintext;

        }
        #endregion

        #region Key generation and log in 
        //example of what need to be done in login?
        public void LogIn()
        {
            //if getkeyfromcontainer("appname+userid") == "" *warning getkey will generate key so must check result and delete the key if it is empty*
            //genkey_saveincontainer -> save into db

            //might not need to generate new key pair as the containers method does generation too
            string containername = "DataAsGuard" + Logininfo.username +Logininfo.email;
            //Generate a public/private key pair.  
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            //Save the public key information to an RSAParameters structure.  
            RSAParameters RSAKeyInfo = RSA.ExportParameters(false);

            byte[] publickey = RSAKeyInfo.Modulus;
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String executeQuery = "INSERT INTO da_schema.KeyList(user_id,keyval,iv) VALUES (@userid,@key,@iv)";
                MySqlCommand myCommand = new MySqlCommand(executeQuery, con);
                myCommand.Parameters.AddWithValue("@userid", Logininfo.userid);
                myCommand.Parameters.AddWithValue("@key", Convert.ToBase64String(publickey));
                myCommand.Parameters.AddWithValue("@iv", Convert.ToBase64String(RSAKeyInfo.Exponent));
                myCommand.ExecuteNonQuery();
                con.Close();
            }
            
        }
        public static bool DoesKeyExists()
        {
            string containerName = "DataAsGuard" + Logininfo.username  + Logininfo.email; 
            var cspParams = new CspParameters
            {
                Flags = CspProviderFlags.UseExistingKey,
                KeyContainerName = containerName
            };

            try
            {
                var provider = new RSACryptoServiceProvider(cspParams);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public static void GenKey_SaveInContainer()
        {
            string ContainerName = "DataAsGuard" + Logininfo.username  +  Logininfo.email;
           
            // Create the CspParameters object and set the key container   
            // name used to store the RSA key pair.  
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = ContainerName;

            // Create a new instance of RSACryptoServiceProvider that accesses  
            // the key container MyKeyContainerName.  
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);
            RSAParameters rSAParameters = rsa.ExportParameters(false);
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String executeQuery = "INSERT INTO da_schema.KeyList (user_id,keyval,iv) VALUES (@userid,@key,@iv)";
                MySqlCommand myCommand = new MySqlCommand(executeQuery, con);
                myCommand.Parameters.AddWithValue("@userid", Logininfo.userid);
                myCommand.Parameters.AddWithValue("@key", Convert.ToBase64String(rSAParameters.Modulus));
                myCommand.Parameters.AddWithValue("@iv", Convert.ToBase64String(rSAParameters.Exponent));
                myCommand.ExecuteNonQuery();
                con.Close();
            }
            // Display the key information to the console.  
            Console.WriteLine("Key added to container: \n  {0}", rsa.ToXmlString(true));
        }

        public static RSAParameters GetKeyFromContainer()
        {
            string ContainerName = "DataAsGuard" + Logininfo.username + Logininfo.email;
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
            string ContainerName = "DataAsGuard" + Logininfo.username  + Logininfo.email;

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
            string ContainerName = "DataAsGuard" + Logininfo.username + Logininfo.email;

            // Create the CspParameters object and set the key container   
            // name used to store the RSA key pair.  
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = ContainerName;

            // Create a new instance of RSACryptoServiceProvider that accesses  
            // the key container.  
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            // Delete the key entry in the container.  
            rsa.PersistKeyInCsp = false;

            using(MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                String executeQuery = "Delete From da_schema.KeyList where keyval = @key";
                MySqlCommand myCommand = new MySqlCommand(executeQuery, con);
                
                myCommand.Parameters.AddWithValue("@key", Convert.ToBase64String(rsa.ExportParameters(false).Modulus));
                
                myCommand.ExecuteNonQuery();
                con.Close();
            }

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
            //string filesvalue = filesList.Text.ToString();
            //string searchfield = filesFilter.Text;
            //ArrayList fileid = new ArrayList();
            //if (dataFilesGrid.RowCount == 0)
            //{
            //    retrieveFiles();
            //}

            //get 10 by 10? next time
            //how to add ? richtextbox?
            richTextBox1.Clear();
            richTextBox1.ReadOnly = true;
            string userSelected = userList.Text.ToString();
            List<Message> messagelist = GetMessages(getIdoffullName(userSelected));
            username.Text = userSelected;
            Console.WriteLine("Messagecount:" + messagelist.Count);
            if (messagelist.Count != 0)
            {
                for (int i = 0; i < messagelist.Count(); i++)
                {
                    if (messagelist[i].Sender == Logininfo.userid)
                    {
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                        richTextBox1.AppendText( getNameOfId(Logininfo.userid) + ":" + Environment.NewLine + messagelist[i].MessageText);
                    }
                    else
                    {
                        //Label label = new Label();
                        //label.Location = new System.Drawing.Point(5, 5);
                        //label.Size = new System.Drawing.Size(110, 25);
                        //label.Text = messagelist[i].MessageText;
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                        //richTextBox1.Controls.Add(label);
                        //richTextBox1.SelectionColor = System.Drawing.Color.White;
                        //richTextBox1.SelectionBackColor = System.Drawing.Color.Blue;
                        richTextBox1.AppendText(username.Text + ":" + Environment.NewLine + messagelist[i].MessageText );

                    }
                    richTextBox1.AppendText(Environment.NewLine);
                }
            }
            richTextBox1.ScrollToCaret();
            //DisplayMessages.Controls.Add(new Label());
            //DisplayMessages.Controls.Add(orig_form);

        }
        

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            string message = ChatMessage.Text.ToString();
            SendMessage(getIdoffullName(username.Text), message);
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox1.AppendText(message);
            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.ScrollToCaret();
        }

        private void DisplayMessages_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewChat_Click(object sender, EventArgs e)
        {
            ChatRequest requestchat = new ChatRequest();
            requestchat.Show();
            Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Hide();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            Hide();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Profilesettings settings = new Profilesettings();
            settings.Show();
            Hide();
        }
    }
}
