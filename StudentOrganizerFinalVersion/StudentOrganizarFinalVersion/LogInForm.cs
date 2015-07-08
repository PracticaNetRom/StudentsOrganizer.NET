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
using StudentOrganizer.BO;
using StudentOrganizer.DBOp;
using System.Collections;


namespace StudentOrganizarFinalVersion
{
    public partial class LogIn : Form
    {
        SqlConnection connection;
        Student student;
        StudentCommands studComm;

        public LogIn()
        {
            InitializeComponent();
            student = new Student();
            
        }

       
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.connection);
                connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From LogIn Where Username='" + textEdit1.Text + "'and Password='" + textEdit2.Text + "'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MainPage andrei = new MainPage();
                    andrei.Show();

                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Please check your username and password");
                }

            }
            //MainPage andrei = new MainPage();
            //andrei.Show();

            //this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
