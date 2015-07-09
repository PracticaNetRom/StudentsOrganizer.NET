﻿using DevExpress.XtraGrid;
using StudentOrganizer.BO;
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

namespace StudentOrganizarFinalVersion
{
    public partial class List : Form
    {
        Student stud;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public List()
        {
            InitializeComponent();
            CreateDataTable();
            stud = new Student();
            
        }

        public void CreateDataTable()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(StudentOrganizarFinalVersion.Properties.Settings.Default.connection);
            connection.Open();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(@"SELECT id,firstName,
                                                            lastName,gender,birthDate,
                                                            email,phoneNumber,faculty,
                                                            facultyStartYear FROM Student", connection);
            sqlAdapter.Fill(dataTable);
            
            GridControl.DataSource = dataTable;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Create andrei = new Create();
            andrei.Show();

            this.Hide();
        }
    }
}
