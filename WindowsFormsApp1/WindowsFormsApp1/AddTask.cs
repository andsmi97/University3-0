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
    public partial class AddTask : UserControl
    {
        public AddTask()
        {
            InitializeComponent();
        }
        DataBaseConnection conn = new DataBaseConnection();
        DbConnection cnn;
        SqlDataAdapter da1;
        SqlDataAdapter da2;
        SqlDataAdapter da3;
        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand();
        Data
        private void AddTask_Load(object sender, EventArgs e)
        {
            cnn.ConnectionString = "Data Source=DESKTOP-UGM0GFJ\\ANDREW;Initial Catalog=Uni3;Integrated Security=True";
            cmd.Connection = (SqlConnection)cnn;
            
            bd1.DataSource = ds.Tables[0];
            textBox1.Enabled = false;
            textBox1.DataBindings.Add("Text", bd1, "ApplicationID");
            textBox2.DataBindings.Add("text", bd1, "ApplicationName");
            textBox3.DataBindings.Add("Text", bd1, "Version");
            textBox4.DataBindings.Add("Text", bd1, "Price");
            listBox1.DataSource = ds.Tables[0];
            listBox1.DisplayMember = "ApplicationDescription";
            listBox1.DataBindings.Add("Text", bd1, "ApplicationDescription");
        }
    }
}
