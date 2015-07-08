using ProiectPractica.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPractica.Model.DBOp
{
    public class EventTypesOperations
    {
         SqlConnection con; 
        
        public EventTypesOperations(SqlConnection connection) 
        {
            con = connection;
        }

        public void InsertEventTypes(EventTypes evt) {

            string InsertString = "Insert Into EventTypes (Description) values (@Description)";
            
            SqlCommand command = new SqlCommand(InsertString, con);

            command.Parameters.Add("@Description", evt.Description);
            
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();

        }

        public void DeleteEventTypes(EventTypes evt) {
            string DeleteString = "DELETE From EventTypes Where Event_Type_id =" + evt.Event_Type_id;
            SqlCommand command = new SqlCommand(DeleteString, con);
            command.ExecuteNonQuery();

        }

        public void UpdateEvent(EventTypes evt)
        {
            string UpdateString = "UPDATE EventTypes Set Description = @Description Where Event_Type_id =" + evt.Event_Type_id;

            SqlCommand command = new SqlCommand(UpdateString, con);
            command.Parameters.Add("@Description", evt.Description);
          
            command.ExecuteNonQuery();

        }
    }
}
