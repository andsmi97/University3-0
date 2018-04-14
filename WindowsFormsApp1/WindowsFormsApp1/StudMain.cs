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
        DataBaseConnection conn = new DataBaseConnection();
        DbConnection cnn;
        SqlDataAdapter da1;
        SqlDataAdapter da2;
        SqlDataAdapter da3;
        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand();
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
            cmd.CommandText = "SELECT ФИОСтудента FROM Студент WHERE ФИОСтудента='Мелехин Владислав Юрьевич'";
            cnn.Open();
            label1.Text = Convert.ToString(cmd.ExecuteScalar());
            cnn.Close();
           
        }
    }
}
