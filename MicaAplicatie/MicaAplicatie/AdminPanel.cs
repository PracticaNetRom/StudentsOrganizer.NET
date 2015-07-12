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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateOptionsWindow ChooseEntryTypeWindow = new CreateOptionsWindow();
            ChooseEntryTypeWindow.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditStudent EditStudentWindow = new EditStudent();
            EditStudentWindow.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteStudent DeleteStudentWindow = new DeleteStudent();
            DeleteStudentWindow.Show();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginWindow StartWindow = new LoginWindow();
            StartWindow.Show();
        }
    }
}
