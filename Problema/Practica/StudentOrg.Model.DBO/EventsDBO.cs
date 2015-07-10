using StudentOrg.Model.BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOrg.Model.DBO
{
    public class EventsDBO
    {
        private string _conString;
        public EventsDBO(string connString)
        {
            _conString = conString;
        }
        public void Insert(Events even)
        {
            SqlConnection con = new SqlConnection(_conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Events] ([Perioada], [Departament], [Task], [Remarks], [EventTypeID]) values(" + even.Perioada + "','" + even.Departament + "','" + even.Task+ "','" + even.Remarks + "','" + even.EventTypeID+ "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public string conString { get; set; }
    }
}
