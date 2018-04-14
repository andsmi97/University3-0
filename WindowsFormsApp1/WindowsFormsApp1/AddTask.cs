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
    public partial class AddTask : UserControl
    {
        public AddTask()
        {
            InitializeComponent();
        }

        DataBaseConnection conn = new DataBaseConnection();
        DbConnection cnn1;
        SqlCommand cmd = new SqlCommand();

        private void AddTask_Load(object sender, EventArgs e)
        {
            cnn1 = conn.GetDatabeseConnection("UniDB");
            cmd.Connection = (SqlConnection)cnn1;
            cmd.CommandType = CommandType.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = string.Format("insert into Задача (ИД_компании, НазваниеЗадачи, НаправлениеЗадачи, ЦенаЗадачи," +
    " ОписаниеЗадачи) values ('{0}', '{1}', '{2}', '{3}', '{4}')",
    Global_Id.Comp_ID, textBox1.Text, textBox2.Text, textBox3.Text, richTextBox1.Text);
            cnn1.Open();
            cmd.ExecuteNonQuery();
            cnn1.Close();
            this.Visible = false;
        }
    }
}
