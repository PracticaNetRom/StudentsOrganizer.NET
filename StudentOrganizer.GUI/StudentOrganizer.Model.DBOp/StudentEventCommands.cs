using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using StudentOrganizer.Model.BO;
using System.Text.RegularExpressions;

namespace StudentOrganizer.Model.DBOp
{
    public class StudentEventCommands
    {
        private string connectionString;
        private SqlConnection conn;

        public StudentEventCommands(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertStudentEvent(StudentEvent studentEvent)
        {
            string insertString = @"INSERT INTO StudentEVENT(
                                                Id_Student,
                                                Id_Event ) 
                                                            values(
                                                            @idStudent,@idEvent)";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(insertString, conn);
                command.Parameters.Add("@idStudent", studentEvent.Id_Student);
                command.Parameters.Add("@idEvent", studentEvent.Id_Event);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void UpdateStudentEvent(StudentEvent studentEvent)
        {
            string updateString = @"UPDATE StudentEVENT 
                                           SET Id_Student = @idStudent,
                                               Id_Event = @idEvent , 
                                               WHERE id_Event = '" + studentEvent.Id_Event + "' and id_Student ='"+studentEvent.Id_Student+"'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(updateString, conn);

                command.Parameters.Add("@idStudent", studentEvent.Id_Student);
                command.Parameters.Add("@idEvent", studentEvent.Id_Event);
                command.ExecuteNonQuery();

                conn.Close();
            }

        }

        public void DeleteStudentEvent(StudentEvent studentEvent)
        {
            string deleteString = "DELETE FROM StudentEVENT WHERE id_Event = '" + studentEvent.Id_Event + "' and id_Student ='" + studentEvent.Id_Student + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(deleteString, conn);
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void InsertStudentEventUsingEventName(string text) 
        {
            string selectString = "SELECT EventTypes.Description,EventTypes.id,Event.Period FROM EventTypes,Event where  EventTypes.id=Event.eventTypes_ID ";
            string period = null;
            string nameAndPeriod = null;

            int eventID = 0;
            int eventTypesID = 0;
            int studentID = 0;
            string eventName = null;
            
            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(selectString, conn);
                SqlDataReader reader = command.ExecuteReader();
                EventTypes ev = new EventTypes();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ev.Description = reader.GetString(reader.GetOrdinal("Description"));
                        ev.IdEvent = reader.GetInt32(reader.GetOrdinal("id"));
                        period = reader.GetDateTime(reader.GetOrdinal("Period")).ToString("dd/MM/yyyy");
                        nameAndPeriod = ev.Description + " " + period;

                        String baseString = Regex.Replace(nameAndPeriod, @" ", "");

                        if (baseString.Equals(text))
                        {
                            eventName = ev.Description;
                            break;
                        }
                    }
                    reader.Close();
                }

                selectString = "SELECT * FROM EventTypes where description = @eventName";
                command = new SqlCommand(selectString, conn);
                command.Parameters.Add("@eventName", eventName);

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        eventTypesID = reader.GetInt32(reader.GetOrdinal("id"));
                    }
                    reader.Close();
                }

                if (eventTypesID != 0)
                {
                    selectString = "SELECT * FROM Event where eventTypes_ID = @eventTypesID AND convert(varchar,period,103) = @period";
                    command = new SqlCommand(selectString, conn);
                    command.Parameters.Add("@eventTypesID", eventTypesID);
                    command.Parameters.Add("@period", period);

                    reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            eventID = reader.GetInt32(reader.GetOrdinal("id"));
                        }
                        reader.Close();
                    }
                }
                reader.Close();

                selectString = "SELECT TOP 1 * FROM student ORDER BY id DESC;";
                command = new SqlCommand(selectString, conn);

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        studentID = reader.GetInt32(reader.GetOrdinal("id"));
                    }
                    reader.Close();
                }
                
                string insertString = @"INSERT INTO StudentEVENT(
                                                Id_Student,
                                                Id_Event ) 
                                                            values(
                                                            @idStudent,@idEvent)";

                command = new SqlCommand(insertString, conn);
                command.Parameters.Add("@idStudent", studentID);
                command.Parameters.Add("@idEvent", eventID);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                conn.Close();
            }
        }
    }
}
