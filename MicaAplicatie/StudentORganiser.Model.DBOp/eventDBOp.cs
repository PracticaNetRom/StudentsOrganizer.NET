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
    public class EventDBOP
    {
        private string connectionString;
        private SqlConnection conn;

        public EventDBOP(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertEvent(Event ev)
        {
            string insertString = @"INSERT INTO Event(
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
                command.Parameters.Add("@period", ev.EventPeriod);
                command.Parameters.Add("@departament", ev.EventDept);
                command.Parameters.Add("@task", ev.Task);
                command.Parameters.Add("@remarks", ev.Remarks);
                command.Parameters.Add("@eventTypes_ID", ev.EventTypeID);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void UpdateEvent(Event ev)
        {
            string updateString = @"UPDATE Event 
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

                command.Parameters.Add("@period", ev.EventPeriod);
                command.Parameters.Add("@departament", ev.EventDept);
                command.Parameters.Add("@task", ev.Task);
                command.Parameters.Add("@remarks", ev.Remarks);
                command.Parameters.Add("@eventTypes_ID", ev.EventTypeID);

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
                        ev.EventPeriod = reader.GetDateTime(reader.GetOrdinal("perioada"));
                        ev.Remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                        ev.Task = reader.GetString(reader.GetOrdinal("Task"));
                        ev.EventDept = reader.GetString(reader.GetOrdinal("Departament"));
                        ev.EventTypeID = reader.GetInt32(reader.GetOrdinal("eventTypes_ID"));
                    }
                    reader.Close();
                }

                conn.Close();
            }

            return ev;
        }

    }
}