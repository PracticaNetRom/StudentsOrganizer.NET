﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicaAplicatie
{
    public partial class AddEvent : Form
    {
        public AddEvent()
        {
            InitializeComponent();
        }

        private void SaveEventButton_Click(object sender, EventArgs e)
        {

        }

        private void ReturnToAdminPannelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel AdminPanel = new AdminPanel();
            AdminPanel.Show();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }
    }
}