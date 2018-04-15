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
    public partial class Complete1 : UserControl
    {
        DataBaseConnection conn = new DataBaseConnection();
        DbConnection cnn;
        SqlDataAdapter da1;
        //DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        public Complete1()
        {
            InitializeComponent();
        }

        private void Complete1_Load(object sender, EventArgs e)
        {
            //cnn = (SqlConnection)conn.getDatabaseConnection("UniDB");
            //cmd.Connection = (SqlConnection)cnn;
            //cmd.Parameters.AddWithValue("@StudID", Gloal_ID.Stud_ID);
            cmd.CommandText = "SELECT Проблема.НазваниеПроблемы, РешениеПроблемы.СтатусРешенияПроблемы, РешениеПроблемы.КомментарийКРешениюПроблемы, РешениеПроблемы.СсылкаНаРешениеПроблемы FROM Проблема INNER JOIN(Студент INNER JOIN РешениеПроблемы ON Студент.ИД_Студента = РешениеПроблемы.ИД_Студента) ON Проблема.ИД_Проблемы = РешениеПроблемы.ИД_Проблемы WHERE Студент.[ИД_Студента]=11 AND РешениеПроблемы.СтатусРешенияПроблемы=1;";
            da1 = new SqlDataAdapter(cmd.CommandText, (SqlConnection)cnn);
            da1.Fill(dt);
            dataGridView1.DataSource = dt;
            
            //da1 = new SqlDataAdapter(cmd.CommandText, (SqlConnection)cnn);
          
            //da1.Fill(ds, "Проблема");
        }
    }
}
