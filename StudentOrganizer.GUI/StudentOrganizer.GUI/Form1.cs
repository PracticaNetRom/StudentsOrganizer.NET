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
using DevExpress.XtraEditors;

namespace StudentOrganizer.GUI
{
    public partial class LogInForm : XtraForm
    {
        private User user;
        private UserCommands userComm;
       
        public LogInForm()
        {
            InitializeComponent();

            user = new User();
            userComm = new UserCommands(StudentOrganizer.GUI.Properties.Settings.Default.Connection);

            passwordTextField.Properties.PasswordChar = '*';

            this.passwordTextField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
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
                MessageBox.Show("Wrong UserName or Password !");
            }
        }


        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
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
                    MessageBox.Show("Wrong UserName or Password !");
                }
            }
        }
    }
}
