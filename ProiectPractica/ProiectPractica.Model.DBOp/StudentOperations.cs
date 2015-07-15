using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPractica.Model.DBOp
{
    public class StudentOperations
    {
        private SqlConnection con;
        private string connectionString;

        public StudentOperations(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertStudent(Student stud)
        {

            string InsertString = "Insert Into Student(FName, LName, Gender, Birthdate, Email, PhoneNumbers, Faculty, FacultyStartYear) values (@FName, @LName, @Gender, @Birthdate, @Email, @PhoneNumbers, @Faculty, @FStartYear)";

            using (con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(InsertString, con);

                command.Parameters.Add("@FName", stud.FName);
                command.Parameters.Add("@LName", stud.LName);
                command.Parameters.Add("@Gender", stud.Gender);
                if (stud.Birthdate.HasValue)
                {
                    command.Parameters.Add("@Birthdate", stud.Birthdate.Value);
                }
                else 
                {
                    command.Parameters.Add("@Birthdate", DBNull.Value);
                    
                }
                command.Parameters.Add("@Email", stud.Email);
                command.Parameters.Add("@PhoneNumbers", stud.PhoneNumbers);
                command.Parameters.Add("@Faculty", stud.Faculty);
                command.Parameters.Add("@FStartYear", stud.FacultyStartYear);

                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteStudent(int id)
        {

            string DeleteString = "Delete From Student Where id_student = " + id;

            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(DeleteString, con);
                command.ExecuteNonQuery();
                con.Close();
            }
        }

        public void UpdateStudent(Student stud)
        {

            string UpdateString = "Update Student SET FName=@FName, LName=@LName, Gender=@Gender, Birthdate=@Birthdate, Email=@Email, PhoneNumbers=@PhoneNumbers, Faculty=@Faculty, FacultyStartYear=@FacultyStartYear WHERE id_student= " + stud.id_student;
            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(UpdateString, con);
                command.Parameters.Add("@FName", stud.FName);
                command.Parameters.Add("@LName", stud.LName);
                command.Parameters.Add("@Gender", stud.Gender);
                command.Parameters.Add("@Birthdate", stud.Birthdate);
                command.Parameters.Add("@Email", stud.Email);
                command.Parameters.Add("@PhoneNumbers", stud.PhoneNumbers);
                command.Parameters.Add("@Faculty", stud.Faculty);
                command.Parameters.Add("@FacultyStartYear", stud.FacultyStartYear);

                command.ExecuteNonQuery();
                con.Close();
            }
        }

        public Student GetStudent(int id) {

            Student stud =  null;
            string GetString = "Select * From Student Where id_student= " + id;
            using (con = new SqlConnection(connectionString)) {
                con.Open();
                SqlCommand command = new SqlCommand(GetString, con);
                //command.Parameters.Add("@FName", stud.FName);
                //command.Parameters.Add("@LName", stud.LName);
                //command.Parameters.Add("@Gender", stud.Gender);
                //command.Parameters.Add("@Birthdate", stud.Birthdate);
                //command.Parameters.Add("@Email", stud.Email);
                //command.Parameters.Add("@PhoneNumbers", stud.PhoneNumbers);
                //command.Parameters.Add("@Faculty", stud.Faculty);
                //command.Parameters.Add("@FStartYear", stud.FacultyStartYear);
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    stud = new Student();
                    stud.id_student = reader.GetInt32(reader.GetOrdinal("id_student"));
                    stud.FName = reader.GetString(reader.GetOrdinal("Fname"));
                    stud.LName = reader.GetString(reader.GetOrdinal("Lname")); ;
                    stud.Gender = reader.GetString(reader.GetOrdinal("Gender")); ;
                    if (!reader.IsDBNull(reader.GetOrdinal("Birthdate"))) 
                    {
                        stud.Birthdate = reader.GetDateTime(reader.GetOrdinal("Birthdate"));
                    }
                    stud.Email = reader.GetString(reader.GetOrdinal("Email"));
                    stud.PhoneNumbers = reader.GetString(reader.GetOrdinal("PhoneNumbers"));
                    stud.Faculty = reader.GetString(reader.GetOrdinal("Faculty"));
                    stud.FacultyStartYear = reader.GetString(reader.GetOrdinal("FacultyStartYear")); 
                }

                
                con.Close();
            }
            return stud;
        }
    }
}
