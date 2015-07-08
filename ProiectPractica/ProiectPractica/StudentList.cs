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

namespace ProiectPractica
{
    public partial class StudentList : Form
    {
        public StudentList()
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
            SqlConnection con = new SqlConnection(ProiectPractica.Properties.Settings.Default.DBConnection);
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Student", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gridControl1.DataSource = dt;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AddStudent add = new AddStudent();
            add.Show();
        }
    }
}
