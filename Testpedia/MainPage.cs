﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testpedia
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void testmaker_Click(object sender, EventArgs e)
        {
            MakeTest maketest = new MakeTest();
            maketest.Show();

        }

        private void browse_Click(object sender, EventArgs e)
        {

        }
    }
}