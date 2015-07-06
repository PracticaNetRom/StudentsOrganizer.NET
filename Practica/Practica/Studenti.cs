using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Practica
{
    public partial class Evidenta : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SNAP;Initial Catalog=Evidenta;Integrated Security=True");
        SqlCommand cmd;

        public Evidenta()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO [dbo].[Evidenta] ([ID], [FirstName], [LastName], [Gender], [BirthDate], [Faculty], [FacultyStartYear]) values('" + idText.Text + "','" + nameText.Text + "','" + LastText.Text + "','" + genderText.Text + "','" + data1.Value.ToString("dd/MM/yyyy") + "','" + facText.Text + "','" + data2.Value.ToString("dd/MM/yyyy") + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfull to the Database");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Events ev = new Events();
            ev.Show();
        }
    }
}
