using StudentOrganizer.BO;
using StudentOrganizer.DBOp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentOrganizarFinalVersion
{
    public partial class EditEvent : Form
    {
        Event event1;
        EventCommands eventComm;

        public EditEvent(Event event1)
        {
            InitializeComponent();
            this.event1 = event1;
            eventComm = new EventCommands(Properties.Settings.Default.connection);

            PeriodTextEdit.Text = event1.Period;
            DepartmentTextEdit.Text = event1.Department;
            TaskTextEdit.Text = event1.Task;
            RemarksTextEdit.Text = event1.Remarks;
            EventTypeTextEdit.Text = (event1.Event_Type_ID).ToString();

        }

        private void PeriodTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
