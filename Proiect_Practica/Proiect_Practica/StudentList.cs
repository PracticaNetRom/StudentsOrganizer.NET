using StudentsOrganizer.DBO;
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

namespace Proiect_Practica
{
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            GetStudents();

           /* SqlConnection con = new SqlConnection(Proiect_Practica.Properties.Settings.Default.Setting);
            SqlDataAdapter sda = new SqlDataAdapter("Select * From STUDENTS", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gridControl1.DataSource = dt;*/
            
        }
        

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID;
            ID= (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID_Student");
            StudentsOperations stdop = new StudentsOperations(Proiect_Practica.Properties.Settings.Default.Setting);
            stdop.DeleteStudents(ID);
            GetStudents();
        }

        private void GetStudents()
        {
            SqlConnection con = new SqlConnection(Proiect_Practica.Properties.Settings.Default.Setting);
            SqlDataAdapter sda = new SqlDataAdapter("Select * From STUDENTS", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }


        
    }
}
