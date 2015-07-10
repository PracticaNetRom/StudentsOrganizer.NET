using StudentOrganiser.Model.BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentORganiser.Model.DBOp
{
    public class UserDBOP
    {
        private string connectionString;
        private SqlConnection conn;

        public UserDBOP(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int LogIn(UserBO user) 
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

    }
}
