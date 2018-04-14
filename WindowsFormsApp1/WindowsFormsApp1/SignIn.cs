using System;
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
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            loginStud1.Visible = false;
            loginComp1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginStud1.Visible = true;
            loginComp1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginStud1.Visible = false;
            loginComp1.Visible = true;
        }
    }
}
