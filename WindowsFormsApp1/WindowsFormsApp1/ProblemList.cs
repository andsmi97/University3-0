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
    public partial class ProblemList : UserControl
    {
        SqlDataAdapter da1;
        SqlDataAdapter da2;
        SqlDataAdapter da3;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();
        public ProblemList()
        {
            InitializeComponent();
            problem1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1[0, 0].Value != null)
            {
                Global_ID.Problem_ID = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentCellAddress.Y].Value.ToString());
            }
            problem1.Visible = true;
        }

        private void ProblemList_Load(object sender, EventArgs e)
        {
            cnn.ConnectionString = "Data Source=DESKTOP-5R6MQVO\\ALINA;Initial Catalog=Uni3;Integrated Security=True";
            //cmd.Connection = cnn;
            //cmd.Parameters.AddWithValue("@StudID", Gloal_ID.Stud_ID);
            cmd.CommandText = "SELECT DISTINCT НаправлениеПроблемы FROM Проблема;";
            cnn.Open();
            da1 = new SqlDataAdapter(cmd.CommandText, cnn);
            da1.Fill(ds);
            dataGridView1.DataSource = dt;
            cnn.Close();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "НаправлениеПроблемы";
            comboBox1.ValueMember = "НаправлениеПроблемы";


            ////cmd.Parameters.AddWithValue("@StudID", Gloal_ID.Stud_ID);
            //cmd.CommandText = "SELECT * FROM Проблема;";
            ////cnn.Open();
            //da2 = new SqlDataAdapter(cmd.CommandText, cnn);
            //da2.Fill(dt);
            //dataGridView1.DataSource = dt;
            ////cnn.Close();
            //cmd.Parameters.AddWithValue("@cbValue", comboBox1.SelectedItem);
            //cmd.CommandText = "SELECT * FROM Проблема WHERE НаправлениеПроблемы=@cbValue";
            //da2 = new SqlDataAdapter(cmd.CommandText, cnn);
            //da2.Fill(dt);
            //dataGridView1.DataSource = dt;
        }
    }
}
