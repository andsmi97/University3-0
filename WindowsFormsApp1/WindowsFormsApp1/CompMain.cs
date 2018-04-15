using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class CompMain : Form
    {
        DataBaseConnection conn = new DataBaseConnection();
        DbConnection cnn;
        SqlDataAdapter da1;
        SqlDataAdapter da2;
        SqlDataAdapter da3;
        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand();
        public CompMain()
        {
            InitializeComponent();
        }

        private void CompMain_Load(object sender, EventArgs e)
        {
            cnn = (SqlConnection)conn.getDatabaseConnection("UniDB");
            cmd.Connection = (SqlConnection)cnn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@CompID", Gloal_ID.Comp_ID);
           
            cnn.Open();
            cmd.CommandText = "SELECT НазваниеКомпании FROM Компания WHERE ИД_Компании=@CompID";
            label3.Text = Convert.ToString(cmd.ExecuteScalar());
            cmd.CommandText = "SELECT СфераДеятельности FROM Компания WHERE ИД_Компании=@CompID";
            label4.Text = Convert.ToString(cmd.ExecuteScalar());
            cmd.CommandText = "SELECT ТелефонКомпании FROM Компания WHERE ИД_Компании=@CompID";
            label5.Text = Convert.ToString(cmd.ExecuteScalar());
            cmd.CommandText = "SELECT EmailКомпании FROM Компания WHERE ИД_Компании=@CompID";
            label6.Text = Convert.ToString(cmd.ExecuteScalar());
            cmd.CommandText = "SELECT ОписаниеКомпании FROM Компания WHERE ИД_Компании=@CompID";
            label7.Text = Convert.ToString(cmd.ExecuteScalar());
            cnn.Close();
        }
    }
}
