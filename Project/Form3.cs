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
    public partial class Form3 : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=member;";

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=member;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        public Form3()
        {
            InitializeComponent();
        }
        
        private void repasswordbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("       กรุณาใส่เฉพาะตัวเลข", "!!!Alert!!!");
                e.Handled = true;
            }
        }

        private void reconpasswordbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("       กรุณาใส่เฉพาะตัวเลข", "!!!Alert!!!");
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                repasswordbox.UseSystemPasswordChar = true;
            if (checkBox1.Checked == true)
                repasswordbox.UseSystemPasswordChar = false;            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                reconpasswordbox.UseSystemPasswordChar = false;
            if (checkBox2.Checked == false)
                reconpasswordbox.UseSystemPasswordChar = true;
        }

        private void register_Click(object sender, EventArgs e)
        {
            if (checkUsername())
            {
                MessageBox.Show("Username นี้มีคนใช้แล้ว");
            }
            else if (repasswordbox.Text != reconpasswordbox.Text)
            {
                MessageBox.Show("รหัส Password และ Confirm Passwordไม่ตรงกัน");
            }
            else if (repasswordbox.Text == reconpasswordbox.Text)
            {
                MySqlConnection conn = databaseConnection();
                string sql = "INSERT INTO memberlogin VALUES ('" + reusernamebox.Text + "','" + repasswordbox.Text + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("ทำการสมัครเรียบร้อย");
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ต้องการออกจากหน้า Register ใช่หรือไม่", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                this.Hide();
                f1.Show();
            }
            else if (dialogResult == DialogResult.No)
            { }
        }

        public Boolean checkUsername()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            string username = reusernamebox.Text;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM memberlogin WHERE username = @user",conn);

            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
