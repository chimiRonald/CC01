﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace frmParent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Frmuser frmuser = new Frmuser();
            frmuser.Show();
        }

        private void creerUneCarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmuser frmuser = new Frmuser();
            frmuser.Show();
        }
    }
}
