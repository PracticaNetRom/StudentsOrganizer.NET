using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnection.Model
{
    class StudentCommands
    {
        private SqlConnection conn;

        public StudentCommands(SqlConnection conn) 
        {
            this.conn = conn;
        }

        public void insertStudent(Student stud)
        {
            string insertString = "INSERT INTO STUDENT(FirstName,LastName,Gender,BirthDate,Email,PhoneNumber,Faculty,FacultyStartYear) values(@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8)";

            SqlCommand command = new SqlCommand(insertString, conn);

            command.Parameters.Add("@param1", stud.FirstName);
            command.Parameters.Add("@param2", stud.LastName);
            command.Parameters.Add("@param3", stud.Gender);
            command.Parameters.Add("@param4", stud.BirthDate);
            command.Parameters.Add("@param5", stud.Email);
            command.Parameters.Add("@param6", stud.PhoneNumber);
            command.Parameters.Add("@param7", stud.Faculty);
            command.Parameters.Add("@param8", stud.FacultyStartYear);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
        }

        public void updateStudent(Student stud)
        {
            string updateString = "UPDATE STUDENT SET FirstName = '"+stud.FirstName+"' WHERE student.id = '" + stud.Id + "'";

            SqlCommand command= new SqlCommand(updateString, conn);
           // command.Parameters.Add("@param1", stud.Id);
           // command.Parameters.Add("@param2", stud.FirstName);
           // command.Parameters.Add("@param3", stud.LastName);
           // command.Parameters.Add("@param4", stud.Gender);
           // command.Parameters.Add("@param5", stud.BirthDate);
           // command.Parameters.Add("@param6", stud.Email);
           // command.Parameters.Add("@param7", stud.PhoneNumber);
           // command.Parameters.Add("@param8", stud.Faculty);
           // command.Parameters.Add("@param9", stud.FacultyStartYear);
            command.ExecuteNonQuery();

            updateString = "UPDATE STUDENT SET LastName = '" + stud.LastName + "' WHERE student.id = '" + stud.Id + "'";
            command = new SqlCommand(updateString, conn);
            command.ExecuteNonQuery();

            updateString = "UPDATE STUDENT SET Gender = '" + stud.Gender + "' WHERE student.id = '" + stud.Id + "'";
            command = new SqlCommand(updateString, conn);
            command.ExecuteNonQuery();

            updateString = "UPDATE STUDENT SET BirthDate = '" + stud.BirthDate + "' WHERE student.id = '" + stud.Id + "'";
            command = new SqlCommand(updateString, conn);
            command.ExecuteNonQuery();

            updateString = "UPDATE STUDENT SET Email = '" + stud.Email + "' WHERE student.id = '" + stud.Id + "'";
            command = new SqlCommand(updateString, conn);
            command.ExecuteNonQuery();

            updateString = "UPDATE STUDENT SET PhoneNumber = '" + stud.PhoneNumber + "' WHERE student.id = '" + stud.Id + "'";
            command = new SqlCommand(updateString, conn);
            command.ExecuteNonQuery();

            updateString = "UPDATE STUDENT SET Faculty = '" + stud.Faculty + "' WHERE student.id = '" + stud.Id + "'";
            command = new SqlCommand(updateString, conn);
            command.ExecuteNonQuery();

            updateString = "UPDATE STUDENT SET FacultyStartYear = '" + stud.FacultyStartYear + "' WHERE student.id = '" + stud.Id + "'";
            command = new SqlCommand(updateString, conn);
            command.ExecuteNonQuery();
        }

        public void deleteStudent(Student stud)
        {
            string deleteString = "DELETE FROM Student WHERE id = '" + stud.Id + "'";

            SqlCommand command = new SqlCommand(deleteString, conn);
            command.ExecuteNonQuery();
        }

        public Student searchStudent(int studID)
        {
            Student student = new Student();
            student.Id = studID;

            string searchString = "SELECT * FROM student where id = " + student.Id;

            SqlCommand command = new SqlCommand(searchString, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    student.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                    student.LastName = reader.GetString(reader.GetOrdinal("LastName"));
                    student.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                    student.BirthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate"));
                    student.Email = reader.GetString(reader.GetOrdinal("Email"));
                    student.PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                    student.Faculty = reader.GetString(reader.GetOrdinal("Faculty"));
                    student.FacultyStartYear = reader.GetInt32(reader.GetOrdinal("FacultyStartYear"));
                }
                reader.Close();
            }
            
            return student;
        }
    }
}
