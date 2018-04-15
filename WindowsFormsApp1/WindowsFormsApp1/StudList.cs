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
        }


        DataBaseConnection conn = new DataBaseConnection();
        DbConnection cnn1;
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        BindingSource bd1 = new BindingSource();

        private void StudList_Load(object sender, EventArgs e)
        {
            cnn1 = conn.GetDatabeseConnection("UniDB");
            da = new SqlDataAdapter("select ИД_Студента, ФИОСтудента, Факультет, Направление from Студент", (SqlConnection)cnn1);
            da.Fill(ds, "Студент");
            dataGridView1.DataSource = ds.Tables["Студент"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1[0, 0].Value != null)
            {
                Global_ID.Stud_ID = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentCellAddress.Y].Value.ToString());
            }
        }
    }
}
