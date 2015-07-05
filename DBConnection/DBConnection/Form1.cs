using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBConnection.Model;
using System.Collections;


namespace DBConnection
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        Student student;
        StudentCommands studComm;

        public Form1()
        {
            InitializeComponent();
            student = new Student();


            con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();

            studComm = new StudentCommands(con);

            try
            {
                if (con.State == ConnectionState.Open)
                {
                    studentPanel.HidePopup();
                    studentAddPanel.HidePopup();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Connection not Ready!");
            }

        }      
        
                //ArrayList events = com.getEvents();
               
        private void studentPanel_Load(object sender, EventArgs e)
        {

        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            studentPanel.ShowPopup();
        }

        private void eventButton_Click(object sender, EventArgs e)
        {

        }

        private void studentEventButton_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        //buton adaugare student  - din sudentAddPanel
        private void finishAddStudent_Click(object sender, EventArgs e)
        {

            student.FirstName = firstName.Text;
            student.LastName = lastName.Text;
            student.PhoneNumber = phoneNumber.Text;
            student.Gender = gender.Text;
            student.Faculty = faculty.Text;
            student.FacultyStartYear = Convert.ToInt32(facultyStart.Text);
            student.Email = email.Text;
            student.BirthDate = Convert.ToDateTime(birthDate.Text);

            studComm.insertStudent(student);
            studentAddPanel.HidePopup();

            firstName.Text = null;
            lastName.Text = null;
            phoneNumber.Text = null;
            gender.Text = null;
            faculty.Text = null;
            facultyStart.Text = null;
            email.Text = null;
            birthDate.Text = null;

        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            studentPanel.HidePopup();
            studentAddPanel.ShowPopup();

        }

        private void updateStudent_Click(object sender, EventArgs e)
        {
            searchStudentPanel.ShowPopup();
            studentPanel.HidePopup();
            studentAddPanel.HidePopup();       

        }

        private void deleteStudent_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textEdit5_EditValueChanged(object sender, EventArgs e)
        {

        }

        //butonul de salvare modificari student
        private void updateButton_Click(object sender, EventArgs e)
        {
            searchPanel.HidePopup();

            student.FirstName = firstNameUpdate.Text;
            student.LastName = lastNameUpdate.Text;
            student.PhoneNumber = phoneUpdate.Text;
            student.Gender = genderUpdate.Text;
            student.Faculty = facultyUpdate.Text;
            student.FacultyStartYear = Convert.ToInt32(facultyStartUpdate.Text);
            student.Email = emailUpdate.Text;
            student.BirthDate = Convert.ToDateTime(birthUpdate.Text);

            studComm.updateStudent(student);          

        }

        //butonul de cautare student 
        private void searchStudentButton_Click(object sender, EventArgs e)
        {
            searchStudentPanel.HidePopup();
           

            student.Id = Convert.ToInt32(searchStudent.Text);

            student = studComm.searchStudent(student.Id);
            firstNameUpdate.Text = student.FirstName;
            lastNameUpdate.Text = student.LastName;
            genderUpdate.Text = student.Gender;
            phoneUpdate.Text = student.PhoneNumber;
            birthUpdate.Text = "" + student.BirthDate;
            facultyUpdate.Text = student.Faculty;
            facultyStartUpdate.Text = "" + student.FacultyStartYear;
            emailUpdate.Text = student.Email;

            searchPanel.ShowPopup();
           
        }

        private void updatePanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
