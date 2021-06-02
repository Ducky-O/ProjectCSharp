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
    public partial class Form4 : Form
    {
        public Form4()
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
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('001','"+ Program.user +"','ชาเขียว','ร้อน','40')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('002','" + Program.user + "','ชาเขียว','เย็น','45')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('003','" + Program.user + "','ชาเขียว','ปั่น','50')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('004','" + Program.user + "','ชานม','ร้อน','40')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('005','" + Program.user + "','ชานม','เย็น','45')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('006','" + Program.user + "','ชานม','ปั่น','50')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('007','" + Program.user + "','ชามะนาว','เย็น','45')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('008','" + Program.user + "','ชามะนาว','ปั่น','50')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('009','" + Program.user + "','ลาเต้','ร้อน','40')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('010','" + Program.user + "','ลาเต้','เย็น','45')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('011','" + Program.user + "','ลาเต้','ปั่น','50')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('012','" + Program.user + "','คาปูชิโน','ร้อน','40')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('013','" + Program.user + "','คาปูชิโน','เย็น','45')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('014','" + Program.user + "','คาปูชิโน','ปั่น','50')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('015','" + Program.user + "','มอคค่า','ร้อน','40')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('016','" + Program.user + "','มอคค่า','เย็น','45')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('017','" + Program.user + "','มอคค่า','ปั่น','50')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('018','" + Program.user + "','เอสเปรสโซ','ร้อน','40')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('019','" + Program.user + "','เอสเปรสโซ','เย็น','45')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('020','" + Program.user + "','เอสเปรสโซ','ปั่น','50')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('021','" + Program.user + "','อเมริกาโน','ร้อน','40')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO orderlist (id,membername,nameorder,type,price) VALUES('022','" + Program.user + "','อเมริกาโน','เย็น','45')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("เพิ่มรายการเรียบร้อย");
        }
    }
}
