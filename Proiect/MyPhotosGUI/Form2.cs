﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotosGUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMedias_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.ShowDialog();
        }

        private void btnZones_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            f4.ShowDialog();
        }

        private void btnPeopleGroups_Click(object sender, EventArgs e)
        {
            Form f5 = new Form5();
            f5.ShowDialog();
        }
    }
}
