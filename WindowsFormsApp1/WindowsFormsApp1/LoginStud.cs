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
    public partial class LoginStud : UserControl
    {
        public LoginStud()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StudMain DataSet = new StudMain();
            DataSet.Show();
            this.ParentForm.Visible = false;
           // DataSet.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false; 
        }
    }
}
