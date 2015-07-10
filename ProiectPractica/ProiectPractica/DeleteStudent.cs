using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPractica
{
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void BackButton1_Click(object sender, EventArgs e)
        {
            StudentsList sl = new StudentsList();
            sl.Show();
            this.Close();
        }
    }
}
