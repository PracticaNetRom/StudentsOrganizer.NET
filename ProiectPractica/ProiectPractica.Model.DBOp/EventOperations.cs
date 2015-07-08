using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPractica.Model.DBOp
{
    public class EventOperations
    {
        SqlConnection con; 
        
        public EventOperations(SqlConnection connection) 
        {
            con = connection;
        }

        public void InsertEvent(Event ev) {

            string InsertString = "Insert Into Event (Period, Department, Tasks, Remarks, Event_Type_id ) values (@Period, @Deparment, @Tasks, @Remarks, @Event_Type_id )";
            
            SqlCommand command = new SqlCommand(InsertString, con);

            command.Parameters.Add("@Period", ev.Period);
            command.Parameters.Add("@Department", ev.Department);
            command.Parameters.Add("@Tasks", ev.Tasks);
            command.Parameters.Add("@Remarks", ev.Remarks);
            command.Parameters.Add("@ Event_Type_id", ev.Event_Type_id);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();

        }

        public void DeleteEvent(Event ev) {
            string DeleteString = "DELETE From Event Where id_event = '" + ev.id_event + "'";
            SqlCommand command = new SqlCommand(DeleteString, con);
            command.ExecuteNonQuery();

        }

        public void UpdateEvent(Event ev)
        {
            string UpdateString = "UPDATE Event Set Period = @Period, Department= @Department, Tasks=@Tasks, Remarks=@Remarks, Event_Type_id=@ Event_Type_id  Where id_event = '" + ev.id_event + "'";

            SqlCommand command = new SqlCommand(UpdateString, con);
            command.Parameters.Add("@Period", ev.Period);
            command.Parameters.Add("@Department", ev.Department);
            command.Parameters.Add("@Tasks", ev.Tasks);
            command.Parameters.Add("@Remarks", ev.Remarks);
            command.Parameters.Add("@Event_Type_id", ev.Event_Type_id);
            command.ExecuteNonQuery();

        }
    }
}
