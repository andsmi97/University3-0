using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace WindowsFormsApp1
{
    public partial class RegStud : Form
    {
        public RegStud()
        {
            InitializeComponent();
        }

        DataBaseConnection conn = new DataBaseConnection();
        DbConnection cnn1;
        SqlCommand cmd = new SqlCommand();
        private void button1_Click(object sender, EventArgs e)
        {
            cnn1 = conn.GetDatabeseConnection("UniDB");
            cmd.Connection = (SqlConnection)cnn1;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("insert into Студент (ФИОСтудента, Курс, Факультет, Направление, EmailСтудента, ТелефонСтудента," +
                " НомерКартыСтудента, ЛогинСтудента, ПарольСтудента, ОбоМне) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}'" +
                ", '{7}', '{8}', '{9}')",
                textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text,
                textBox9.Text, richTextBox1.Text);
            cnn1.Open();
            cmd.ExecuteNonQuery();
            cnn1.Close();
            this.Visible = false;
        }
    }
}
