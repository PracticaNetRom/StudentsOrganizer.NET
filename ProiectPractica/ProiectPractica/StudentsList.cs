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
using ProiectPractica.Model.DBOp;

namespace ProiectPractica
{
    public partial class StudentsList : Form
    {
        public StudentsList()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            LoadData();
           

        }

        private void btnCreateNew_click(object sender, EventArgs e)
        {
            AddStudent add = new AddStudent();
            add.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            id = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id_student");
            
            StudentOperations studop = new StudentOperations(ProiectPractica.Properties.Settings.Default.DBConnection);
            
            studop.DeleteStudent(id);
            LoadData();

        }
        private void LoadData() {
            
            SqlConnection con = new SqlConnection(ProiectPractica.Properties.Settings.Default.DBConnection);
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Student", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gridControl1.DataSource = dt;

        }

        

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
