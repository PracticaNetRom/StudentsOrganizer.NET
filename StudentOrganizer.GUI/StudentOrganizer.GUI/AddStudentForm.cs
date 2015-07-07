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
    public partial class AddStudentForm : Form
    {
        private Student student;
        private StudentCommands studComm;

        public AddStudentForm()
        {
            InitializeComponent();

            FacultyComboBox.Properties.Items.Add("Mate-Info");
            FacultyComboBox.Properties.Items.Add("Automatica");
            FacultyStartComboBox.Properties.Items.Add("2011");
            FacultyStartComboBox.Properties.Items.Add("2012");
            FacultyStartComboBox.Properties.Items.Add("2013");
            FacultyStartComboBox.Properties.Items.Add("2014");

            student = new Student();
            studComm = new StudentCommands(StudentOrganizer.GUI.Properties.Settings.Default.Connection);
           
        }

        private void BirthTextField_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FacultyDropDown_Click(object sender, EventArgs e)
        {
           
        }

        private void SaveStudentButton_Click(object sender, EventArgs e)
        {
            student.FirstName = FirstNameTextField.Text;
            student.LastName = LastNameTextField.Text;
            student.BirthDate = Convert.ToDateTime(BirthTimeEdit.Text);
            student.PhoneNumber = PhoneNumberTextField.Text;
            student.Faculty = FacultyComboBox.SelectedText;
            student.FacultyStartYear = Convert.ToInt32(FacultyStartComboBox.SelectedText);
            student.Email = EmailTextField.Text;

            studComm.InsertStudent(student);

            FirstNameTextField.Text = null;
            LastNameTextField.Text = null;
            BirthTimeEdit.Text = null;
            PhoneNumberTextField.Text = null;
            FacultyComboBox.Text = null;
            FacultyStartComboBox.Text = null;
            EmailTextField.Text = null;
            FamaleButton.Checked = false;
            MaleButton.Checked = false;

         
        }

        private void MaleButton_CheckedChanged(object sender, EventArgs e)
        {
            student.Gender = "Male";
            FamaleButton.Checked = false;
        }

        private void FamaleButton_CheckedChanged(object sender, EventArgs e)
        {
            student.Gender = "Famale";
            MaleButton.Checked = false;
        }
    }
}
