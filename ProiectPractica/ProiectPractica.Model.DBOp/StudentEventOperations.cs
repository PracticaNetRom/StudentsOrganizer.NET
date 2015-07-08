using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPractica.Model.DBOp
{
    public class StudentEventOperations
    {
        private SqlConnection con;

        public StudentEventOperations(SqlConnection con)
        {
            this.con = con;
        }

        public void InsertStudentEvent(StudentEvent se)
        {
            string InsertString = "Insert into student_event( IdStudent, IdEvent) values ( @id_student, @id_event)";

            SqlCommand command = new SqlCommand(InsertString, con);

            command.Parameters.Add("@id_student", se.id_student);
            command.Parameters.Add("@id_event", se.id_event);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
        }

        public void DeleteStudentEvent(StudentEvent se) {

            string DeleteString = "Delete From student_event Where id_student = " + se.id_student  +"  AND id_event= " + se.id_event ;
            SqlCommand command = new SqlCommand(DeleteString, con);
            command.ExecuteNonQuery();
        }

        /*public void UpdateStudentEvent(StudentEvent se) {

            string UpdateString = "UPDATE StudentEvent SET set IdStudent = @id_student, IdEvent = @id_event , Period=@period, Departament=@departament, Task=@task, Remarks=@remarks WHERE id = '" + se.id + "'";
            SqlCommand command = new SqlCommand(UpdateString, con);

            command.Parameters.Add("@idStudent", se.id_student);
            command.Parameters.Add("@idEvent", se.id_event);
            command.ExecuteNonQuery();

        }*/
    }
}

