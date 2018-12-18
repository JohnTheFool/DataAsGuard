using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

    public class AesEncryption
    {
        AesCryptoServiceProvider aes;
        string userbirthdate;

    public string Encryptstring(string encrypt_text, string userid)
    {
        using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
        {
            con.Open();
            string selectQuery = "SELECT * FROM Userinfo WHERE userid = @userid";
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            cmd.Parameters.AddWithValue("@userid", userid);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.HasRows && reader.Read())
            {
                userbirthdate = reader.GetString(reader.GetOrdinal("dob"));
                //MessageBox.Show(userbirthdate);
            }

            con.Close();
        }

        string key = Hash(userbirthdate);
        byte[] keyBytes;
        keyBytes = Encoding.Unicode.GetBytes(key);

        Rfc2898DeriveBytes derivedKey = new Rfc2898DeriveBytes(key, keyBytes);

        // AesCryptoServiceProvider
        aes = new AesCryptoServiceProvider();
        //aes.BlockSize = 128;
        //aes.KeySize = 256;
        aes.Key = derivedKey.GetBytes(aes.KeySize / 8);
        aes.IV = derivedKey.GetBytes(aes.BlockSize / 8);
        //aes.IV = Encoding.UTF8.GetBytes(AesIV256);
        //aes.Key = Encoding.UTF8.GetBytes(AesKey256);
        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.PKCS7;

        // encryption
        ICryptoTransform encrypt = aes.CreateEncryptor();
        byte[] dest = encrypt.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(encrypt_text), 0, encrypt_text.Length);
        string convertedString = Convert.ToBase64String(dest);

        return convertedString;
    }

    //encrypt without userid
    public string Encryptstring2(string encrypt_text, string userbirthdate)
    {

        string key = Hash(userbirthdate);
        byte[] keyBytes;
        keyBytes = Encoding.Unicode.GetBytes(key);

        Rfc2898DeriveBytes derivedKey = new Rfc2898DeriveBytes(key, keyBytes);

        // AesCryptoServiceProvider
        aes = new AesCryptoServiceProvider();
        //aes.BlockSize = 128;
        //aes.KeySize = 256;
        aes.Key = derivedKey.GetBytes(aes.KeySize / 8);
        aes.IV = derivedKey.GetBytes(aes.BlockSize / 8);
        //aes.IV = Encoding.UTF8.GetBytes(AesIV256);
        //aes.Key = Encoding.UTF8.GetBytes(AesKey256);
        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.PKCS7;

        // encryption
        ICryptoTransform encrypt = aes.CreateEncryptor();
        byte[] dest = encrypt.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(encrypt_text), 0, encrypt_text.Length);
        string convertedString = Convert.ToBase64String(dest);

        return convertedString;
    }

    public string Decryptstring(string cipher_text, string userid)
    {
        
        using (MySqlConnection con = new MySqlConnection("server = 35.240.129.112; user id = asguarduser; database = da_schema"))
        {
            con.Open();
            string selectQuery = "SELECT * FROM Userinfo WHERE userid = @userid";
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            cmd.Parameters.AddWithValue("@userid", userid);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.HasRows && reader.Read())
            {
                userbirthdate = reader.GetString(reader.GetOrdinal("dob"));
                //MessageBox.Show(userbirthdate);
            }

            con.Close();
        }

        string key = Hash(userbirthdate);
        byte[] keyBytes;
        keyBytes = Encoding.Unicode.GetBytes(key);

        Rfc2898DeriveBytes derivedKey = new Rfc2898DeriveBytes(key, keyBytes);

        // AesCryptoServiceProvider
        aes = new AesCryptoServiceProvider();
        //aes.BlockSize = 128;
        //aes.KeySize = 256;
        aes.Key = derivedKey.GetBytes(aes.KeySize / 8);
        aes.IV = derivedKey.GetBytes(aes.BlockSize / 8);
        //aes.IV = Encoding.UTF8.GetBytes(AesIV256);
        //aes.Key = Encoding.UTF8.GetBytes(AesKey256);
        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.PKCS7;

        // encryption
        ICryptoTransform transform = aes.CreateDecryptor();
        byte[] encrypted_bytes = Convert.FromBase64String(cipher_text);
        byte[] decrypted = transform.TransformFinalBlock(encrypted_bytes, 0, encrypted_bytes.Length);
        string convertedString = ASCIIEncoding.ASCII.GetString(decrypted);

        return convertedString;
    }

    static string Hash(string input)
    {
        using (SHA256Managed sha256 = new SHA256Managed())
        {
            var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sb = new StringBuilder(hash.Length * 2);

            foreach (byte b in hash)
            {
                // can be "x2" if you want lowercase
                sb.Append(b.ToString("X2"));
            }

            return sb.ToString();
        }
    }
}
