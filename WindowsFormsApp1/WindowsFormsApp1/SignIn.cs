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
            userControl31.Visible = false;
            loginComp1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 DataSet = new Form1();
            //DataSet.Show();
            //this.ParentForm.Visible = false;
            //userControl11.BringToFront();
            userControl31.Visible = true;
            loginComp1.Visible = false;

        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl31.Visible = false;
            loginComp1.Visible = true;
        }
    }
}
