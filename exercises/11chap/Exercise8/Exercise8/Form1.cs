﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercise8
{
    public partial class MainForm : Form
    {
        Car[] cars;
        Car c = new Car();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            new CarDetails(c).ShowDialog();
            //lblInformation.Text = System.IO.Directory.GetCurrentDirectory();
        }
    }
}