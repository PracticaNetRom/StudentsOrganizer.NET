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

        public delegate void ClickHandler();
        public event ClickHandler BackButtonClicked;
        public event ClickHandler NextButtonClicked;
   


        public PagingToolBar()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (BackButtonClicked != null) 
            {
                BackButtonClicked();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (NextButtonClicked != null)
            {
                NextButtonClicked();
            }
        }

       

    }
}
