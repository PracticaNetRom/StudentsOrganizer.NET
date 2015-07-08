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
   public  class EventOperation
    {
       private SqlConnection Con ;
       private string InsertString;

        public EventOperation(SqlConnection connection) 
        {
            Con = connection;
        }

        public void InsertEvent(Event ev) 
        {
          
            string insertString = "INSERT INTO EVENT(ID,Period,Departament,Tasks,Remarks) values(@param1)";
       
            SqlCommand command = new SqlCommand(InsertString,Con);

            command.Parameters.Add("@param1", ev.Name);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
        }
        public void UpdateEvent(Event ev)
        {
            string updateString = "UPDATE Event SET name = @name WHERE Event.ID = '" + ev.ID_Event + "'";

            SqlCommand command = new SqlCommand(updateString, Con);
            command.Parameters.Add("@name", ev.Name);
            command.ExecuteNonQuery();

        }
        public void DeleteEvent(Event ev)
        {
            string deleteString = "DELETE FROM EVENT WHERE ID = '" + ev.ID_Event + "'";

            SqlCommand command = new SqlCommand(deleteString, Con);
            command.ExecuteNonQuery();
        }

    }
}
