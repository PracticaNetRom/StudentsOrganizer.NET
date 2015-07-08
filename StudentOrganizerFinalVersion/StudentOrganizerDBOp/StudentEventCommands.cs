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
            string insertString = "INSERT INTO StudentEVENT(Id_Student,Id_Event,Period,Departament,Task,Remarks) values(@idStudent,@idEvent,@period,@departament,@task,@remarks)";

            SqlCommand command = new SqlCommand(insertString, conn);
            command.Parameters.Add("@idStudent", studentEvent.Id_Student);
            command.Parameters.Add("@idEvent", studentEvent.Id_Event);
            command.Parameters.Add("@period", studentEvent.Period);
            command.Parameters.Add("@departament", studentEvent.Departament);
            command.Parameters.Add("@task", studentEvent.TASK);
            command.Parameters.Add("@remarks", studentEvent.Remarks);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
        }

        public void UpdateStudentEvent(StudentEvent studentEvent)
        {
            string updateString = "UPDATE StudentEVENT SET set Id_Student = @idStudent, Id_Event = @idEvent , Period=@period, Departament=@departament, Task=@task, Remarks=@remarks WHERE id = '" + studentEvent.ID + "'";

            SqlCommand command = new SqlCommand(updateString, conn);

            command.Parameters.Add("@idStudent", studentEvent.Id_Student);
            command.Parameters.Add("@idEvent", studentEvent.Id_Event);
            command.Parameters.Add("@period", studentEvent.Period);
            command.Parameters.Add("@departament", studentEvent.Departament);
            command.Parameters.Add("@task", studentEvent.TASK);
            command.Parameters.Add("@remarks", studentEvent.Remarks);
            command.ExecuteNonQuery();

        }

        public void DeleteStudentEvent(StudentEvent studentEvent)
        {
            string deleteString = "DELETE FROM StudentEVENT WHERE id = '" + studentEvent.ID + "'";

            SqlCommand command = new SqlCommand(deleteString, conn);
            command.ExecuteNonQuery();
        }

        public StudentEvent SearchStudentEvent(int studID)
        {
            StudentEvent studentEvent = new StudentEvent();
            studentEvent.ID = studID;

            string searchString = "SELECT * FROM studentEVENT where id = " + studentEvent.ID;

            SqlCommand command = new SqlCommand(searchString, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    studentEvent.Id_Student = reader.GetInt32(reader.GetOrdinal("Id_Student"));
                    studentEvent.Id_Event = reader.GetInt32(reader.GetOrdinal("Id_Event"));
                    studentEvent.Period = reader.GetDateTime(reader.GetOrdinal("Period"));
                    studentEvent.Remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                    studentEvent.TASK = reader.GetString(reader.GetOrdinal("TASK"));
                    studentEvent.Departament = reader.GetString(reader.GetOrdinal("Departament"));
                }
            }

            return studentEvent;
        }

    }
}