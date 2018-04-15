using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace WindowsFormsApp1
{
    public partial class StudList : UserControl
    {
        public StudList()
        {
            InitializeComponent();
            studInf1.Visible = false;
        }
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn1 = new SqlConnection();
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        BindingSource bd1 = new BindingSource();
        private void button1_Click(object sender, EventArgs e)
        {
            studInf1.Visible = true;
            if (dataGridView1[0, 0].Value != null)
            {
                Global_ID.Stud_ID = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentCellAddress.Y].Value.ToString());
            }

        }

        private void studInf1_Load(object sender, EventArgs e)
        {
            //cnn1.ConnectionString = "Data Source=DESKTOP-5R6MQVO\\ALINA;Initial Catalog=Uni3;Integrated Security=True";
            //cmd.Connection = (SqlConnection)cnn1;
            //da = new SqlDataAdapter("select ИД_Студента, ФИОСтудента, Факультет, Направление from Студент", (SqlConnection)cnn1);
            //da.Fill(ds, "Студент");
            //dataGridView1.DataSource = ds.Tables["Студент"];

        }

        private void StudList_Load(object sender, EventArgs e)
        {
            cnn1.ConnectionString = "Data Source=DESKTOP-5R6MQVO\\ALINA;Initial Catalog=Uni3;Integrated Security=True";
            cmd.Connection = (SqlConnection)cnn1;
            da = new SqlDataAdapter("select ИД_Студента, ФИОСтудента, Факультет, Направление from Студент", (SqlConnection)cnn1);
            da.Fill(ds, "Студент");
            dataGridView1.DataSource = ds.Tables["Студент"];
        }
    }
}
