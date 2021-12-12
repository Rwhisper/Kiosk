
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
            this.Iplbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listenLbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(32, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(790, 371);
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
            // Iplbl
            // 
            this.Iplbl.AutoSize = true;
            this.Iplbl.Location = new System.Drawing.Point(32, 20);
            this.Iplbl.Name = "Iplbl";
            this.Iplbl.Size = new System.Drawing.Size(54, 15);
            this.Iplbl.TabIndex = 1;
            this.Iplbl.Text = "아이피 : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("타이포_도담체 L", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(523, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "서버 연결 시작";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listenLbl
            // 
            this.listenLbl.AutoSize = true;
            this.listenLbl.Font = new System.Drawing.Font("타이포_도담체 L", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listenLbl.Location = new System.Drawing.Point(690, 18);
            this.listenLbl.Name = "listenLbl";
            this.listenLbl.Size = new System.Drawing.Size(76, 18);
            this.listenLbl.TabIndex = 3;
            this.listenLbl.Text = "연결 실패";
            this.listenLbl.Click += new System.EventHandler(this.listenLbl_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(81, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listenLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Iplbl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay_card;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay_date;
        private System.Windows.Forms.Label Iplbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label listenLbl;
        private System.Windows.Forms.Button button2;
    }
}

