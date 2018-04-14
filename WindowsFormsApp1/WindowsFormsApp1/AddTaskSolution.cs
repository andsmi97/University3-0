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
    public partial class AddTaskSolution : UserControl
    {
        public AddTaskSolution()
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
            cmd.CommandText = string.Format("insert into РешениеЗадачи (ИД_задачи, ИД_Студента, ДатаРешенияЗадачи," +
                " КомментарийКРешениюЗадачи, СсылкаНаРешениеЗадачи) values ('{0}', '{1}', '{2}', '{3}', '{4}')",
    Global_ID.Task_ID, Global_ID.Stud_ID, DateTime.Now.ToShortDateString(), richTextBox1.Text, textBox1.Text);
            cnn1.Open();
            cmd.ExecuteNonQuery();
            cnn1.Close();
            this.Visible = false;
        }
    }
}
