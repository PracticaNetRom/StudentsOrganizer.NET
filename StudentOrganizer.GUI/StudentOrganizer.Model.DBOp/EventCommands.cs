using StudentOrganizer.Model.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string insertString = @"INSERT INTO StudentEVENT(
                                                Period,
                                                Departament,Task,
                                                Remarks,eventTypes_ID) 
                                                            values(
                                                            @period,@departament,
                                                            @task,@remarks,@eventTypes_ID
                                                                        )";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(insertString, conn);
                command.Parameters.Add("@period",ev.Period);
                command.Parameters.Add("@departament", ev.Departament);
                command.Parameters.Add("@task", ev.Task);
                command.Parameters.Add("@remarks", ev.Remarks);
                command.Parameters.Add("@eventTypes_ID", ev.EventTypes_ID);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void UpdateEvent(Event ev)
        {
            string updateString = @"UPDATE StudentEVENT 
                                           SET 
                                               Period=@period, 
                                               Departament=@departament, 
                                               Task=@task, 
                                               Remarks=@remarks ,
                                               eventTypes_ID = @eventTypes_ID
                                               WHERE id = '" + ev.ID + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(updateString, conn);

                command.Parameters.Add("@period", ev.Period);
                command.Parameters.Add("@departament", ev.Departament);
                command.Parameters.Add("@task", ev.Task);
                command.Parameters.Add("@remarks", ev.Remarks);
                command.Parameters.Add("@eventTypes_ID", ev.EventTypes_ID);

                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void DeleteEvent(Event ev)
        {
            string deleteString = "DELETE FROM EVENT WHERE id = '" + ev.ID + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(deleteString, conn);
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public Event SearchEvent(int evID)
        {
            Event ev = new Event();
            ev.ID = evID;

            string searchString = "SELECT * FROM EVENT where id = " + ev.ID;

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(searchString, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ev.Period = reader.GetDateTime(reader.GetOrdinal("Period"));
                        ev.Remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                        ev.Task = reader.GetString(reader.GetOrdinal("Task"));
                        ev.Departament = reader.GetString(reader.GetOrdinal("Departament"));
                        ev.EventTypes_ID = reader.GetInt32(reader.GetOrdinal("eventTypes_ID"));
                    }
                }

                conn.Close();
            }

            return ev;
        }
    }
}
