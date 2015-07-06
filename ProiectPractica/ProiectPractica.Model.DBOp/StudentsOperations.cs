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
        SqlConnection con;

        public StudentOperations(SqlConnection con) 
        {
            this.con = con;
        }

        public void InsertStudent(Student stud) {
           
            string InsertString = "Insert Into Student(FName, LName, Gender, Birthdate, Email, PhoneNumbers, Faculty, FacultyStartYear) values (@FName, @LName, @Gender, @Birthdate, @PhoneNumbers, @Faculty, @FacultyStartYear)";
            
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
    }

        public void DeleteStudent(Student stud) { 

            string DeleteString = "Delete From Student Where idstudent = " + stud.idstudent;

            SqlCommand command = new SqlCommand(DeleteString, con);
           
            command.ExecuteNonQuery();
        }



    }
}
