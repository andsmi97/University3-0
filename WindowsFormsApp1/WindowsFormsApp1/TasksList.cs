﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TasksList : UserControl
    {
        public TasksList()
        {
            InitializeComponent();
            task1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            task1.Visible = true;
        }
    }
}
