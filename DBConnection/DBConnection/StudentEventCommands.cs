using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnection.Model
{
    class StudentEventCommands
    {
        private SqlConnection conn;

        public StudentEventCommands(SqlConnection conn) 
        {
            this.conn = conn;
        }

        public void insertStudentEvent(StudentEvent studentEvent)
        {
            string insertString = "INSERT INTO StudentEVENT(Id_Student,Id_Event,Period,Departament,Task,Remarks) values(@param1,@param2,@param3,@param4,@param5,@param6)";

            SqlCommand command = new SqlCommand(insertString, conn);
            command.Parameters.Add("@param1", studentEvent.Id_Student);
            command.Parameters.Add("@param2", studentEvent.Id_Event);
            command.Parameters.Add("@param3", studentEvent.Period);
            command.Parameters.Add("@param4", studentEvent.Departament);
            command.Parameters.Add("@param5", studentEvent.TASK);
            command.Parameters.Add("@param6", studentEvent.Remarks);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
        }

        public void updateStudentEvent(StudentEvent studentEvent)
        {
            string updateString = "UPDATE StudentEVENT SET set Id_Student = '" + studentEvent.Id_Student + "' WHERE id = '" + studentEvent.ID + "'";

            SqlCommand command = new SqlCommand(updateString, conn);
            command.ExecuteNonQuery();

            updateString = "UPDATE StudentEVENT SET set Id_Event = '" + studentEvent.Id_Event + "' WHERE id = '" + studentEvent.ID + "'";
            command = new SqlCommand(updateString, conn);
            command.ExecuteNonQuery();

            updateString = "UPDATE StudentEVENT SET set Period = '" + studentEvent.Period + "' WHERE id = '" + studentEvent.ID + "'";
            command = new SqlCommand(updateString, conn);
            command.ExecuteNonQuery();

            updateString = "UPDATE StudentEVENT SET set Departament = '" + studentEvent.Departament + "' WHERE id = '" + studentEvent.ID + "'";
            command = new SqlCommand(updateString, conn);
            command.ExecuteNonQuery();

            updateString = "UPDATE StudentEVENT SET set Task = '" + studentEvent.TASK + "' WHERE id = '" + studentEvent.ID + "'";
            command = new SqlCommand(updateString, conn);
            command.ExecuteNonQuery();

            updateString = "UPDATE StudentEVENT SET set Remarks = '" + studentEvent.Remarks + "' WHERE id = '" + studentEvent.ID + "'";
            command = new SqlCommand(updateString, conn);
            command.ExecuteNonQuery();
        }

        public void deleteStudentEvent(StudentEvent studentEvent)
        {
            string deleteString = "DELETE FROM StudentEVENT WHERE id = '" + studentEvent.ID + "'";

            SqlCommand command = new SqlCommand(deleteString, conn);
            command.ExecuteNonQuery();
        }

        public StudentEvent searchStudentEvent(int studID) 
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
