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
    public partial class LoginStud : UserControl
    {
        //DataBaseConnection conn = new DataBaseConnection();
        //DbConnection cnn;
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();

        public LoginStud()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       

            //cnn = conn.getDatabaseConnection("UniDB");
            cnn.ConnectionString = "Data Source=DESKTOP-UGM0GFJ\\ANDREW;Initial Catalog=Uni3;Integrated Security=True";
            cmd.Connection = (SqlConnection)cnn;

            cmd.Parameters.Add("@login", SqlDbType.Text);
            cmd.Parameters.Add("@password", SqlDbType.Text);
            cmd.Parameters["@login"].Value = textBox1.Text;
            cmd.Parameters["@password"].Value = textBox2.Text;

            cmd.CommandText = "SELECT ИД_Студента FROM Студент WHERE CONVERT(VARCHAR, ЛогинСтудента) = CONVERT(VARCHAR, @login) AND CONVERT(VARCHAR, ПарольСтудента) = CONVERT(VARCHAR, @password)";

            cnn.Open();
            if (cmd.ExecuteNonQuery() != 0)
            {
                Gloal_ID.Stud_ID = Convert.ToInt32(cmd.ExecuteScalar());
                label1.Text = "Value has been inserted";
            }
            else
            {
                label1.Text = "Error";
            }
            cnn.Close();

            StudMain DataSet = new StudMain();
            DataSet.Show();
            this.ParentForm.Visible = false;
           // DataSet.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false; 
        }

        private void LoginStud_Load(object sender, EventArgs e)
        {

        }
    }
}
