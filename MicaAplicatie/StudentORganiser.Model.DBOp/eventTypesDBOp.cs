using StudentOrganiser.Model.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentORganiser.Model.DBOp
{
    public class EventTypesDBOP
    {
        private string connectionString;
        private SqlConnection conn;

        public EventTypesDBOP(string connectionString)
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
            string updateString = "UPDATE EventTypes SET Description = @description WHERE event.id = '" + ev.IDEvent + "'";

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
            string deleteString = "DELETE FROM EventTypes WHERE id = '" + ev.IDEvent + "'";
            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(deleteString, conn);
                command.ExecuteNonQuery();

                conn.Close();
            }
        }


        public EventTypes SearchEventTypes(int evID)
        {
            EventTypes ev = new EventTypes();
            ev.IDEvent = evID;

            string searchString = "SELECT * FROM EventTypes where id = " + ev.IDEvent;

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


        public List<EventTypes> GetEventTypes()
        {

            List<EventTypes> eventList = new List<EventTypes>();

            string selectString = "SELECT * FROM EventTypes ";

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
                        ev.IDEvent = reader.GetInt32(reader.GetOrdinal("id"));
                        eventList.Add(ev);
                    }

                }

                conn.Close();
            }

            return eventList;
        }
    }
}
