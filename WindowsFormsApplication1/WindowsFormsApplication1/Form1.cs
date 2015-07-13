using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            userControl11.ButtonClicked += userControl11_ButtonClicked;
        }

        void userControl11_ButtonClicked()
        {
            MessageBox.Show("User Control button clicked");
        }
    }
}
