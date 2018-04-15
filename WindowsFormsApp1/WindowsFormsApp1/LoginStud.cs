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
        public LoginStud()
        {
            InitializeComponent();
        }
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn1 = new SqlConnection();
        private void button1_Click(object sender, EventArgs e)
        {
            cnn1.ConnectionString = "Data Source=DESKTOP-5R6MQVO\\ALINA;Initial Catalog=Uni3;Integrated Security=True";
            cmd.Connection = (SqlConnection)cnn1;

            cmd.Parameters.Add("@login", SqlDbType.Text);
            cmd.Parameters.Add("@password", SqlDbType.Text);
            cmd.Parameters["@login"].Value = textBox1.Text;
            cmd.Parameters["@password"].Value = textBox2.Text;

            cmd.CommandText = "SELECT ИД_Студента FROM Студент WHERE CONVERT(VARCHAR, ЛогинСтудента) = CONVERT(VARCHAR, @login) AND CONVERT(VARCHAR, ПарольСтудента) = CONVERT(VARCHAR, @password)";

            cnn1.Open();
            string ID_st = Convert.ToString(cmd.ExecuteScalar());
            if (ID_st != "")
            {
                Global_ID.Stud_ID = Convert.ToInt32(cmd.ExecuteScalar());
                //label2.Text = "Value has been inserted";
                StudMain ds = new StudMain();
                ds.Show();
                this.ParentForm.Visible = false;
            }
            else
            {
                label3.Text = "Неверный логин или пароль";
            }
            cnn1.Close();
            StudMain DataSet = new StudMain();
            DataSet.Show();
            this.Hide();
            //this.ParentForm.Visible = false;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false; 
        }
    }
}
