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
    public partial class Problem : UserControl
    {

        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();
        SqlDataAdapter da1;
        SqlDataAdapter da2;
        SqlDataAdapter da3;
        DataSet ds = new DataSet();
        public Problem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Problem_Load(object sender, EventArgs e)
        {
            cnn.ConnectionString = "Data Source=DESKTOP-5R6MQVO\\ALINA;Initial Catalog=Uni3;Integrated Security=True";
            cmd.Connection = (SqlConnection)cnn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ProblemID", Global_ID.Problem_ID);


            cnn.Open();
            cmd.CommandText = "SELECT НазваниеПроблемы FROM Проблема WHERE ИД_Проблемы=@ProblemID";
            label1.Text = Convert.ToString(cmd.ExecuteScalar());
            cmd.CommandText = "SELECT НаправлениеПроблемы FROM Проблема WHERE ИД_Проблемы=@ProblemID";
            label2.Text = Convert.ToString(cmd.ExecuteScalar());
            cmd.CommandText = "SELECT ЦенаПроблемы FROM Проблема WHERE ИД_Проблемы=@ProblemID";
            label3.Text = Convert.ToString(cmd.ExecuteScalar());
            cmd.CommandText = "SELECT ОписаниеПроблемы FROM Проблема WHERE ИД_Проблемы=@ProblemID";
            label4.Text = Convert.ToString(cmd.ExecuteScalar());

            cnn.Close();
        }
    }
}
