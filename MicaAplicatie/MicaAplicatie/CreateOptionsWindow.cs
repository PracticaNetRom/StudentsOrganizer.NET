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
    public partial class CreateOptionsWindow : Form
    {
        public CreateOptionsWindow()
        {
            InitializeComponent();
        }

        private void SelectAddEventButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEvent AddEventWindow = new AddEvent();
            AddEventWindow.Show();
        }

        private void SelectAddStudentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudent AddStudentWindow = new AddStudent();
            AddStudentWindow.Show();

        }

        private void ReturnToAdminPannelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel AdminPanelWindow = new AdminPanel();
            AdminPanelWindow.Show();
        }
    }
}
