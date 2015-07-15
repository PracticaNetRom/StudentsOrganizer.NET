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
    public class StudentsOperations
    {
        private string connectionString;

        public StudentsOperations(string connectionString)
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

            using (SqlConnection Con = new SqlConnection(connectionString))
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
            string updateString = "UPDATE STUDENTS SET First_Name = @firstName,Last_Name = @lastName, Gender=@gender, Birth_date=@birthDate, Email=@email, Phone_Numbers = @phoneNumber, Faculty = @faculty, Faculty_start_year = @facultyStart WHERE ID_Student = '" + stud.id + "'";

            using (SqlConnection Con = new SqlConnection(connectionString))
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


                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                Con.Close();

            }
        }
        public void DeleteStudents(int  id)
        {
            string deleteString = "DELETE FROM STUDENTS WHERE ID_Student = '" + id + "'";

            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                SqlCommand command = new SqlCommand(deleteString, Con);
                command.ExecuteNonQuery();
                Con.Close();

            }
        }

        public void EditStudents(int ID)
        {
            throw new NotImplementedException();
        }

        public Students GetStudent(int id)
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                Students stud = null;
                SqlCommand command = new SqlCommand("Select * from Students  where ID_Student=" + id, Con);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    stud = new Students();

                    stud.ID_Student = reader.GetInt32(reader.GetOrdinal("ID_Student"));
                   // stud.First_Name = reader.GetString(reader.GetOrdinal("First_Name"));
                    if (!reader.IsDBNull(reader.GetOrdinal("First_Name")))
                    {
                        stud.First_Name = reader.GetString(reader.GetOrdinal("First_Name"));
                    }

                  //  stud.Last_Name = reader.GetString(reader.GetOrdinal("Last_Name"));
                    if (!reader.IsDBNull(reader.GetOrdinal("Last_Name")))
                    {
                        stud.Last_Name = reader.GetString(reader.GetOrdinal("Last_Name"));
                    }


                  //  stud.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                    if (!reader.IsDBNull(reader.GetOrdinal("Gender")))
                    {
                        stud.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                    }

                    if (!reader.IsDBNull(reader.GetOrdinal("Birth_date")))
                    {
                        stud.Birth_date = reader.GetDateTime(reader.GetOrdinal("Birth_date"));
                    }
                  
                    if (!reader.IsDBNull(reader.GetOrdinal("Email")))
                    {
                        stud.Email = reader.GetString(reader.GetOrdinal("Email"));
                    }

                
                    if (!reader.IsDBNull(reader.GetOrdinal("Phone_Numbers")))
                    {
                        stud.Phone_Numbers = reader.GetString(reader.GetOrdinal("Phone_Numbers"));
                    }


                   // stud.Faculty = reader.GetString(reader.GetOrdinal("Faculty"));
                    if (!reader.IsDBNull(reader.GetOrdinal("Faculty")))
                    {
                        stud.Faculty = reader.GetString(reader.GetOrdinal("Faculty"));
                    }

                   // stud.Faculty_start_year = reader.GetString(reader.GetOrdinal("Faculty_start_year"));
                    if (!reader.IsDBNull(reader.GetOrdinal("Faculty_start_year")))

                    {
                        stud.Faculty_start_year = reader.GetString(reader.GetOrdinal("Faculty_start_year"));
                    }
                }
                Con.Close();
                return stud;
            }
        }
    }
}