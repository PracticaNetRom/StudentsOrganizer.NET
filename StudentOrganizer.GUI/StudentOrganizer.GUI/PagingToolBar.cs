using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace StudentOrganizer.GUI
{
    public partial class PagingToolBar : XtraUserControl
    {

        public int step = 20;
        private int pageNR = 0;

        public PagingToolBar()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {

        }
    }
}
