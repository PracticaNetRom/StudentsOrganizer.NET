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
    public class EventCommands
    {
        private string connectionString;
        private SqlConnection conn;

        public EventCommands(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertEvent(Event ev)
        {
            string insertString = "INSERT INTO EVENT(NAME) values(@name)";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(insertString, conn);

                command.Parameters.Add("@name", ev.Name);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void UpdateEvent(Event ev)
        {
            string updateString = "UPDATE EVENT SET name = @name WHERE event.id = '" + ev.IdEvent + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(updateString, conn);
                command.Parameters.Add("@name", ev.Name);
                command.ExecuteNonQuery();

                conn.Close();
            }

        }

        public void DeleteEvent(Event ev)
        {
            string deleteString = "DELETE FROM EVENT WHERE id = '" + ev.IdEvent + "'";
            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(deleteString, conn);
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public List<Event> GetEvents()
        {
            Event ev = new Event();
            List<Event> eventList = new List<Event>();

            string selectString = "SELECT * FROM EVENT ";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(selectString, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ev.Name = reader.GetString(reader.GetOrdinal("Name"));
                        ev.IdEvent = reader.GetInt32(reader.GetOrdinal("id"));
                        eventList.Add(ev);
                    }
                }

                conn.Close();
            }

            return eventList;
        }

        public Event SearchEvent(int evID)
        {
            Event ev = new Event();
            ev.IdEvent = evID;

            string searchString = "SELECT * FROM EVENT where id = " + ev.IdEvent;
            
            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(searchString, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ev.Name = reader.GetString(reader.GetOrdinal("Name"));
                    }
                }

                conn.Close();
            }

            return ev;
        }
    }
}
