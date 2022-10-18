﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SlidePanel.Height = buttonHome.Height;
            firstCustomControl1.BringToFront();
            SlidePanel.Top = buttonHome.Top;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = buttonHome.Height;
            SlidePanel.Top = buttonHome.Top;
            firstCustomControl1.BringToFront();
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            SlidePanel.Top = buttonHome.Top;
        }
    }
}
