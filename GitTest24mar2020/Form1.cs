﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTest24mar2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoTspr_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void btnGoTwoTspr_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 2");
        }
    }
}
