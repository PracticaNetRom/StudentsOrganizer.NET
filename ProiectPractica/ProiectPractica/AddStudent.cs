using ProiectPractica.Model.DBOp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProiectPractica
{
    public partial class AddStudent : Form
    {
        private Student student;
        private StudentOperations studOp;
        public AddStudent()
        {
            InitializeComponent();

            comboBoxEdit1.Properties.Items.Add("Mate-Info");
            comboBoxEdit1.Properties.Items.Add("Automatica");

            comboBoxEdit2.Properties.Items.Add("2011");
            comboBoxEdit2.Properties.Items.Add("2012");
            comboBoxEdit2.Properties.Items.Add("2013");
            comboBoxEdit2.Properties.Items.Add("2014");

            student = new Student();
            studOp = new StudentOperations(ProiectPractica.Properties.Settings.Default.DBConnection);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            student.FName = textEdit1.Text;
            student.LName = textEdit2.Text;
            student.Birthdate = Convert.ToDateTime(comboBoxEdit3.Text);
            student.PhoneNumbers = textEdit4.Text;
            student.Email = textEdit3.Text;
            student.Faculty = comboBoxEdit1.SelectedText;
            student.FacultyStartYear = Convert.ToInt32(comboBoxEdit2.SelectedText);

            studOp.InsertStudent(student);

            textEdit1.Text = null;
            textEdit2.Text = null;
            comboBoxEdit3.Text = null;
            textEdit4.Text = null;
            comboBoxEdit1.Text = null;
            comboBoxEdit2.Text = null;
            textEdit3.Text = null;
            FemaleCheck.Checked = false;
            MaleCheck.Checked = false;
            
            this.Hide();
            StudentsList studentForm = new StudentsList();
            studentForm.Show();
        }

        private void MaleCheck_CheckedChanged(object sender, EventArgs e)
        {
            student.Gender = "Male";
            FemaleCheck.Checked = false;

        }

        private void FemaleCheck_CheckedChanged(object sender, EventArgs e)
        {
            student.Gender = "Female";
            MaleCheck.Checked = false;

        }
    }
}
