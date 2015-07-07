using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsOrganizerModel.BO;

namespace StudentsOrganizer.DBO
{
    class Student_EventOperation
    {
        private SqlConnection Con;

        public Student_EventOperation(SqlConnection Con)
        {
            this.Con = Con;
        }

        public void InsertStudentEvent(Student_Event studentEvent)
        {
            string insertString = "INSERT INTO StudentEVENT(ID_Students,Id_Event,Period,Departament,Task,Remarks) values(@idStudent,@idEvent,@period,@departament,@task,@remarks)";

            SqlCommand command = new SqlCommand(insertString, Con);
            command.Parameters.Add("@idStudent", studentEvent.ID_Students);
            command.Parameters.Add("@idEvent", studentEvent.ID_Event);
            command.Parameters.Add("@period", studentEvent.Period);
            command.Parameters.Add("@departament", studentEvent.Departament);
            command.Parameters.Add("@task", studentEvent.Task);
            command.Parameters.Add("@remarks", studentEvent.Remarks);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
        }

       

        public void UpdateStudent_Event(Student_Event studentEvent)
        {
            string updateString = "UPDATE StudentEVENT SET set Id_Student = @idStudent, Id_Event = @idEvent , Period=@period, Departament=@departament, Task=@task, Remarks=@remarks WHERE id = '" + studentEvent.ID + "'";

            SqlCommand command = new SqlCommand(updateString, Con);


            command.Parameters.Add("@idStudent", studentEvent.ID_Student);
            command.Parameters.Add("@idEvent", studentEvent.ID_Event);
            command.Parameters.Add("@period", studentEvent.Period);
            command.Parameters.Add("@departament", studentEvent.Departament);
            command.Parameters.Add("@task", studentEvent.Task);
            command.Parameters.Add("@remarks", studentEvent.Remarks);
            command.ExecuteNonQuery();

        }
        public void DeleteStudentEvent(Student_Event studentEvent)
        {
            string deleteString = "DELETE FROM StudentEVENT WHERE ID = '" + studentEvent.ID + "'";

            SqlCommand command = new SqlCommand(deleteString, Con);
            command.ExecuteNonQuery();
        }
    }
}
