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
            //string insertString = "INSERT INTO EVENT(NAME) values(@param1)";
            string insertString = @"INSERT INTO EVENT (
                                                 Period
                                                 Department
                                                 Task
                                                 Remarks)
                                               values(@period,@Department,@Task,@Remarks)";

            SqlCommand command = new SqlCommand(insertString,conn);

            command.Parameters.Add("@period", ev.Period);
            command.Parameters.Add("@Department", ev.Department);
            command.Parameters.Add("@Task", ev.Task);
            command.Parameters.Add("@Remarks", ev.Remarks);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
        }

        public void UpdateEvent(Event ev) 
        {
            string updateString = "UPDATE EVENT SET Period = @Period, Department = @Department, Task = @Task WHERE event.id = '"+ev.IdEvent+"'";

            SqlCommand command = new SqlCommand(updateString, conn);
            command.Parameters.Add("@Period",ev.Period);
            command.Parameters.Add("@Department", ev.Department);
            command.Parameters.Add("@Task", ev.Task);
            command.Parameters.Add("@Remarks", ev.Remarks);

            command.ExecuteNonQuery();
            
        }

        public void DeleteEvent(Event ev) 
        {
            string deleteString = "DELETE FROM EVENT WHERE id = '"+ev.IdEvent+"'";

            SqlCommand command = new SqlCommand(deleteString, conn);
            command.ExecuteNonQuery();
        }

        public List<Event> GetEvents() 
        {
            Event ev = new Event();
            List<Event> eventList = new List<Event>();

            string selectString = "SELECT * FROM EVENT ";

            SqlCommand command = new SqlCommand(selectString, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows) 
            {
                while (reader.Read())
                {
                    ev.IdEvent = reader.GetInt32(reader.GetOrdinal("id"));
                    ev.Period = reader.GetString(reader.GetOrdinal("Period"));
                    ev.Department = reader.GetString(reader.GetOrdinal("Department"));
                    ev.Task = reader.GetString(reader.GetOrdinal("Task"));
                    ev.Remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                    ev.Event_Type_ID = reader.GetInt32(reader.GetOrdinal("Event_Type_ID"));
                    
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
                    ev.Period = reader.GetString(reader.GetOrdinal("Period"));
                    ev.Department = reader.GetString(reader.GetOrdinal("Department"));
                    ev.Task = reader.GetString(reader.GetOrdinal("Task"));
                    ev.Remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                    
                }
            }

            return ev;
        }

    }
}
