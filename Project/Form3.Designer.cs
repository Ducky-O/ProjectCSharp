
namespace Project
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reusernamebox = new System.Windows.Forms.TextBox();
            this.repasswordbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reconpasswordbox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.register = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 63);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quark", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Register Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quark", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quark", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // reusernamebox
            // 
            this.reusernamebox.Font = new System.Drawing.Font("Quark", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.reusernamebox.Location = new System.Drawing.Point(105, 145);
            this.reusernamebox.Name = "reusernamebox";
            this.reusernamebox.Size = new System.Drawing.Size(329, 42);
            this.reusernamebox.TabIndex = 4;
            // 
            // repasswordbox
            // 
            this.repasswordbox.Font = new System.Drawing.Font("Quark", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.repasswordbox.Location = new System.Drawing.Point(105, 245);
            this.repasswordbox.Name = "repasswordbox";
            this.repasswordbox.Size = new System.Drawing.Size(329, 42);
            this.repasswordbox.TabIndex = 5;
            this.repasswordbox.UseSystemPasswordChar = true;
            this.repasswordbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.repasswordbox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quark", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(55, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Password";
            // 
            // reconpasswordbox
            // 
            this.reconpasswordbox.Font = new System.Drawing.Font("Quark", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.reconpasswordbox.Location = new System.Drawing.Point(105, 345);
            this.reconpasswordbox.Name = "reconpasswordbox";
            this.reconpasswordbox.Size = new System.Drawing.Size(329, 42);
            this.reconpasswordbox.TabIndex = 7;
            this.reconpasswordbox.UseSystemPasswordChar = true;
            this.reconpasswordbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.reconpasswordbox_KeyPress);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Quark", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(455, 260);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.Font = new System.Drawing.Font("Quark", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(455, 360);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("Quark", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.register.Location = new System.Drawing.Point(61, 450);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(107, 40);
            this.register.TabIndex = 11;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Quark", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Location = new System.Drawing.Point(279, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel Register";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quark", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(171, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "*ตั้งเป็นตัวเลขเท่านั้น";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(42)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(532, 553);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.register);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.reconpasswordbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.repasswordbox);
            this.Controls.Add(this.reusernamebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reusernamebox;
        private System.Windows.Forms.TextBox repasswordbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox reconpasswordbox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
    }
}