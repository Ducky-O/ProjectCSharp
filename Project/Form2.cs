using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form2 : Form
    {
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ต้องการออกจากโปรแกรม ใช่หรือไม่", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
            else if (dialogResult == DialogResult.No)
            { }
        }

        public Form2()
        {
            InitializeComponent();
            customizeDesign();
        }
        
        private void customizeDesign()
        {
            panelMenuSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelMenuSubmenu.Visible == true)
                panelMenuSubmenu.Visible = false;
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        
        private void btnMenu_Click(object sender, EventArgs e)
        {
            showSubmenu(panelMenuSubmenu);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
            hideSubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Form5());
            hideSubmenu();
        }

        private Form activeForm1 = null;
        private Form activeForm2 = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm1 != null)
                activeForm1.Close();
            activeForm1 = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void openOrderForm(Form orderform)
        {
            if (activeForm2 != null)
                activeForm2.Close();
            activeForm2 = orderform;
            orderform.TopLevel = false;
            orderform.FormBorderStyle = FormBorderStyle.None;
            orderform.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(orderform);
            panelChildForm.Tag = orderform;
            orderform.BringToFront();
            orderform.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            openOrderForm(new Form6());
            hideSubmenu();
            Program.sum = 0;
        }

        private void btnHisOrder_Click(object sender, EventArgs e)
        {
            openChildForm(new Form7());
            hideSubmenu();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = (" " + Program.user + " ");
        }
    }
}
