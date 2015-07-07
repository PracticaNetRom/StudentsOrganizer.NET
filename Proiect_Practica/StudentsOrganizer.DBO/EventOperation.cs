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
            string InsertString = "INSERT INTO Event(Name) values(@param1)";
       
            SqlCommand command = new SqlCommand(InsertString,Con);

            command.Parameters.Add("@param1", ev.Name);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
        }
        public void UpdateEvent(Event ev)
        {
            string updateString = "UPDATE EVENT SET name = @name WHERE event.id = '" + ev.ID_Event + "'";

            SqlCommand command = new SqlCommand(updateString, Con);
            command.Parameters.Add("@name", ev.Name);
            command.ExecuteNonQuery();

        }
        public void DeleteEvent(Event ev)
        {
            string deleteString = "DELETE FROM EVENT WHERE id = '" + ev.ID_Event + "'";

            SqlCommand command = new SqlCommand(deleteString, Con);
            command.ExecuteNonQuery();
        }

    }
}
