using StudentOrg.Model.BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOrg.Model.DBO
{
    public class Event_TypesDBO
    {

        public string _connString;
        public Event_TypesDBO(string connString)
        {
            _connString = connString;

        }
        public void Insert(Event_Types type)
        {
            SqlConnection con = new SqlConnection(_connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Event_Types] ([Description] )values(" + type.Description + ")");



        }




        
    }
}
