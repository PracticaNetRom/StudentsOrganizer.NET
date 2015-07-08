using StudentOrganizer.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOrganizer.DBOp
{
    public class StudentEventCommands
    {
        private SqlConnection conn;

        public StudentEventCommands(SqlConnection conn)
        {
            this.conn = conn;
        }

        public void InsertStudentEvent(StudentEvent studentEvent)
        {
            string insertString = "INSERT INTO StudentEVENT(Id_Student,Id_Event) values(@id_Student,@id_Event)";

            SqlCommand command = new SqlCommand(insertString, conn);
            command.Parameters.Add("@id_Student", studentEvent.Id_Student);
            command.Parameters.Add("@id_Event", studentEvent.Id_Event);

            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
        }

        public void UpdateStudentEvent(StudentEvent studentEvent)
        {
            string updateString = "UPDATE StudentEVENT SET set Id_Student = @id_Student, Id_Event = @id_Event  WHERE id = '" + studentEvent.Id_Event + "'";

            SqlCommand command = new SqlCommand(updateString, conn);

            command.Parameters.Add("@id_Student", studentEvent.Id_Student);
            command.Parameters.Add("@id_Event", studentEvent.Id_Event);
            
            command.ExecuteNonQuery();

        }

        public void DeleteStudentEvent(StudentEvent studentEvent)
        {
            string deleteString = "DELETE FROM StudentEVENT WHERE id = '" + studentEvent.Id_Event + "'";

            SqlCommand command = new SqlCommand(deleteString, conn);
            command.ExecuteNonQuery();
        }

        public StudentEvent SearchStudentEvent(int studID)
        {
            StudentEvent studentEvent = new StudentEvent();
            studentEvent.Id_Event = studID;

            string searchString = "SELECT * FROM studentEVENT where id = " + studentEvent.Id_Event;

            SqlCommand command = new SqlCommand(searchString, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    studentEvent.Id_Student = reader.GetInt32(reader.GetOrdinal("Id_Student"));
                    studentEvent.Id_Event = reader.GetInt32(reader.GetOrdinal("Id_Event"));
                    
                }
            }

            return studentEvent;
        }

    }
}