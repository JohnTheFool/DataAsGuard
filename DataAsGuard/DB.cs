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
        public List<string> DbRetrieve(string table, string col)
        {

            string connString = "server=35.240.129.112;database=da_schema;uid=asguarduser;pwd=;";
            MySqlConnection cnn;
            MySqlCommand cmd;
            MySqlDataReader reader;
            string queryString = "SELECT " + col + " FROM da_schema." + table;
            cnn = new MySqlConnection(connString);
            cmd = new MySqlCommand(queryString, cnn)
            {
                CommandText = queryString
            };
            try
            {
                cnn.Open();
                reader = cmd.ExecuteReader();
                List<string> storeData = new List<string>();
                reader.Close();
                reader = cmd.ExecuteReader();
                while (reader.HasRows && reader.Read())
                {
                    storeData.Add((reader[col].ToString()));
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
