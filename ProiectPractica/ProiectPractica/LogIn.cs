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

namespace ProiectPractica
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            this.textEdit2.Properties.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "user";
            string password = "1234";

            if ((textEdit1.Text == username) && (textEdit2.Text == password))
            {
                StudentsList sl = new StudentsList();
                sl.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please check your username and password");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
