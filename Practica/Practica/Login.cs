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


namespace Practica
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SNAP;Initial Catalog=Login;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Login where user='" + user1.Text + "' and password ='" + pass.Text + "'", con);
            SqlDataReader read;
            read = cmd.EndExecuteReader(I);
            int count = 0;
            while (read.Read())
            {
                count += 1;

            }
            if (count == 1)
            {
                MessageBox.Show("Successful");

                Form Studenti = new Form();
                Studenti.Show();

            }
            else if (count > 0)
            {
                MessageBox.Show("Dublicate");

            }
            else
            {
                MessageBox.Show("UserName or Passord note correct");

            }
            user1.Clear();
            pass.Clear();
        }

        public IAsyncResult I { get; set; }
    }
        }
    

