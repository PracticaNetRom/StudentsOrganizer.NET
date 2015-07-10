using StudentOrg.Model.BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOrg.Model.DBO
{
    public class StudentsDBO
    {
        private string _connString;
        public StudentsDBO(string connString)
        {
            _conString = connString;
        }
        public void Insert(Student student)
        {
            SqlConnection con = new SqlConnection(_conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Students] ([FirstName], [LastName], [Gender], [BirthDate], [Faculty], [FacultyStartYear]) values("+ student.FirstName + "','" + student.LastName + "','" + student.Gender + "','" + student.BirthDate + "','" + student.Faculty + "','" + student.FacultyStartYear + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public string _conString { get; set; }
    }
}
