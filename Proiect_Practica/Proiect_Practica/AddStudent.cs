using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentsOrganizerModel.BO;
using StudentsOrganizer.DBO;


namespace Proiect_Practica
{
    public partial class AddStudent : Form
    {

        public Students stud { get; set; }
        public AddStudent()
        {

            InitializeComponent();



            //  student = new Student();
            //  studCom = new StudentCommands(StudentOrganizer.GUI.Properties.Settings.Default.Connection);
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FisrstNameControl2_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            Students student = new Students();


            student.Participants_Events = ParticipantsEvents.Text;
            student.First_Name = FirstName.Text;
            student.Last_Name = LastName.Text;
            student.Phone_Numbers = PhoneNumber.Text;
            student.Faculty = Faculty.Text;
            student.Male = dateNavigator1.Text;
            student.Email = Email.Text;
            student.Birth_date = Convert.ToDateTime(BirthDate.Text);
            student.Male = Female.Text;
            student.Male = Male.Text;
            student.Gender = Gender.Text;

            StudentsOperations studDbo = new StudentsOperations(Proiect_Practica.Properties.Settings.Default.Setting);
            studDbo.InsertStudent(student);



            Gender.Text = null;
            ParticipantsEvents.Text = null;
            FirstName.Text = null;
            LastName.Text = null;
            Email.Text = null;
            PhoneNumber.Text = null;
            Faculty.Text = null;
            FirstName.Text = null;
            dateNavigator1.Text = null;
            BirthDate.Text = null;
            Female.Text = null;
            Male.Text = null;


        }

        public Students student { get; set; }

        private void LastName_Click(object sender, EventArgs e)
        {

        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            student.Gender = "Famale";
            Female.Checked = false;
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            student.Gender = "Male";
            Male.Checked = false;
        }

        private void BirthDate_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void Faculty_Click(object sender, EventArgs e)
        {

        }

        private void Faculty_start_year_Click(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        public string year { get; set; }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Students stud;
            StudentsOperations studDbo;
            // public   EditStudentForm(Student stud)
            {
                InitializeComponent();
                this.stud = stud;

                StudentsOperations studDboo = new StudentsOperations(Proiect_Practica.Properties.Settings.Default.Setting);
                studDboo.InsertStudent(student);

                student.First_Name = FirstName.Text;
                student.Last_Name = LastName.Text;
                student.Email = Email.Text;

                if (stud.Gender.Equals("Male"))
                {
                    Male.Checked = true;
                    Female.Checked = false;
                }
                else
                {
                    Male.Checked = false;
                    Female.Checked = true;
                }
            }
        }
    }
}
    


