using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class ProblemView : UserControl
    {

        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();
        SqlDataAdapter da1;
        SqlDataAdapter da2;
        SqlDataAdapter da3;
        DataSet ds = new DataSet();
        public ProblemView()
        {
            InitializeComponent();
            addProblem1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addProblem1.Visible = true;
        }

        private void addProblem1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
