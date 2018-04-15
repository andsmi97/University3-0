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
    public partial class StudMain : Form
    {
         
        public StudMain()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            //userControl11.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            //userControl11.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            //registraition1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StudMain_Load(object sender, EventArgs e)
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
            label7.Text = Convert.ToString(cmd.ExecuteScalar());
            cmd.CommandText = "SELECT ТелефонСтудента FROM Студент WHERE ИД_Студента=@StudID";
            label8.Text = Convert.ToString(cmd.ExecuteScalar());
            cmd.CommandText = "SELECT ОбоМне FROM Студент WHERE ИД_Студента=@StudID";
            label9.Text = Convert.ToString(cmd.ExecuteScalar());
            cnn.Close();
           
        }
    }
}
