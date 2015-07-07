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

namespace StudentOrganizer.GUI
{
    public partial class StudentsForm : Form
    {
      
        public StudentsForm()
        {
            InitializeComponent();
            CreateDataTable();
            
        }

        public void CreateDataTable() 
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(StudentOrganizer.GUI.Properties.Settings.Default.Connection);
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(@"SELECT firstName,
                                                            lastName,gender,birthDate,
                                                            email,phoneNumber,faculty,
                                                            facultyStartYear FROM Student", connection);
            sqlAdapter.Fill(dataTable);


            TableView.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudent = new AddStudentForm();
            addStudent.Show();
            this.Hide();
        }


    }
}
