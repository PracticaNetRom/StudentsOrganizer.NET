using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPractica.Model.DBOp
{
    class EventOperations
    {
        SqlConnection con; 
        
        public EventOperations(SqlConnection connection) 
        {
            con = connection;
        }

        public void InsertEvent(Event ev) {
            
            string InsertString = "Insert Into Event (name_event) values (@name_event)";
            
            SqlCommand command = new SqlCommand(InsertString, con);

            command.Parameters.Add("@param1", ev.name_event);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();

        }

        public void DeleteEvent(Event ev) {
            string DeleteString = "DELETE From Event Where id = '" + ev.id_event + "'";
            SqlCommand command = new SqlCommand(DeleteString, con);
            command.ExecuteNonQuery();

        }

        public void UpdateEvent(Event ev)
        {
            string UpdateString = "UPDATE Event Set name = @name Where event.id = '" + ev.id_event + "'";

            SqlCommand command = new SqlCommand(UpdateString, con);
            command.Parameters.Add("@name", ev.name_event);
            command.ExecuteNonQuery();

        }
    }
}
