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
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
        }

        private void SaveStudentEditButton_Click(object sender, EventArgs e)
        {

        }

        private void ReturnToAdminPannelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateOptionsWindow AdminPanel = new CreateOptionsWindow();
            AdminPanel.Show();
        }
    }
}
