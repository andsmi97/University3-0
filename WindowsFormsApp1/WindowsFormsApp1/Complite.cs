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
    public partial class Complite : UserControl
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();
        SqlDataAdapter da1;
        DataSet ds = new DataSet();
        public Complite()
        {
            InitializeComponent();
        }

        private void Complite_Load(object sender, EventArgs e)
        {
            //cnn.ConnectionString = "Data Source=DESKTOP-5R6MQVO\\ALINA;Initial Catalog=Uni3;Integrated Security=True";
            //cmd.Connection = (SqlConnection)cnn;
            //cmd.Parameters.AddWithValue("@StudID", Global_ID.Stud_ID);
            //cmd.CommandText = "SELECT Проблема.НазваниеПроблемы, РешениеПроблемы.СтатусРешенияПроблемы, РешениеПроблемы.КомментарийКРешениюПроблемы, РешениеПроблемы.СсылкаНаРешениеПроблемы FROM Проблема INNER JOIN(Студент INNER JOIN РешениеПроблемы ON Студент.ИД_Студента = РешениеПроблемы.ИД_Студента) ON Проблема.ИД_Проблемы = РешениеПроблемы.ИД_Проблемы WHERE(((Студент.[ИД_Студента]) = @StudID) AND((РешениеПроблемы.СтатусРешенияПроблемы) = True));";
            //cnn.Open();
            //da1 = new SqlDataAdapter(cmd.CommandText, (SqlConnection)cnn);
            //da1.Fill(ds, "Проблема");
        }
    }
    
}
