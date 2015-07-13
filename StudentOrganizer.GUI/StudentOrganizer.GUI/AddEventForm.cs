using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentOrganizer.Model.BO;
using StudentOrganizer.Model.DBOp;
using DevExpress.XtraEditors;

namespace StudentOrganizer.GUI
{
    public partial class AddEventForm : XtraForm
    {
        Event ev;
        EventCommands evCommands;

        public AddEventForm()
        {
            InitializeComponent();
            ev = new Event();
            evCommands = new EventCommands(StudentOrganizer.GUI.Properties.Settings.Default.Connection);

            DepartamentComboBox.Properties.Items.Add("WinForms");
            DepartamentComboBox.Properties.Items.Add("Java");
            DepartamentComboBox.Properties.Items.Add("Mobile");
        }

        private void SaveEventButton_Click(object sender, EventArgs e)
        {
           // ev.EventTypes_ID = Convert.ToInt32(eventTypeName.Text);
            ev.Period = Convert.ToDateTime(PeriodDate.Text);
            ev.Departament = DepartamentComboBox.Text;
            ev.Remarks = RemarksTextArea.Text;
            ev.Task = TaskTextArea.Text;

            evCommands.InsertEvent(ev,eventTypeName.Text);

            eventTypeName.Text = null;
            PeriodDate.Text = null;
            DepartamentComboBox.Text= null;
            RemarksTextArea.Text = null;
            TaskTextArea.Text = null;

            StudentsForm studForm = new StudentsForm();
            studForm.Show();
            this.Close();
        }

        private void eventTypeID_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void eventTypeIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {

        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDOWN = 0x00A1;
            const int HTCLOSE = 20;

            if (m.Msg == WM_NCLBUTTONDOWN)
            {
                switch ((int)m.WParam)
                {
                    case HTCLOSE:
                        StudentsForm studForm = new StudentsForm();
                        studForm.Show();
                        this.Close();
                        break;
                }
            }

            base.WndProc(ref m);
        }
    }
}
