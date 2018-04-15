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
    public partial class StudInf : UserControl
    {
        public StudInf()
        {
            InitializeComponent();
        }

        DataBaseConnection conn = new DataBaseConnection();
        DbConnection cnn1;
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        BindingSource bd = new BindingSource();

        private void StudInf_Load(object sender, EventArgs e)
        {
            cnn1 = conn.GetDatabeseConnection("UniDB");
            da = new SqlDataAdapter("select ФИОСтудента, Факультет, Направление, EmailСтудента, ТелефонСтудента," +
                " НомерКартыСтудента, ОбоМне from Студент where ИД_Студента="+Convert.ToString(Global_ID.Stud_ID), (SqlConnection)cnn1);
            da.Fill(ds, "Студент");
            bd.DataSource = ds.Tables["Студент"];
            label1.DataBindings.Add("Text", bd, "ФИОСтудента");
            label2.DataBindings.Add("Text", bd, "Факультет");
            label3.DataBindings.Add("Text", bd, "Направление");
            label4.DataBindings.Add("Text", bd, "EmailСтудента");
            label5.DataBindings.Add("Text", bd, "ТелефонСтудента");
            label6.DataBindings.Add("Text", bd, "НомерКартыСтудента");
            label7.DataBindings.Add("Text", bd, "ОбоМне");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
