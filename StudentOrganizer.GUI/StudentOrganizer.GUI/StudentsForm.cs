using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentOrganizer.Model.BO;
using StudentOrganizer.Model.DBOp;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;


namespace StudentOrganizer.GUI
{
    public partial class StudentsForm : Form
    {
        Student stud;
        public StudentsForm()
        {
            InitializeComponent();
            CreateDataTable();
            stud = new Student();
        }

        public void CreateDataTable() 
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(StudentOrganizer.GUI.Properties.Settings.Default.Connection);
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(@"SELECT id,firstName,
                                                            lastName,gender,birthDate,
                                                            email,phoneNumber,faculty,
                                                            facultyStartYear FROM Student", connection);
            sqlAdapter.Fill(dataTable);
            
            GridControl.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudent = new AddStudentForm();
            addStudent.Show();
            this.Close();
        }

        private void createEventButton_Click(object sender, EventArgs e)
        {
            AddEventForm evForm = new AddEventForm();
            evForm.Show();
            this.Close();
        }

        private void EditStudentButton_Click(object sender, EventArgs e)
        {
             var rowHandler = gridView1.FocusedRowHandle;

             stud.Id = Convert.ToInt32(gridView1.GetRowCellValue(rowHandler, "id"));
             stud.FirstName = gridView1.GetRowCellValue(rowHandler, "firstName").ToString();
             stud.LastName = gridView1.GetRowCellValue(rowHandler, "lastName").ToString();
             stud.Gender = gridView1.GetRowCellValue(rowHandler, "gender").ToString();
             stud.BirthDate = Convert.ToDateTime(gridView1.GetRowCellValue(rowHandler, "birthDate").ToString());
             stud.Email = gridView1.GetRowCellValue(rowHandler, "email").ToString();
             stud.PhoneNumber = gridView1.GetRowCellValue(rowHandler, "phoneNumber").ToString();
             stud.Faculty = gridView1.GetRowCellValue(rowHandler, "faculty").ToString();
             stud.FacultyStartYear = Convert.ToInt32(gridView1.GetRowCellValue(rowHandler, "facultyStartYear").ToString());
            
             EditStudentForm editStudent = new EditStudentForm(stud);

             editStudent.Show();
             this.Close();
           
        }

        private void GridControl_Click(object sender, EventArgs e)
        {
            
        }
    }
}
