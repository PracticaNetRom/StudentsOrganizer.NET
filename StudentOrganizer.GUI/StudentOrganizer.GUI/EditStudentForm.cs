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
    public partial class EditStudentForm : Form
    {
        Student stud;
        StudentCommands studComm;
        public EditStudentForm(Student stud)
        {
            InitializeComponent();
            this.stud = stud;
            studComm = new StudentCommands(StudentOrganizer.GUI.Properties.Settings.Default.Connection);

            FirstNameTextField.Text = stud.FirstName;
            LastNameTextField.Text = stud.LastName;
            PhoneNumberTextField.Text = stud.PhoneNumber;

            if (stud.Gender.Equals("Male"))
            {
                MaleButton.Checked = true;
                FamaleButton.Checked = false;
            }
            else 
            {
                MaleButton.Checked = false;
                FamaleButton.Checked = true;
            }

            FacultyComboBox.Properties.Items.Add("Mate-Info");
            FacultyComboBox.Properties.Items.Add("Automatica");

            FacultyStartComboBox.Properties.Items.Add("2011");
            FacultyStartComboBox.Properties.Items.Add("2012");
            FacultyStartComboBox.Properties.Items.Add("2013");
            FacultyStartComboBox.Properties.Items.Add("2014");
            
            BirthTimeEdit.Text = "" + stud.BirthDate;
            EmailTextField.Text = stud.Email;

        }

        private void SaveEditButton_Click(object sender, EventArgs e)
        {
            stud.FirstName = FirstNameTextField.Text;
            stud.LastName = LastNameTextField.Text;
            stud.PhoneNumber = PhoneNumberTextField.Text;
            stud.Email = EmailTextField.Text;
            stud.BirthDate = Convert.ToDateTime(BirthTimeEdit.Text);
            stud.Faculty = FacultyComboBox.Text;
            stud.FacultyStartYear = Convert.ToInt32(FacultyStartComboBox.Text);

            studComm.UpdateStudent(stud);

            FirstNameTextField.Text = null;
            LastNameTextField.Text = null;
            PhoneNumberTextField.Text = null;
            BirthTimeEdit.Text = null;
            FacultyStartComboBox.Text = null;
            FacultyComboBox.Text = null;
            EmailTextField.Text = null;
            FamaleButton.Text = null;
            MaleButton.Text = null;

            StudentsForm studForm = new StudentsForm();
            studForm.Show();
            this.Close();
        }

        private void MaleButton_CheckedChanged(object sender, EventArgs e)
        {
            stud.Gender = "Male";
            FamaleButton.Checked = false;
        }

        private void FamaleButton_CheckedChanged(object sender, EventArgs e)
        {
            stud.Gender = "Famale";
            MaleButton.Checked = false;
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
                        StudentsForm studentForm = new StudentsForm();
                        studentForm.Show();
                        this.Close();
                        break;
                }
            }

            base.WndProc(ref m);
        }
    }
}
