using MODEL.BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Organizer.Model.DBOp
{
    public class StudentsDBOp
    {
        private SqlConnection connection;
        public StudentsDBOp(string ConnectionString)
        {
            connection = new SqlConnection(ConnectionString);
            
        }

        public StudentsDBOp()
        {
            // TODO: Complete member initialization
        }
        public List<StudentsBO>  GetStudents()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT FirstName FROM Students";
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            
            List<StudentsDBOp> StudentList = new List<StudentsDBOp>();
    
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    StudentsDBOp stud = new StudentsDBOp();
                    stud.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));

                    reader.GetInt32(reader.GetOrdinal("ID");
                }
            }
        }
    }

}
