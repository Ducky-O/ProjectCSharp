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
    public partial class Form6 : Form
    {
        string id;
        private List<preorder> allorder = new List<preorder>();

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=member";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        
        private void showOrderlist()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM orderlist WHERE membername = '" + Program.user + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataOrderlist.DataSource = ds.Tables[0].DefaultView;
        }

        public Form6()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            showOrderlist();
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM orderlist WHERE membername = '" + Program.user + "'", conn);
            MySqlDataReader adapter = cmd.ExecuteReader();
            Program.sum = 0;
            while (adapter.Read())
            {
                Program.sum = Program.sum + int.Parse(adapter.GetString("price"));
            }
            label3.Text = Program.sum.ToString();
            conn.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ต้องการยกเลิกรายการที่มี ID นี้ทั้งหมด ใช่หรือไม่", "!!!Alert!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MySqlConnection conn = databaseConnection();
                string sql = "DELETE FROM orderlist WHERE id = '" + id.ToString() + "' AND membername = '"+Program.user+"'";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);            
                cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("ยกเลิกรายการสำเร็จ");
                showOrderlist();
                label1.Text = "ไม่ได้เลือก ID ไหนเพื่อยกเลิกรายการ";
                conn.Open();
                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM orderlist WHERE membername = '" + Program.user + "'", conn);
                MySqlDataReader adapter = cmd1.ExecuteReader();
                Program.sum = 0;
                while (adapter.Read())
                {
                    Program.sum = Program.sum + int.Parse(adapter.GetString("price"));
                }
                label3.Text = Program.sum.ToString();
                conn.Close();
            }
            else if (dialogResult == DialogResult.No)
            { }
        }

        private void dataOrderlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            id = dataOrderlist.Rows[e.RowIndex].Cells[0].Value.ToString();
            Console.WriteLine(id);
            label1.Text = "กำลังเลือก ID '" + id + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ต้องการยืนยันคำสั่งซื้อทั้งหมด ใช่หรือไม่", "!!!Alert!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {   MySqlConnection conn = databaseConnection();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM orderlist WHERE membername = '" + Program.user + "'",conn);
                MySqlDataReader adapter = cmd.ExecuteReader();
                while (adapter.Read())
                {
                    Program.id = adapter.GetString("id").ToString();
                    Program.membername = adapter.GetString("membername").ToString();
                    Program.nameorder = adapter.GetString("nameorder").ToString();
                    Program.type = adapter.GetString("type").ToString();
                    Program.price = adapter.GetString("price").ToString();
                    preorder item = new preorder()
                    {
                        id = Program.id,
                        membername = Program.membername,
                        nameorder = Program.nameorder,
                        type = Program.type,
                        price = Program.price
                    };
                    allorder.Add(item);
                }
                conn.Close();
                foreach(var i in allorder)
                {
                    conn.Open();
                    string mysql = "INSERT INTO confirmorder(id,membername,nameorder,type,price) VALUES('" + i.id + "','" + i.membername + "','" + i.nameorder + "','" + i.type + "','" + i.price + "')";
                    cmd = new MySqlCommand(mysql,conn);
                    cmd.ExecuteReader();
                    conn.Close();
                }
                conn.Open();
                string mysql1 = "DELETE FROM orderlist WHERE membername = '"+Program.user+"'";
                cmd = new MySqlCommand(mysql1, conn);
                cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("\t               ยืนยันการสั่งซื้อ\n\t               คุณลูกค้า " + Program.user + "\nกรุณารอพนักงานเรียกชื่อ และจ่ายเงินที่เคาน์เตอร์นะครับ");
                showOrderlist();
                label1.Text = "ไม่ได้เลือก ID ไหนเพื่อยกเลิกรายการ";
            }
            else if (dialogResult == DialogResult.No)
            { }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ต้องการยกเลิกราการสั่งซื้อทั้งหมด ใช่หรือไม่", "!!!Alert!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MySqlConnection conn = databaseConnection();
                string sql = "DELETE FROM orderlist ";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("ลบรายการาสั่งซื้อทั้งหมดสำเร็จ");
                showOrderlist();
                label1.Text = "ไม่ได้เลือก ID ไหนเพื่อยกเลิกรายการ";
                conn.Open();
                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM orderlist WHERE membername = '" + Program.user + "'", conn);
                MySqlDataReader adapter = cmd1.ExecuteReader();
                Program.sum = 0;
                while (adapter.Read())
                {
                    Program.sum = Program.sum + int.Parse(adapter.GetString("price"));
                }
                label3.Text = Program.sum.ToString();
                conn.Close();
            }
            else if (dialogResult == DialogResult.No)
            { }

            
        }
    }
}
