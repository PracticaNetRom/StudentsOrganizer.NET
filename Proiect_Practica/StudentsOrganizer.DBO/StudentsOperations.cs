using StudentsOrganizerModel.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsOrganizer.DBO
{
    public class StudentCommands
    {
        private SqlConnection Con;
        private string connectionString;

        public StudentCommands(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertStudent(Students stud)
        {
            string insertString = @"INSERT INTO STUDENT(
                                        FirstName,
                                        LastName,
                                        Gender,
                                        BirthDate,
                                        Email,
                                        PhoneNumber,
            Faculty,FacultyStartYear) values(@firstName,@lastName,@gender,@birthDate,@email,@phoneNumber,@faculty,@facultyStart)";

            using (Con = new SqlConnection(connectionString))
            {
                Con.Open();

                SqlCommand command = new SqlCommand(insertString, Con);

                command.Parameters.Add("@firstName", stud.First_Name);
                command.Parameters.Add("@lastName", stud.Last_Name);
                command.Parameters.Add("@gender", stud.Gender);
                command.Parameters.Add("@birthDate", stud.Birth_date);
                command.Parameters.Add("@email", stud.Email);
                command.Parameters.Add("@phoneNumber", stud.Phone_Numbers);
                command.Parameters.Add("@faculty", stud.Faculty);
                command.Parameters.Add("@facultyStart", stud.Male);
                command.CommandType = CommandType.Text;

                command.ExecuteNonQuery();
                Con.Close();
            }
        }
        public void UpdateStudent(Students stud)
        {
            string updateString = "UPDATE STUDENT SET FirstName = @firstName,LastName = @lastName, Gender=@gender, BirthDate=@birthDate, Email=@email, PhoneNumber = @phoneNumber, Faculty = @faculty, FacultyStartYear = @facultyStart WHERE student.id = '" + stud.id + "'";

            using (Con = new SqlConnection(connectionString))
            {
                Con.Open();
                SqlCommand command = new SqlCommand(updateString, Con);

                command.Parameters.Add("@firstName", stud.First_Name);
                command.Parameters.Add("@lastName", stud.Last_Name);
                command.Parameters.Add("@gender", stud.Gender);
                command.Parameters.Add("@birthDate", stud.Birth_date);
                command.Parameters.Add("@email", stud.Email);
                command.Parameters.Add("@phoneNumber", stud.Phone_Numbers);
                command.Parameters.Add("@faculty", stud.Faculty);
                command.Parameters.Add("@facultyStart", stud.Male);
                command.ExecuteNonQuery();

                Con.Close();

            }
        }
        public void DeleteStudent(Students stud)
        {
            string deleteString = "DELETE FROM Student WHERE id = '" + stud.id + "'";

            using (Con = new SqlConnection(connectionString))
            {
                Con.Open();
                SqlCommand command = new SqlCommand(deleteString, Con);
                command.ExecuteNonQuery();
                Con.Close();

            }
        }
    }
}