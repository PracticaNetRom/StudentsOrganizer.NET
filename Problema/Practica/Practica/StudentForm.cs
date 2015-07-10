using StudentOrg.Model.BO;
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

namespace Practica
{
    public partial class StudentForm : Form
    {
      
        public StudentForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.FirstName = nameText.Text;
            st.LastName = LastText.Text;
            st.Gender = genderText.Text;
            st.BirthDate = birth.DateTime;
            st.Faculty = facText.Text;
            st.FacultyStartYear = start.DateTime;
            

        }
        

        }
       
    }

