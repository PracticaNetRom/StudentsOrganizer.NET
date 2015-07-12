using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using StudentOrganizer.Model.BO;

namespace StudentOrganizer.Model.DBOp
{
    public class EventTypesCommands
    {
        private string connectionString;
        private SqlConnection conn;

        public EventTypesCommands(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertEventTypes(EventTypes ev)
        {
            string insertString = "INSERT INTO EventTypes(Description) values(@description)";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(insertString, conn);

                command.Parameters.Add("@description", ev.Description);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void UpdateEventTypes(EventTypes ev)
        {
            string updateString = "UPDATE EventTypes SET Description = @description WHERE event.id = '" + ev.IdEvent + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(updateString, conn);
                command.Parameters.Add("@description", ev.Description);
                command.ExecuteNonQuery();

                conn.Close();
            }

        }

        public void DeleteEventTypes(EventTypes ev)
        {
            string deleteString = "DELETE FROM EventTypes WHERE id = '" + ev.IdEvent + "'";
            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(deleteString, conn);
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public List<EventTypes> GetEventTypes()
        {
          
            List<EventTypes> eventList = new List<EventTypes>();

            string selectString = "SELECT EventTypes.Description,EventTypes.id,Event.Period FROM EventTypes,Event where  EventTypes.id=Event.eventTypes_ID ";
            string period = null;

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(selectString, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        EventTypes ev = new EventTypes();
                        ev.Description = reader.GetString(reader.GetOrdinal("Description"));
                        ev.IdEvent = reader.GetInt32(reader.GetOrdinal("id"));
                        period = reader.GetDateTime(reader.GetOrdinal("Period")).ToString("dd/MM/yyy");
                        ev.Description = ev.Description + " " + period;
                        eventList.Add(ev);
                    }
                    reader.Close();
                }

                conn.Close();
            }

            return eventList;
        }

        public EventTypes SearchEventTypes(int evID)
        {
            EventTypes ev = new EventTypes();
            ev.IdEvent = evID;

            string searchString = "SELECT * FROM EventTypes where id = " + ev.IdEvent;
            
            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(searchString, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ev.Description = reader.GetString(reader.GetOrdinal("Description"));
                    }
                }

                conn.Close();
            }

            return ev;
        }
    }
}
