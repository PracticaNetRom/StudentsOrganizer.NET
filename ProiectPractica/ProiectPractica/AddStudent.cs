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
        private Student _student;
        private StudentOperations studOp;
        
        public AddStudent(Student student)
        {
            InitializeComponent();

            comboBoxEdit1.Properties.Items.Add("Mate-Info");
            comboBoxEdit1.Properties.Items.Add("Automatica");

            comboBoxEdit2.Properties.Items.Add("2011");
            comboBoxEdit2.Properties.Items.Add("2012");
            comboBoxEdit2.Properties.Items.Add("2013");
            comboBoxEdit2.Properties.Items.Add("2014");

            _student = student;
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
            
        }

        private void MaleCheck_CheckedChanged(object sender, EventArgs e)
        {
            
            FemaleCheck.Checked = false;

        }

        private void FemaleCheck_CheckedChanged(object sender, EventArgs e)
        {
           
            MaleCheck.Checked = false;

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            bool add = _student == null;

            if (add)
            {
                _student = new Student();
            }
            if (MaleCheck.Checked)
            {
                _student.Gender = "Male";
            }
            else {
                _student.Gender = "Female";
            }
            _student.FName = textEdit1.Text;
            _student.LName = textEdit2.Text;
            _student.Birthdate = Convert.ToDateTime(dateEdit1.Text);
            _student.PhoneNumbers = textEdit4.Text;
            _student.Email = textEdit3.Text;
            _student.Faculty = comboBoxEdit1.SelectedText;
            _student.FacultyStartYear = comboBoxEdit2.SelectedText;
            if (add) {
                studOp.InsertStudent(_student);
            }
            else
            {
                studOp.UpdateStudent(_student);

            }
            

            textEdit1.Text = null;
            textEdit2.Text = null;
            dateEdit1.Text = null;
            textEdit4.Text = null;
            comboBoxEdit1.Text = null;
            comboBoxEdit2.Text = null;
            textEdit3.Text = null;
            FemaleCheck.Checked = false;
            MaleCheck.Checked = false;

            this.Hide();
            this.Close();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            if (_student != null) {
                textEdit1.Text = _student.FName ;
                textEdit2.Text = _student.LName;
                dateEdit1.DateTime = _student.Birthdate;
                textEdit4.Text = _student.PhoneNumbers;
                textEdit3.Text = _student.Email;
                comboBoxEdit1.SelectedText = _student.Faculty;
                comboBoxEdit2.SelectedText = _student.FacultyStartYear;
            }
        }
    }
}
