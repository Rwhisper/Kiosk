
namespace TakeProgram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pay_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay_card = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pay_num,
            this.pro_code,
            this.pay_card,
            this.count,
            this.pay_date});
            this.dataGridView1.Location = new System.Drawing.Point(32, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(882, 399);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pay_num
            // 
            this.pay_num.Frozen = true;
            this.pay_num.HeaderText = "순번";
            this.pay_num.Name = "pay_num";
            this.pay_num.ReadOnly = true;
            // 
            // pro_code
            // 
            this.pro_code.Frozen = true;
            this.pro_code.HeaderText = "품목 코드";
            this.pro_code.Name = "pro_code";
            this.pro_code.ReadOnly = true;
            this.pro_code.Width = 250;
            // 
            // pay_card
            // 
            this.pay_card.Frozen = true;
            this.pay_card.HeaderText = "카드번호";
            this.pay_card.Name = "pay_card";
            this.pay_card.ReadOnly = true;
            // 
            // count
            // 
            this.count.Frozen = true;
            this.count.HeaderText = "개수";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // pay_date
            // 
            this.pay_date.Frozen = true;
            this.pay_date.HeaderText = "일자";
            this.pay_date.Name = "pay_date";
            this.pay_date.ReadOnly = true;
            this.pay_date.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay_card;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay_date;
    }
}

