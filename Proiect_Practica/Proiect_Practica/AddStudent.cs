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
        public Students _stud { get; set; }

        public AddStudent(Students stud)
        {
            InitializeComponent();
            _stud = stud;
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

            bool add = _stud == null;
            if(add)
            {
                _stud = new Students();
            }
            _stud.Participants_Events = ParticipantsEvents.Text;
            _stud.First_Name = FirstName.Text;
            _stud.Last_Name = LastName.Text;
            _stud.Phone_Numbers = PhoneNumber.Text;
            _stud.Faculty = Faculty.Text;
            _stud.Male = dateNavigator1.Text;
            _stud.Email = Email.Text;
            _stud.Birth_date = Convert.ToDateTime(BirthDate.Text);
            _stud.Male = Female.Text;
            _stud.Male = Male.Text;
         //   _stud.Gender = Gender.Text;

            if (Male.Checked)
                _stud.Gender = "Male";
            else
                _stud.Gender = "Female";




            StudentsOperations studDbo = new StudentsOperations(Proiect_Practica.Properties.Settings.Default.Setting);
            if (add)
            {
                studDbo.InsertStudent(_stud);
            }
            else
            {
                studDbo.UpdateStudent(_stud);
            }
                    



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

private bool Gender_Click()
{
 	throw new NotImplementedException();
}

        private void LastName_Click(object sender, EventArgs e)
        {

        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            Male.Checked = false;
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            
            Female.Checked = false;
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

       /* private void btnEdit_Click(object sender, EventArgs e)
        {
            StudentsOperations studDbo;
            {
                StudentsOperations studDboo = new StudentsOperations(Proiect_Practica.Properties.Settings.Default.Setting);
                studDboo.UpdateStudent(_stud);

                _stud.First_Name = FirstName.Text;
                _stud.Last_Name = LastName.Text;
                _stud.Email = Email.Text;

                if (_stud.Gender.Equals("Male"))
                {
                    Male.Checked = true;
                    Female.Checked = false;
                }
                else
                {
                    Male.Checked = false;
                    Female.Checked = true;
                }
            }*/
        }
    }

    


