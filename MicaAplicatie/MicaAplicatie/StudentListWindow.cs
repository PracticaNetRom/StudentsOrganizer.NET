using DevExpress.XtraGrid;
using StudentOrganiser.Model.BO;
using StudentORganiser.Model.DBOp;
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

namespace MicaAplicatie
{
    public partial class StudentListWindow : Form
    {
        public StudentListWindow()
        {
            InitializeComponent();
            CreateDataTable();
        }

        private void ReturnToAdminPannelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel AdminPanel = new AdminPanel();
            AdminPanel.Show();
        }


        private Student stud;
        private StudentDBOP studComm;
        private Event ev;
        private EventDBOP eventComm;
        private System.Data.DataTable studentTable;
        private SqlDataAdapter sqlAdapter;
        private SqlConnection connection;
        private DataTable eventTable;

        public void CreateDataTable()
        {
            studentTable = new System.Data.DataTable();
            connection = new SqlConnection(Properties.Settings.Default.DBConnection);
            sqlAdapter = new SqlDataAdapter(@"SELECT id,FirstName,
                                                            LastName,Email,PhoneNumber,Gender,Faculty
                                                            FacultyStartYear,BirthDate FROM Student", connection);
            sqlAdapter.Fill(studentTable);
            StudentList.DataSource = studentTable;

            eventTable = new System.Data.DataTable();
            sqlAdapter = new SqlDataAdapter(@"SELECT id,eventTypes_ID,
                                                           perioada,Departament,Task,
                                                           Remarks FROM Event", connection);
            sqlAdapter.Fill(eventTable);
            EventListControl.DataSource = eventTable;

        }

        private void StudentList_Click(object sender, EventArgs e)
        {

        }
    }
}
