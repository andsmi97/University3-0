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
    public partial class AddProblem : UserControl
    {
        public AddProblem()
        {
            InitializeComponent();
        }

        DataBaseConnection conn = new DataBaseConnection();
        DbConnection cnn1;
        SqlCommand cmd = new SqlCommand();

        private void AddProblem_Load(object sender, EventArgs e)
        {
            cnn1 = conn.GetDatabeseConnection("UniDB");
            cmd.Connection = (SqlConnection)cnn1;
            cmd.CommandType = CommandType.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = string.Format("insert into Проблема (ИД_компании, НазваниеПроблемы, НаправлениеПроблемы, ЦенаПроблемы," +
                " ОписаниеПроблемы) values ('{0}', '{1}', '{2}', '{3}', '{4}')",
                Global_ID.Comp_ID, textBox1.Text, textBox2.Text, textBox3.Text, richTextBox1.Text);
            cnn1.Open();
            cmd.ExecuteNonQuery();
            cnn1.Close();
            this.Visible = false;
        }
    }
}
