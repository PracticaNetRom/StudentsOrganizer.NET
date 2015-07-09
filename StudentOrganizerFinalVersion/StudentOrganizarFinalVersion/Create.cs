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
    public partial class Create : Form
    {
        private Student student;
        private StudentOrganizerDBOp.StudentCommands studComm;

        public Create()
        {
            InitializeComponent();

            student = new Student();
            studComm = new StudentOrganizerDBOp.StudentCommands(Properties.Settings.Default.connection);

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            student.FirstName = FirstNameTextEdit.Text;
            student.LastName = LastNameTextEdit.Text;
            student.BirthDate = Convert.ToDateTime(BirthDateTextEdit.Text);
            student.PhoneNumber = PhoneNumberTextEdit.Text;
            student.Faculty = FacultyTextEdit.SelectedText;
            student.FacultyStartYear = FacultyStartTextEdit.SelectedText;
            student.Email = EmailTextEdit.Text;

            studComm.InsertStudent(student);

            FirstNameTextEdit.Text = null;
            LastNameTextEdit.Text = null;
            BirthDateTextEdit.Text = null;
            PhoneNumberTextEdit.Text = null;
            FacultyTextEdit.Text = null;
            EmailTextEdit = null;
            FacultyStartTextEdit.Text = null;
            FemaleButton.Checked = false;
            MaleButton.Checked = false;
            

        }

        private void BirthDateTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            student.Gender = "Male";
            FemaleButton.Checked = false;
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            student.Gender = "Female";
            MaleButton.Checked = false;
        }

        private void BackButton_CheckedChanged(object sender, EventArgs e)
        {
            MainPage andrei = new MainPage();
            andrei.Show();

            this.Hide();
        }
    }
}
