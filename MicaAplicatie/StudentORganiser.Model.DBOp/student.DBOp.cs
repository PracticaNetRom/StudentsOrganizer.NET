using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using StudentOrganiser.Model.BO;

namespace StudentORganiser.Model.DBOp
{
    public class StudentOperations
    {
        private SqlConnection _connection;
        public StudentOperations(string ConnectionString)
        {
            _connection = new SqlConnection(ConnectionString);
        }
        public List<Student> GetStudents()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "select firstName from student";
            command.Connection = _connection;
            _connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Student> studentList = new List<Student>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Student stud = new Student();
                    stud.FirstName = reader.GetString(reader.GetOrdinal("firstName"));
                    studentList.Add(stud);
                }
                
                
            }

            return studentList;
        }
    }
}
