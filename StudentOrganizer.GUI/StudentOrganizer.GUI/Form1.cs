using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentOrganizer.Model.BO;
using StudentOrganizer.Model.DBOp;

namespace StudentOrganizer.GUI
{
    public partial class LogInForm : Form
    {
        private User user;
        private UserCommands userComm;
       
        public LogInForm()
        {
            InitializeComponent();

            user = new User();
            userComm = new UserCommands(StudentOrganizer.GUI.Properties.Settings.Default.Connection);

            passwordTextField.Properties.PasswordChar = '*';
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            user.UserName = userNameTextField.Text;
            user.Password = userComm.Sha256Encrypt(passwordTextField.Text);           

            if (userComm.LogIn(user) != 0)
            {
                this.Hide();
                StudentsForm studentForm = new StudentsForm();
                studentForm.Show();
            }
            else 
            {
                MessageBox.Show("User Name or Password are Wrong !");
            }
        }
    }
}
