using StudentOrganiser.Model.BO;
using StudentORganiser.Model.DBOp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicaAplicatie
{
    public partial class LoginWindow : Form
    {

        private UserBO user;
        private UserDBOP userOP;

        public LoginWindow()
        {
            InitializeComponent();
            user = new UserBO();
            userOP = new UserDBOP(MicaAplicatie.Properties.Settings.Default.DBConnection);

            PasswordField.Properties.PasswordChar = '*';
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            user.UserName = UsernameField.Text;
            user.Password = PasswordField.Text;

            if (userOP.LogIn(user) != 0) 
            {
                this.Hide();
                AdminPanel AdminPanel = new AdminPanel();
                AdminPanel.Show();
            }
            else 
            {
                MessageBox.Show("Wrong username or password!");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
