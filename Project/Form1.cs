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
    public partial class Form1 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=member";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void passwordbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM memberlogin WHERE username = \"{usernamebox.Text}\"AND password = \"{passwordbox.Text}\"";
            MySqlDataReader row = cmd.ExecuteReader();
            if (row.HasRows)
            {
                MessageBox.Show("เข้าสู่ระบบสำเร็จ");
                Program.user = usernamebox.Text;
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            }
            else { MessageBox.Show("\tเข้าสู่ระบบล้มเหลว\nUsername หรือ Password ไม่ถูกต้อง"); }
            conn.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ต้องการออกจากโปรแกรม ใช่หรือไม่", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            { }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                passwordbox.UseSystemPasswordChar = false;
            if (checkBox1.Checked == false)
                passwordbox.UseSystemPasswordChar = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }
    }
}
