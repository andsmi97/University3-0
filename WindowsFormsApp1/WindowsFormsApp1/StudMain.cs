using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
namespace WindowsFormsApp1
{
    public partial class StudMain : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();
        public StudMain()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            //userControl11.BringToFront();
            //problemList1.Visible = false;
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
            //problemList1.Visible = true;
            problemList1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            tasksList1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            complite1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home hm = new Home();
            hm.Show();
        }

        private void StudMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void StudMain_Load(object sender, EventArgs e)
        {

            cnn.ConnectionString = "Data Source=DESKTOP-5R6MQVO\\ALINA;Initial Catalog=Uni3;Integrated Security=True";
            cmd.Connection = (SqlConnection)cnn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@StudID", Global_ID.Stud_ID);

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
