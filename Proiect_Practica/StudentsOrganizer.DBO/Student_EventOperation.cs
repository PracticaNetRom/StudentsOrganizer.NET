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
    public class Student_EventOperation
    {
        private SqlConnection Con;

        public Student_EventOperation(SqlConnection Con)
        {
            this.Con = Con;
        }

        public void InsertStudentEvent(Student_Event studentEvent)
        {
            string insertString = "INSERT INTO StudentEVENT(ID_Students,Id_Event)";

            SqlCommand command = new SqlCommand(insertString, Con);
            command.Parameters.Add("@idStudent", studentEvent.ID_Student);
            command.Parameters.Add("@idEvent", studentEvent.ID_Event);
         
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
        }

       

        //public void UpdateStudent_Event(Student_Event studentEvent)
        //{
        //    string updateString = "UPDATE StudentEVENT SET set Id_Student = @idStudent, Id_Event = @idEvent  WHERE ID = '" + studentEvent.ID + "'";

        //    SqlCommand command = new SqlCommand(updateString, Con);


        //    command.Parameters.Add("@idStudent", studentEvent.ID_Student);
        //    command.Parameters.Add("@idEvent", studentEvent.ID_Event);
        
        //    command.ExecuteNonQuery();

        //}
        public void DeleteStudentEvent(Student_Event studentEvent)
        {
            string deleteString = "DELETE FROM Student_Event WHERE ID_Student = " + studentEvent.ID_Student + " AND ID_Event=  " + studentEvent.ID_Student;

            SqlCommand command = new SqlCommand(deleteString, Con);
            command.ExecuteNonQuery();
        }
    }
}
