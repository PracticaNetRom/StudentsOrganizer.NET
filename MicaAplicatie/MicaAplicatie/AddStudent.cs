using StudentOrganiser.Model.BO;
using StudentORganiser.Model.DBOp;
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
    public partial class AddStudent : Form
    {

        private Student student;
        private StudentDBOP studComm;
        private EventTypes evTypes;
        private EventTypesDBOP evTypesComm;
        private StudentEvent studEvent;
        private StudentEventDBOP studEvCommands;
        List<EventTypes> evTypesList;

        public AddStudent()
        {
            InitializeComponent();

            student = new Student();
            evTypes = new EventTypes();
            studEvent = new StudentEvent();

            studComm = new StudentDBOP(Properties.Settings.Default.DBConnection);
            studEvCommands = new StudentEventDBOP(Properties.Settings.Default.DBConnection);
            evTypesComm = new EventTypesDBOP(Properties.Settings.Default.DBConnection);

            evTypesList = evTypesComm.GetEventTypes();


        }

        private void ReturnToAdminPannelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel AdminPanel = new AdminPanel();
            AdminPanel.Show();
        }

        private void SaveStudentButton_Click(object sender, EventArgs e)
        {
            student.FirstName = FstNameTextEdit.Text;
            student.LastName = LstNameTextEdit.Text;
            student.BirthDate = Convert.ToDateTime(BirthDateDateEdit.Text);
            student.PhoneNumber = PhoneNumberTextEdit.Text;
            student.Faculty = FacultyTextEdit.Text;
            student.FacultyStartYear = Convert.ToInt32(FacultyStartYearTextEdit.Text);
            student.Email = EmailTextEdit.Text;
            student.Gender = GenderComboBox.Text;

            studComm.InsertStudent(student);
        }

        private void GenderDropDownButton_Click(object sender, EventArgs e)
        {

        }


        


       
        

    }
}
