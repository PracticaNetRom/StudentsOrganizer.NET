using StudentOrganizer.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOrganizerDBOp
{
    class Event_TypesCommands
    {
        private SqlConnection conn ;

        public Event_TypesCommands(SqlConnection connection) 
        {
            conn = connection;
        }

        public void InsertEvent(Event_Types ev) 
        {
            string insertString = "INSERT INTO EVENT_Types(Description) values(@param1)";
       
            SqlCommand command = new SqlCommand(insertString,conn);

            command.Parameters.Add("@param1", ev.Description);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
        }

        public void UpdateEvent(Event_Types ev) 
        {
            string updateString = "UPDATE EVENT_Types SET name = @Description WHERE event.id = '"+ev.Id+"'";

            SqlCommand command = new SqlCommand(updateString, conn);
            command.Parameters.Add("@description",ev.Description);
            command.ExecuteNonQuery();
            
        }

        public void DeleteEvent(Event ev) 
        {
            string deleteString = "DELETE FROM EVENT WHERE id = '"+ev.IdEvent+"'";

            SqlCommand command = new SqlCommand(deleteString, conn);
            command.ExecuteNonQuery();
        }

        public List<Event_Types> GetEvents() 
        {
            Event_Types ev = new Event_Types();
            List<Event_Types> eventList = new List<Event_Types>();

            string selectString = "SELECT * FROM EVENT ";

            SqlCommand command = new SqlCommand(selectString, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows) 
            {
                while (reader.Read())
                {
                    ev.Description = reader.GetString(reader.GetOrdinal("Description"));
                    ev.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    eventList.Add(ev);
                }
            }

            return eventList;
        }

        public Event_Types SearchEvent(int evID)
        {
            Event_Types ev = new Event_Types();
            ev.Id = evID;

            string searchString = "SELECT * FROM EVENT_Types where id = " +ev.Id;

            SqlCommand command = new SqlCommand(searchString, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ev.Description = reader.GetString(reader.GetOrdinal("Description"));
                }
            }

            return ev;
        }
    }
}
