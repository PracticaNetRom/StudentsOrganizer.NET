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

namespace StudentOrganizer.GUI
{
    public partial class AddEventForm : Form
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
            ev.EventTypes_ID = Convert.ToInt32(eventTypeID.Text);
            ev.Period = Convert.ToDateTime(PeriodDate.Text);
            ev.Departament = DepartamentComboBox.Text;
            ev.Remarks = RemarksTextBox.Text;
            ev.Task = TaskTextBox.Text;

            evCommands.InsertEvent(ev);

            eventTypeID.Text = null;
            PeriodDate.Text = null;
            DepartamentComboBox.Text= null;
            RemarksTextBox.Text = null;
            TaskTextBox.Text = null;

            this.Close();

            StudentsForm studForm = new StudentsForm();
            studForm.Show();
            this.Close();
        }
    }
}
