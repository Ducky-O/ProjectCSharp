
namespace Project
{
    partial class Form7
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
            this.dataHisOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataHisOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataHisOrder
            // 
            this.dataHisOrder.AllowUserToAddRows = false;
            this.dataHisOrder.AllowUserToDeleteRows = false;
            this.dataHisOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataHisOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(42)))), ((int)(((byte)(11)))));
            this.dataHisOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHisOrder.Location = new System.Drawing.Point(230, 12);
            this.dataHisOrder.Name = "dataHisOrder";
            this.dataHisOrder.ReadOnly = true;
            this.dataHisOrder.RowHeadersWidth = 51;
            this.dataHisOrder.RowTemplate.Height = 24;
            this.dataHisOrder.Size = new System.Drawing.Size(741, 682);
            this.dataHisOrder.TabIndex = 1;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(42)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1214, 706);
            this.Controls.Add(this.dataHisOrder);
            this.Name = "Form7";
            this.Text = "HistoryOrder";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHisOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataHisOrder;
    }
}