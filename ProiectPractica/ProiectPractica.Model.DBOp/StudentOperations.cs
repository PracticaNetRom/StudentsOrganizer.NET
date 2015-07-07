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

            string InsertString = "Insert Into Student(FName, LName, Gender, Birthdate, Email, PhoneNumbers, Faculty, FacultyStartYear) values (@FName, @LName, @Gender, @Birthdate, @PhoneNumbers, @Faculty, @FacultyStartYear)";

            using (con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(InsertString, con);

                command.Parameters.Add("@FName", stud.FName);
                command.Parameters.Add("@LName", stud.LName);
                command.Parameters.Add("@Gender", stud.Gender);
                command.Parameters.Add("@Birthdate", stud.Birthdate);
                command.Parameters.Add("@Email", stud.Email);
                command.Parameters.Add("@PhoneNumbers", stud.PhoneNumbers);
                command.Parameters.Add("@Faculty", stud.Faculty);
                command.Parameters.Add("@FStartYear", stud.FacultyStartYear);

                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteStudent(Student stud)
        {

            string DeleteString = "Delete From Student Where idstudent = " + stud.idstudent;

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

            string UpdateString = "Update Into Student(FName, LName, Gender, Birthdate, Email, PhoneNumbers, Faculty, FacultyStartYear) values (@FName, @LName, @Gender, @Birthdate, @PhoneNumbers, @Faculty, @FacultyStartYear)";
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
                command.Parameters.Add("@FStartYear", stud.FacultyStartYear);

                command.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
