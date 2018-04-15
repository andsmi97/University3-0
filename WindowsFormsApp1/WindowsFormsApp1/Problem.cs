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
        DataBaseConnection conn = new DataBaseConnection();
        DbConnection cnn;
        SqlDataAdapter da1;
        SqlDataAdapter da2;
        SqlDataAdapter da3;
        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand();
        public Problem()
        {
            InitializeComponent();
        }

        private void Problem_Load(object sender, EventArgs e)
        {
            cnn = (SqlConnection)conn.getDatabaseConnection("UniDB");
            cmd.Connection = (SqlConnection)cnn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@StudID", Gloal_ID.Stud_ID);

            cnn.Open();
            cmd.CommandText = "SELECT ФИОСтудента FROM Студент WHERE ИД_Студента=@StudID";
            label3.Text = Convert.ToString(cmd.ExecuteScalar());
            cmd.CommandText = "SELECT Курс FROM Студент WHERE ИД_Студента=@StudID";
            label4.Text = Convert.ToString(cmd.ExecuteScalar());
            cmd.CommandText = "SELECT Факультет FROM Студент WHERE ИД_Студента=@StudID";
            label5.Text = Convert.ToString(cmd.ExecuteScalar());
            cmd.CommandText = "SELECT Направление FROM Студент WHERE ИД_Студента=@StudID";
            label6.Text = Convert.ToString(cmd.ExecuteScalar());
            cmd.CommandText = "SELECT EmailСтудента FROM Студент WHERE ИД_Студента=@StudID";
            cnn.Close();

        }
    }
}
