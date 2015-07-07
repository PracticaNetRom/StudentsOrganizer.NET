using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentOrganizer.Model.BO;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.IO;

namespace StudentOrganizer.Model.DBOp
{
    public class UserCommands
    {
        private string connectionString;
        private SqlConnection conn;

        public UserCommands(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int LogIn(User user) 
        {
            int count = 0;
            string selectString = "SELECT * FROM USER_Table WHERE userName = @userName and pass = @password";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(selectString, conn);
                command.Parameters.Add("@userName", user.UserName);
                command.Parameters.Add("@password", user.Password);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        count++;
                    }
                }
                conn.Close();
            }

            return count;
         }

        //functie pentru a obtine hash-ul pentru parola in format sha256 base 64
        public string Sha256Encrypt(string text)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA256Managed sha256hasher = new SHA256Managed();

            byte[] hashedDataBytes = sha256hasher.ComputeHash(encoder.GetBytes(text));

            String retValue = Convert.ToBase64String(hashedDataBytes);

            return retValue;
        }
    }
}
