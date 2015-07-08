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
    }
}
