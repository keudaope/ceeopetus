﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        private Form _firstForm;
        private Form _secondForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_secondForm == null)
                _secondForm = new Form2();

            Hide();
            _secondForm.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}