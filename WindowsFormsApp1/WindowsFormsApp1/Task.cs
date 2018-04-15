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
    public partial class Task : UserControl
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();

        SqlDataAdapter da1;
        SqlDataAdapter da2;
        SqlDataAdapter da3;
        DataSet ds = new DataSet();
        public Task()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Task_Load(object sender, EventArgs e)
        {
            cnn.ConnectionString = "Data Source=DESKTOP-5R6MQVO\\ALINA;Initial Catalog=Uni3;Integrated Security=True";
            cmd.Connection = (SqlConnection)cnn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@TaskID", Global_ID.Task_ID);


            cnn.Open();
            cmd.CommandText = "SELECT НазваниеЗадачи FROM Задача WHERE ИД_задачи=@TaskID";
            label1.Text = Convert.ToString(cmd.ExecuteScalar());
            cmd.CommandText = "SELECT НаправлениеЗадачи FROM Задача WHERE ИД_задачи=@TaskID";
            label2.Text = Convert.ToString(cmd.ExecuteScalar());
            cmd.CommandText = "SELECT ЦенаЗадачи FROM Задача WHERE ИД_задачи=@TaskID";
            label3.Text = Convert.ToString(cmd.ExecuteScalar());
            cmd.CommandText = "SELECT ОписаниеЗадачи FROM Задача WHERE ИД_задачи=@TaskID";
            label4.Text = Convert.ToString(cmd.ExecuteScalar());

            cnn.Close();
        }
    }
}
