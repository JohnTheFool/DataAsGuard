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
        public abstract void Log(string message,string logtype, string userid, string username);
    }
    //Log types:
    //SystemError: Indicate system errors log
    //Registration: Indicate User Registeration
    //Error: Indicate failures In General
    //LogonFailure: Indicate Faillure to login
    //LogonSuccess: Indicate Successful Logon

    public class DBLogger : LogClass
    {
        
        public override void Log(string message, string logtype, string userid, string username)
        {
            //Code to log data to the database
            using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
            {
                con.Open();
                string queryStr = "INSERT into logInfo(logInfo, logtype, logdatetime, userid, username) values (@logInfo, @logtype, @logdatetime, @userid, @username) ";
                //String query = "INSERT into Userinfo(username, password, email, firstname, lastname, dob, contact) values(@userName, @hashedPassword, @email, @firstName, @Lastname, @DOB, @contact)";
                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, con);
                cmd.Parameters.AddWithValue("@logInfo", message);
                cmd.Parameters.AddWithValue("@logtype", logtype);
                cmd.Parameters.AddWithValue("@logdatetime", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                if(Logininfo.userid == "admin")
                {
                    cmd.Parameters.AddWithValue("@userid", 0);
                }
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteReader();
                con.Close();
            }
        }
    }


}
