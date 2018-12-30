using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


// Calling the Database


//DbClass dbCon = new DbClass(); >> Declare DB Object

//List<string> dataDisplay = new List<string>(); >> Declare a List to store db object

//dataDisplay = dbCon.DbRetrieve(Table, Column); << Retrieve Data in this format



namespace DataAsGuard.DB
{
    public class DbClass
    {
        public List<string> DbRetrieve(string table, string username)
        {
            string queryString = "";
            string connString = "server=35.240.129.112;database=da_schema;uid=asguarduser;pwd=;";
            MySqlConnection cnn;
            MySqlCommand cmd;
            MySqlDataReader reader;

            queryString = "SELECT * FROM da_schema." + table + " WHERE username= '" + username + "'";


            cnn = new MySqlConnection(connString);
            cmd = new MySqlCommand(queryString, cnn)
            {
                CommandText = queryString
            };
            try
            {
                cnn.Open();
                List<string> storeData = new List<string>();
                reader = cmd.ExecuteReader();
                while (reader.HasRows && reader.Read())
                {
                    storeData.Add((reader["userid"].ToString()));
                    storeData.Add((reader["username"].ToString()));               
                    storeData.Add((reader["email"].ToString()));
                    if (table == "Userinfo")
                    {
                        storeData.Add((reader["password"].ToString()));
                        storeData.Add((reader["firstname"].ToString()));
                        storeData.Add((reader["lastname"].ToString()));
                        storeData.Add((reader["dob"].ToString()));
                        storeData.Add((reader["contact"].ToString()));
                    }
                }
                cnn.Close();
                reader.Close();
                return storeData;
            }
            catch (SqlException ex)
            {
                string errorMsg = "Error";
                errorMsg += ex.Message;
                throw new Exception(errorMsg);
            }
        }

    }
}
