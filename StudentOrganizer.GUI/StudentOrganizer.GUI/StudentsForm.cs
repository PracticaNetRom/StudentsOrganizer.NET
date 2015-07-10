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
        private Student stud;
        private Event ev;
        private EventCommands eventComm;
        private DataTable eventTable;
        private SqlDataAdapter sqlAdapter;
        private SqlConnection connection;

        public StudentsForm()
        {
            InitializeComponent();
            CreateDataTable();
            stud = new Student();
            ev = new Event();
            eventComm = new EventCommands(StudentOrganizer.GUI.Properties.Settings.Default.Connection);

            List<Event> evList = new List<Event>();
            evList = eventComm.GetEventList();


            for (int i = 0; i < evList.Count; i++) 
            {
                PeriodComboBox.Properties.Items.Add(evList[i].Period.Year);
            }
            

        }

        public void CreateDataTable() 
        {
            DataTable studentTable = new DataTable();
            connection = new SqlConnection(StudentOrganizer.GUI.Properties.Settings.Default.Connection);
            sqlAdapter = new SqlDataAdapter(@"SELECT id,firstName,
                                                            lastName,gender,birthDate,
                                                            email,phoneNumber,faculty,
                                                            facultyStartYear FROM Student", connection);
            sqlAdapter.Fill(studentTable);
            GridControl.DataSource = studentTable;

            eventTable = new DataTable();
            sqlAdapter = new SqlDataAdapter(@"SELECT id,eventTypes_ID,
                                                            period,departament,task,
                                                            remarks FROM Event", connection);
            sqlAdapter.Fill(eventTable);
            EventListControl.DataSource = eventTable;
           
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

        private void PeriodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(StudentOrganizer.GUI.Properties.Settings.Default.Connection);
            eventTable = new DataTable();

            //SELECT DATEPART ( yyyy , period ) FROM EVENT 
            sqlAdapter = new SqlDataAdapter(@"SELECT DATEPART ( yyyy , period ) FROM EVENT where period = " + Convert.ToDateTime(PeriodComboBox.Text).Year, connection);
            sqlAdapter.Fill(eventTable);
            EventListControl.DataSource = eventTable;
        }
    }
}
