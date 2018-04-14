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
    public partial class Complite : UserControl
    {
        DataBaseConnection conn = new DataBaseConnection();
        DbConnection cnn;
        SqlDataAdapter da1;
        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand();
        public Complite()
        {
            InitializeComponent();
        }

        private void Complite_Load(object sender, EventArgs e)
        {
            cnn = (SqlConnection)conn.getDatabaseConnection("SqlDB");
            cmd.Connection = (SqlConnection)cnn;
            cmd.Parameters.AddWithValue("@StudID", Gloal_ID.Stud_ID);
            cmd.CommandText = "SELECT Проблема.НазваниеПроблемы, РешениеПроблемы.СтатусРешения, РешениеПроблемы.КомментарийКРешениюПроблемы, РешениеПроблемы.СсылкаНаРешениеПроблемы FROM Проблема INNER JOIN(Студент INNER JOIN РешениеПроблемы ON Студент.ИД_Студента = РешениеПроблемы.ИД_Студента) ON Проблема.ИД_Проблемы = РешениеПроблемы.ИД_Проблемы WHERE(((Студент.[ИД_Студента]) = @StudID) AND((РешениеПроблемы.СтатусРешения) = True));";
            cnn.Open();
            da1 = new SqlDataAdapter(cmd.CommandText, (SqlConnection)cnn);
            da1.Fill(ds, "Проблема");
        }
    }
}
