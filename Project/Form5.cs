using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=member";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('101','" + Program.user + "','Butter Croissant','piece','40')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('102','" + Program.user + "','Pudding Green Tea','piece','30')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('103','" + Program.user + "','Green Tea Cake','piece','45')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('104','" + Program.user + "','Cheese Cake','piece','45')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('105','" + Program.user + "','Red Velvet','piece','45')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('106','" + Program.user + "','Dark Chocolate Cake','piece','45')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

    }
}
