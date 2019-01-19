using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAsGuard.CSClass
{
    public abstract class LogClass
    {
        public abstract void Log(string message,string logtype, string userid, string email);
        public abstract void fileLog(string message, string logtype, string userid, string email, string fileID);
    }
    //Log types:
    //SystemError: Indicate system errors log
    //Registration: Indicate User Registeration
    //Error: Indicate failures In General
    //LogonFailure: Indicate Faillure to login
    //LogonSuccess: Indicate Successful Logon
    //Accounts: Indicate Account Changes
    //UploadsFailed : Indicate failed Upload
    //UploadsSuccess : Indicate Successful Uploads
    //FileChanges : Indicate File History changes
    //GroupChanges : Indicate changes to groups
    //Permissions : Indicate changes to permissions

    public class DBLogger : LogClass
    {
        
        public override void Log(string message, string logtype, string userid, string email)
        {
            //Code to log data to the database
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                string queryStr = "INSERT into logInfo(logInfo, logtype, logdatetime, userid, email) values (@logInfo, @logtype, @logdatetime, @userid, @email) ";
                //String query = "INSERT into Userinfo(username, password, email, firstname, lastname, dob, contact) values(@userName, @hashedPassword, @email, @firstName, @Lastname, @DOB, @contact)";
                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, con);
                cmd.Parameters.AddWithValue("@logInfo", message);
                cmd.Parameters.AddWithValue("@logtype", logtype);
                cmd.Parameters.AddWithValue("@logdatetime", DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm:ss"));
                //cmd.Parameters.AddWithValue("@logdatetime", DateTime.Now);
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteReader();
                con.Close();
            }
        }

        //meant for log of files
        public override void fileLog(string message, string logtype, string userid, string email, string fileID)
        {
            //Code to log data to the database
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                string queryStr = "INSERT into logInfo(logInfo, logtype, logdatetime, userid, email, fileID) values (@logInfo, @logtype, @logdatetime, @userid, @email, @fileID) ";
                //String query = "INSERT into Userinfo(username, password, email, firstname, lastname, dob, contact) values(@userName, @hashedPassword, @email, @firstName, @Lastname, @DOB, @contact)";
                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, con);
                cmd.Parameters.AddWithValue("@logInfo", message);
                cmd.Parameters.AddWithValue("@logtype", logtype);
                cmd.Parameters.AddWithValue("@logdatetime", DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm:ss"));
                //cmd.Parameters.AddWithValue("@logdatetime", DateTime.Now);
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@fileID", fileID);
                cmd.ExecuteReader();
                con.Close();
            }
        }
    }


}
