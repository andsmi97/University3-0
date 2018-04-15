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
    public partial class CompMain : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();

        public CompMain()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            problemView1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            taskView1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            studList1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home hm = new Home();
            hm.Show();
        }

        private void CompMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void studList1_Load(object sender, EventArgs e)
        {

        }

        private void CompMain_Load(object sender, EventArgs e)
        {


            cnn.ConnectionString = "Data Source=DESKTOP-5R6MQVO\\ALINA;Initial Catalog=Uni3;Integrated Security=True";
            cmd.Connection = (SqlConnection)cnn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@CompID", Global_ID.Comp_ID);

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
