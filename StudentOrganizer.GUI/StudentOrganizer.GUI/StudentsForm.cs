using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentOrganizer.Model.BO;
using StudentOrganizer.Model.DBOp;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;


namespace StudentOrganizer.GUI
{
    public partial class StudentsForm : XtraForm
    {
        private Student stud;
        private StudentCommands studComm;
        private Event ev;
        private EventCommands eventComm;
        private System.Data.DataTable studentTable;
        private SqlDataAdapter sqlAdapter;
        private SqlConnection connection;
        private DataTable eventTable;

        private static int StudentListPageNR ;
        private static int EventListPageNR;
        private int maxPageNR;
        private int minPageNR;

        public StudentsForm()
        {
            InitializeComponent();
            CreateDataTable();
            stud = new Student();
            studComm = new StudentCommands(StudentOrganizer.GUI.Properties.Settings.Default.Connection);
            ev = new Event();
            eventComm = new EventCommands(StudentOrganizer.GUI.Properties.Settings.Default.Connection);

            
            maxPageNR = 1;

            minPageNR = 0;

            StudentListPageNR = minPageNR;
            EventListPageNR = minPageNR;

            List<int> yearsList = new List<int>();

            yearsList = eventComm.GetEventYearsList();

            PeriodComboBox.Properties.Items.Add("All");
            PeriodComboBox.Text = "2015";

            for (int i = 0; i < yearsList.Count; i++) 
            {
                PeriodComboBox.Properties.Items.Add(yearsList[i]);
            }

            List<string> eventList = new List<string>();

            EventListComboBox.Properties.Items.Add("All");
            eventList = eventComm.GetEventNames();
            for (int i = 0; i < eventList.Count; i++) 
            {
                EventListComboBox.Properties.Items.Add(eventList[i]);
            }



            pagingToolBar1.BackButtonClicked += pagingToolBar1_BackButtonClicked;
            pagingToolBar1.NextButtonClicked += pagingToolBar1_NextButtonClicked;

            pagingToolBar2.BackButtonClicked += pagingToolBar2_BackButtonClicked;
            pagingToolBar2.NextButtonClicked += pagingToolBar2_NextButtonClicked;
        }

       

        void pagingToolBar1_NextButtonClicked()
        {
            try
            {
                using (connection = new SqlConnection(StudentOrganizer.GUI.Properties.Settings.Default.Connection))
                {
                    connection.Open();

                    SqlCommand sqlCommands = new SqlCommand("SELECT COUNT(*) FROM STUDENT", connection);
                    int totalElements = Convert.ToInt32(sqlCommands.ExecuteScalar());
                    maxPageNR = (totalElements/20);
                    int rest = totalElements % 10;

                   if (maxPageNR <= 0)
                        maxPageNR = 0;

                   StudentListPageNR++;

                   if (StudentListPageNR >= maxPageNR && rest != 0)
                       StudentListPageNR = maxPageNR;
                   else
                       StudentListPageNR--;
                   

                    studentTable = new System.Data.DataTable();
                    sqlAdapter = new SqlDataAdapter(@"SELECT id,firstName,
                                                            lastName,gender,birthDate,
                                                            email,phoneNumber,faculty,
                                                            facultyStartYear FROM Student ORDER BY id  OFFSET " + (20 * StudentListPageNR) + " ROWS  FETCH NEXT 20 ROWS ONLY", connection);

                    sqlAdapter.Fill(studentTable);
                    GridControl.DataSource = studentTable;

                    connection.Close();
                    PeriodComboBox.Text = "All";
                    EventListComboBox.Text = "All";
                }
            }
            catch
            {
                MessageBox.Show("Can't find the specified Data Base");
            }

        }

        void pagingToolBar1_BackButtonClicked()
        {
            try
            {
                using (connection = new SqlConnection(StudentOrganizer.GUI.Properties.Settings.Default.Connection))
                {
                    connection.Open();

                    StudentListPageNR--;

                    if (StudentListPageNR <= 0)
                        StudentListPageNR = 0;

                    studentTable = new System.Data.DataTable();
                    sqlAdapter = new SqlDataAdapter(@"SELECT id,firstName,
                                                            lastName,gender,birthDate,
                                                            email,phoneNumber,faculty,
                                                            facultyStartYear FROM Student ORDER BY id  OFFSET " + (20 * StudentListPageNR) + " ROWS  FETCH NEXT 20 ROWS ONLY", connection);

                    sqlAdapter.Fill(studentTable);
                    GridControl.DataSource = studentTable;

                    connection.Close();
                    PeriodComboBox.Text = "All";
                    EventListComboBox.Text = "All";
                }
            }catch {
                MessageBox.Show("Can not go back to last page!");
            }

        }

        void pagingToolBar2_NextButtonClicked()
        {
            try
            {
                using (connection = new SqlConnection(StudentOrganizer.GUI.Properties.Settings.Default.Connection))
                {
                    connection.Open();

                    SqlCommand sqlCommands = new SqlCommand("SELECT COUNT(*) FROM EVENT", connection);
                    int totalElements = Convert.ToInt32(sqlCommands.ExecuteScalar());
                    maxPageNR = (totalElements / 10);
                    int rest = totalElements % 10;

                    if (maxPageNR <= 0)
                        maxPageNR = 0;

                    EventListPageNR++;

                    if (EventListPageNR >= maxPageNR && rest != 0)
                        EventListPageNR = maxPageNR;
                    else
                        EventListPageNR--;


                    eventTable = new System.Data.DataTable();
                    sqlAdapter = new SqlDataAdapter(@"SELECT id,eventTypes_ID,
                                                           period,departament,task,
                                                            remarks FROM Event ORDER BY id  OFFSET " + (10 * EventListPageNR) + " ROWS  FETCH NEXT 10 ROWS ONLY", connection);

                    sqlAdapter.Fill(eventTable);
                    EventListControl.DataSource = eventTable;

                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Can't find the specified Data Base");
            }
        }

        void pagingToolBar2_BackButtonClicked()
        {
            try
            {
                using (connection = new SqlConnection(StudentOrganizer.GUI.Properties.Settings.Default.Connection))
                {
                    connection.Open();

                    EventListPageNR--;

                    if (EventListPageNR <= 0)
                        EventListPageNR = 0;

                    eventTable = new System.Data.DataTable();
                    sqlAdapter = new SqlDataAdapter(@"SELECT id,eventTypes_ID,
                                                           period,departament,task,
                                                            remarks FROM Event ORDER BY id  OFFSET " + (10 * EventListPageNR) + " ROWS  FETCH NEXT 10 ROWS ONLY", connection);

                    sqlAdapter.Fill(eventTable);
                    EventListControl.DataSource = eventTable;

                    connection.Close();

                }
            }
            catch
            {
                MessageBox.Show("Can not go back to last page!");
            }

        }


        public void CreateDataTable() 
        {
            try
            {
                using (connection = new SqlConnection(StudentOrganizer.GUI.Properties.Settings.Default.Connection))
                {
                    connection.Open();

                    studentTable = new System.Data.DataTable();
                    sqlAdapter = new SqlDataAdapter(@"SELECT DISTINCT student.id,student.firstName,
                                                            student.lastName,student.gender,student.birthDate,
                                                            student.email,student.phoneNumber,student.faculty,
                                                            student.facultyStartYear FROM Student,Event,StudentEvent 
                                                            WHERE student.id = StudentEvent.id_Student 
                                                            AND event.id = StudentEvent.id_Event
                                                            AND year(event.period) = 2015", connection);
                    sqlAdapter.Fill(studentTable);
                    GridControl.DataSource = studentTable;

                    eventTable = new System.Data.DataTable();
                    sqlAdapter = new SqlDataAdapter(@"SELECT id,eventTypes_ID,
                                                            period,departament,task,
                                                           remarks FROM Event ORDER BY id  OFFSET 0 ROWS  FETCH NEXT 10 ROWS ONLY", connection);
                     
                    
                    sqlAdapter.Fill(eventTable);
                    EventListControl.DataSource = eventTable;

                    connection.Close();
                }
            }
            catch 
            {
                MessageBox.Show("Could not open connection to database !");
            }
            
           
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
            if (PeriodComboBox.Text.Equals("All"))
            {
                studentTable = new System.Data.DataTable();
                connection = new SqlConnection(StudentOrganizer.GUI.Properties.Settings.Default.Connection);
                sqlAdapter = new SqlDataAdapter(@"SELECT id,firstName,
                                                            lastName,gender,birthDate,
                                                            email,phoneNumber,faculty,
                                                            facultyStartYear FROM Student", connection);
                sqlAdapter.Fill(studentTable);
                GridControl.RefreshDataSource();
                GridControl.DataSource = studentTable;
            }
            else
            {
                studentTable = new System.Data.DataTable();
                connection = new SqlConnection(StudentOrganizer.GUI.Properties.Settings.Default.Connection);
                sqlAdapter = new SqlDataAdapter(@"SELECT DISTINCT student.id,student.firstName,
                                                            student.lastName,student.gender,student.birthDate,
                                                            student.email,student.phoneNumber,student.faculty,
                                                            student.facultyStartYear FROM Student,Event,StudentEvent 
                                                            WHERE student.id = StudentEvent.id_Student 
                                                            AND event.id = StudentEvent.id_Event
                                                            AND year(event.period) = '" + PeriodComboBox.Text + "'", connection);
                sqlAdapter.Fill(studentTable);
                GridControl.DataSource = studentTable;
                EventListComboBox.Text = "All";
            }
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            gridView1.ExportToXlsx("Students.xlsx");
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDOWN = 0x00A1;
            const int HTCLOSE = 20;

            if (m.Msg == WM_NCLBUTTONDOWN)
            {
                switch ((int)m.WParam)
                {
                    case HTCLOSE:
                        LogInForm logIn = new LogInForm();
                        logIn.Show();
                        this.Close();
                        break;
                }
            }

            base.WndProc(ref m);
        }


        private void PrintButton_Click(object sender, EventArgs e)
        {
            CompositeLink composLink = new CompositeLink(new PrintingSystem());

            PrintableComponentLink pcLink1 = new PrintableComponentLink();
           
            pcLink1.Component = this.GridControl;
           
            composLink.Links.Add(pcLink1);
            composLink.ShowPreview();
        }

        private void ButtonDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Student student = new Student();

            var rowHandler = gridView1.FocusedRowHandle;

            student.Id = Convert.ToInt32(gridView1.GetRowCellValue(rowHandler, "id"));
            student.FirstName = gridView1.GetRowCellValue(rowHandler, "firstName").ToString();
            student.LastName = gridView1.GetRowCellValue(rowHandler, "lastName").ToString();

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the student : " + student.FirstName + " " + student.LastName, "Delete Student?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (connection = new SqlConnection(StudentOrganizer.GUI.Properties.Settings.Default.Connection))
                {
                    connection.Open();

                    studComm.DeleteStudent(student);

                    studentTable = new System.Data.DataTable();
                    connection = new SqlConnection(StudentOrganizer.GUI.Properties.Settings.Default.Connection);
                    sqlAdapter = new SqlDataAdapter(@"SELECT id,firstName,
                                                            lastName,gender,birthDate,
                                                            email,phoneNumber,faculty,
                                                            facultyStartYear FROM Student", connection);
                    sqlAdapter.Fill(studentTable);
                    GridControl.DataSource = studentTable;

                    connection.Close();
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void deleteEventButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Event ev = new Event();

            var rowHandler = gridView2.FocusedRowHandle;

            ev.ID = Convert.ToInt32(gridView2.GetRowCellValue(rowHandler, "id"));
            ev.EventTypes_ID = Convert.ToInt32(gridView2.GetRowCellValue(rowHandler, "eventTypes_ID"));
            ev.Period = Convert.ToDateTime(gridView2.GetRowCellValue(rowHandler, "period"));

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the event ","Delete Event", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (connection = new SqlConnection(StudentOrganizer.GUI.Properties.Settings.Default.Connection))
                {
                    connection.Open();
                    eventComm.DeleteEvent(ev);

                    eventTable = new System.Data.DataTable();
                    sqlAdapter = new SqlDataAdapter(@"SELECT id,eventTypes_ID,
                                                                period,departament,task,
                                                                remarks FROM Event", connection);
                    sqlAdapter.Fill(eventTable);
                    EventListControl.DataSource = eventTable;

                    connection.Close();
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void EventListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EventListComboBox.Text.Equals("All"))
            {
                studentTable = new System.Data.DataTable();
                connection = new SqlConnection(StudentOrganizer.GUI.Properties.Settings.Default.Connection);
                sqlAdapter = new SqlDataAdapter(@"SELECT id,firstName,
                                                            lastName,gender,birthDate,
                                                            email,phoneNumber,faculty,
                                                            facultyStartYear FROM Student", connection);
                sqlAdapter.Fill(studentTable);
                GridControl.RefreshDataSource();
                GridControl.DataSource = studentTable;
            }
            else
            {
                studentTable = new System.Data.DataTable();
                connection = new SqlConnection(StudentOrganizer.GUI.Properties.Settings.Default.Connection);
                sqlAdapter = new SqlDataAdapter(@"SELECT DISTINCT student.id,student.firstName,
                                                            student.lastName,student.gender,student.birthDate,
                                                            student.email,student.phoneNumber,student.faculty,
                                                            student.facultyStartYear FROM Student,Event,StudentEvent,EventTypes 
                                                            WHERE student.id = StudentEvent.id_Student 
                                                            AND event.id = StudentEvent.id_Event
                                                            AND EventTypes.id = event.eventTypes_id
                                                            AND EventTypes.Description = '" + EventListComboBox.Text + "'", connection);
                sqlAdapter.Fill(studentTable);
                GridControl.DataSource = studentTable;
                PeriodComboBox.Text = "All";
            }
        }

    }
}
