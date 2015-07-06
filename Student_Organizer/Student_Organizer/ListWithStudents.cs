using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Organizer
{
    public partial class ListWithStudents : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public ListWithStudents()
        {
            InitializeComponent();
            ShowList();
         
        }

        public int ShowList()
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.connection);
            connection.Open();
            sda = new SqlDataAdapter(@"SELECT Students.ID, Students.FirstName, Students.LastName, Students.PhoneNumber, Students.Faculty, Students.FacultyStartYear FROM Students", connection);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            ShowList();
        }

    }
}
