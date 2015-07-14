﻿using System;
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
using DevExpress.XtraEditors.Controls;
using System.Text.RegularExpressions;
using DevExpress.XtraEditors;


namespace StudentOrganizer.GUI
{
    public partial class AddStudentForm : XtraForm
    {
        private Student student;
        private StudentCommands studComm;
        private EventTypes evTypes;
        private EventTypesCommands evTypesComm;
        private StudentEvent studEvent;
        private StudentEventCommands studEvCommands;
        List<EventTypes> evTypesList;

        public AddStudentForm()
        {
            InitializeComponent();

            FacultyComboBox.Properties.Items.Add("Mate-Info");
            FacultyComboBox.Properties.Items.Add("Automatica");

            FacultyStartComboBox.Properties.Items.Add("2011");
            FacultyStartComboBox.Properties.Items.Add("2012");
            FacultyStartComboBox.Properties.Items.Add("2013");
            FacultyStartComboBox.Properties.Items.Add("2014");
            GenderComboBox.Properties.Items.Add("Male");
            GenderComboBox.Properties.Items.Add("Female");

            student = new Student();
            evTypes = new EventTypes();
            studEvent = new StudentEvent();

            studComm = new StudentCommands(StudentOrganizer.GUI.Properties.Settings.Default.Connection);
            studEvCommands = new StudentEventCommands(StudentOrganizer.GUI.Properties.Settings.Default.Connection);
            evTypesComm = new EventTypesCommands(StudentOrganizer.GUI.Properties.Settings.Default.Connection);

            evTypesList = evTypesComm.GetEventTypes();

            for (int i = 0; i < evTypesList.Count; i++) 
            {
                eventListCheckBox.Properties.Items.Add(evTypesList[i].Description);
            }        
                       
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
            student.Gender = GenderComboBox.Text;

            List<string> checkedList = (eventListCheckBox.EditValue ?? "").ToString().Split(eventListCheckBox.Properties.SeparatorChar).Select(i => Convert.ToString(i)).ToList();


            
            studComm.InsertStudent(student);

            for (int i = 0; i < checkedList.Count; i++)
            {
                for (int j = 0; j < evTypesList.Count; j++) 
                {
                    String verifyString = Regex.Replace(checkedList[i],@" ","");
                    String baseString = Regex.Replace(evTypesList[j].Description, @" ", "");

                    if (verifyString.Equals(baseString)) 
                    {
                        studEvCommands.InsertStudentEventUsingEventName(verifyString);
                    }
                }
            }
          
            FirstNameTextField.Text = null;
            LastNameTextField.Text = null;
            BirthTimeEdit.Text = null;
            PhoneNumberTextField.Text = null;
            FacultyComboBox.Text = null;
            FacultyStartComboBox.Text = null;
            EmailTextField.Text = null;
            GenderComboBox.Text = null;

            this.Close();
            StudentsForm studentForm = new StudentsForm();
            studentForm.Show();
         
        }

        private void MaleButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void FamaleButton_CheckedChanged(object sender, EventArgs e)
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