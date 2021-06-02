
namespace Project
{
    partial class Form6
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
            this.dataOrderlist = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrderlist)).BeginInit();
            this.SuspendLayout();
            // 
            // dataOrderlist
            // 
            this.dataOrderlist.AllowUserToAddRows = false;
            this.dataOrderlist.AllowUserToDeleteRows = false;
            this.dataOrderlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOrderlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(42)))), ((int)(((byte)(11)))));
            this.dataOrderlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrderlist.Location = new System.Drawing.Point(100, 50);
            this.dataOrderlist.Name = "dataOrderlist";
            this.dataOrderlist.ReadOnly = true;
            this.dataOrderlist.RowHeadersWidth = 51;
            this.dataOrderlist.RowTemplate.Height = 24;
            this.dataOrderlist.Size = new System.Drawing.Size(843, 451);
            this.dataOrderlist.TabIndex = 0;
            this.dataOrderlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOrderlist_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Quark", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(100, 590);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 41);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "ยกเลิกรายการ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Quark", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(807, 590);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 41);
            this.button2.TabIndex = 19;
            this.button2.Text = "ยืนยันสั่งซื้อ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quark", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "ไม่ได้เลือก ID ไหนเพื่อยกเลิกรายการ";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Quark", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(400, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 41);
            this.button1.TabIndex = 21;
            this.button1.Text = "ยกเลิกรายการทั้งหมด";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quark", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(980, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 33);
            this.label2.TabIndex = 22;
            this.label2.Text = "รวมสินค้าทั้งหมดราคา";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quark", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1050, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 33);
            this.label3.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quark", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1120, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 33);
            this.label4.TabIndex = 24;
            this.label4.Text = "บาท";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(42)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1214, 706);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataOrderlist);
            this.Name = "Form6";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOrderlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataOrderlist;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}