using StudentOrganizer.BO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOrganizerDBOp
{
    
    public class EventCommands
    {
        private SqlConnection conn ;

        public EventCommands(SqlConnection connection) 
        {
            conn = connection;
        }

        public void InsertEvent(Event ev) 
        {
            string insertString = "INSERT INTO EVENT(NAME) values(@param1)";
       
            SqlCommand command = new SqlCommand(insertString,conn);

            command.Parameters.Add("@param1", ev.Name);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
        }

        public void UpdateEvent(Event ev) 
        {
            string updateString = "UPDATE EVENT SET name = @name WHERE event.id = '"+ev.IdEvent+"'";

            SqlCommand command = new SqlCommand(updateString, conn);
            command.Parameters.Add("@name",ev.Name);
            command.ExecuteNonQuery();
            
        }

        public void DeleteEvent(Event ev) 
        {
            string deleteString = "DELETE FROM EVENT WHERE id = '"+ev.IdEvent+"'";

            SqlCommand command = new SqlCommand(deleteString, conn);
            command.ExecuteNonQuery();
        }

        public ArrayList GetEvents() 
        {
            Event ev = new Event();
            ArrayList eventList = new ArrayList();

            string selectString = "SELECT * FROM EVENT ";

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

            return eventList;
        }

        public Event SearchEvent(int evID)
        {
            Event ev = new Event();
            ev.IdEvent = evID;

            string searchString = "SELECT * FROM EVENT where id = " +ev.IdEvent;

            SqlCommand command = new SqlCommand(searchString, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ev.Name = reader.GetString(reader.GetOrdinal("Name"));
                }
            }

            return ev;
        }

    }
}
