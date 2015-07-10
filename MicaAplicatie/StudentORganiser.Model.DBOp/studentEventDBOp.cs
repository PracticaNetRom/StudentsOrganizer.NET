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
    public class StudentEventDBOP
    {
        private string connectionString;
        private SqlConnection conn;

        public StudentEventDBOP(string connectionString)
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
                command.Parameters.Add("@idStudent", studentEvent.IDStudent);
                command.Parameters.Add("@idEvent", studentEvent.IDEvent);
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
                                               WHERE id_Event = '" + studentEvent.IDEvent + "' and id_Student ='" + studentEvent.IDStudent + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(updateString, conn);

                command.Parameters.Add("@idStudent", studentEvent.IDStudent);
                command.Parameters.Add("@idEvent", studentEvent.IDEvent);
                command.ExecuteNonQuery();

                conn.Close();
            }

        }

        public void DeleteStudentEvent(StudentEvent studentEvent)
        {
            string deleteString = "DELETE FROM StudentEVENT WHERE id_Event = '@idEvent' and id_Student = '@idStudent'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(deleteString, conn);
                command.Parameters.Add(new SqlParameter("@idEvent", studentEvent.IDEvent));
                command.Parameters.Add(new SqlParameter("@idStudent", studentEvent.IDStudent));
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        
    }
}
