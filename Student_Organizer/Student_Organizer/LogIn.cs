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


namespace Student_Organizer
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.connection);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LogIn WHERE Username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "' ", connection);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            int count = 0;

            while(dr.Read())
            {
                count += 1;
            }

            if(count == 1)
            { 
                MainForm andrei = new MainForm();
                andrei.Show();
                
                
            }

            else if(count > 0)
            {
                MessageBox.Show("Duplicate username");
            }

            else
            {
                MessageBox.Show("Username or password is incorrect!");
            }

            textBox1.Clear();
            textBox2.Clear();
            this.Hide();
          
           

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
