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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void ReturnToAdminPannelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel AdminPanel = new AdminPanel();
            AdminPanel.Show();
        }

        private void SaveStudentButton_Click(object sender, EventArgs e)
        {

        }

        private void GenderDropDownButton_Click(object sender, EventArgs e)
        {

        }


    }
}
