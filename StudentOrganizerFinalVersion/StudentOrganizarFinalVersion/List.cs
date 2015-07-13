using DevExpress.XtraGrid;
using StudentOrganizer.BO;
using StudentOrganizerDBOp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;

namespace StudentOrganizarFinalVersion
{
    public partial class List : Form
    {
        Student stud;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public List()
        {
            InitializeComponent();
            CreateDataTable();
            CreateEventTable();
            stud = new Student();
            
        }

        public void CreateDataTable()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(StudentOrganizarFinalVersion.Properties.Settings.Default.connection);
            connection.Open();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(@"SELECT id,firstName,
                                                            lastName,gender,birthDate,
                                                            email,phoneNumber,faculty,
                                                            facultyStartYear FROM Student", connection);
            sqlAdapter.Fill(dataTable);
            
            GridControl.DataSource = dataTable;
        }

        private void CreateButton(object sender, EventArgs e)
        {
            Create andrei = new Create();
            andrei.Show();

            this.Hide();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            CreateDataTable();
        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void CreateEventTable()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(StudentOrganizarFinalVersion.Properties.Settings.Default.connection);
            connection.Open();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(@"SELECT ID,period,
                                                            department,task,remarks,
                                                            event_type_id FROM Events", connection);
            sqlAdapter.Fill(dataTable);

            gridControl1.DataSource = dataTable;
        }

       

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            Create andrei = new Create();
            andrei.Show();

            this.Hide();
        }

        private void CreateStudentButton_Click(object sender, EventArgs e)
        {
            Create andrei = new Create();
            andrei.Show();

            this.Hide();
        }

      

        private void EditStudentButton_Click(object sender, EventArgs e)
        {
            
            //var rowHandler = GridControl.FocusedRowHandle;
            ColumnView cv = GridControl.MainView as ColumnView;
            cv.FocusedRowHandle = 0;


            //stud.IdStudent = Convert.ToInt32(gridView1.GetRowCellValue(rowHandler, "id"));
            //stud.FirstName = gridView1.GetRowCellValue(rowHandler, "FirstName").ToString();
            //stud.LastName = gridView1.GetRowCellValue(rowHandler, "LastName").ToString();
            //stud.Gender = gridView1.GetRowCellValue(rowHandler, "Gender").ToString();
            //stud.BirthDate = Convert.ToDateTime(gridView1.GetRowCellValue(rowHandler, "BirthDate").ToString());
           // stud.Email = gridView1.GetRowCellValue(rowHandler, "Email").ToString();
            //stud.PhoneNumber = gridView1.GetRowCellValue(rowHandler, "PhoneNumber").ToString();
           // stud.Faculty = gridView1.GetRowCellValue(rowHandler, "Faculty").ToString();
           // stud.FacultyStartYear = Convert.ToInt32(gridView1.GetRowCellValue(rowHandler, "FacultyStartYear").ToString());

            EditStudent andrei = new EditStudent();
            andrei.Show();

            this.Hide();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        
    }
}
