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
            
            
            student.Participants_Events  = textEdit1.Text;
            student.First_Name  = textEdit2.Text;
            student.Last_Name   = textEdit3 .Text;
            student.Phone_Numbers = textEdit5.Text;
            student.Faculty = textEdit6.Text;
            student.Male = dateNavigator1.Text;
            student.Email = textEdit4.Text;
            student.Birth_date = Convert.ToDateTime(dateTimePicker1.Text);
            student.Male = checkEdit1.Text;
            student.Male = checkEdit2.Text;
            student.Gender = labelControl4.Text;

            StudentCommands studComm = new StudentCommands(Proiect_Practica.Properties.Settings.Default.Setting);



            labelControl4.Text=null;
            textEdit1.Text = null;
            textEdit2.Text = null;
            textEdit3.Text = null;
            textEdit4.Text = null;
            textEdit5.Text = null;
            textEdit6.Text = null;
            textEdit2.Text = null;
            dateNavigator1.Text = null;
            dateTimePicker1.Text = null;
            checkEdit1.Text = null;
            checkEdit2.Text = null;
            
            this.Hide();
            StudentsForm studentForm = new StudentsForm();
            studentForm.Show();
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
            checkEdit1.Checked = false;
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            student.Gender = "Male";
            checkEdit2.Checked = false;
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
    }
}
