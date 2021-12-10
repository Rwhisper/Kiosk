
namespace TakeProgram
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.takeGdView = new System.Windows.Forms.DataGridView();
            this.sumPriceLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.noCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.takeGdView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("배달의민족 주아", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(177, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "주문 들어왔습니다.";
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(235, 391);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(173, 68);
            this.OkBtn.TabIndex = 1;
            this.OkBtn.Text = "확인";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // takeGdView
            // 
            this.takeGdView.AllowUserToAddRows = false;
            this.takeGdView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.takeGdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.takeGdView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noCol,
            this.ItemNameCol,
            this.priceCol,
            this.countCol});
            this.takeGdView.Location = new System.Drawing.Point(53, 102);
            this.takeGdView.Name = "takeGdView";
            this.takeGdView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.takeGdView.RowHeadersVisible = false;
            this.takeGdView.RowHeadersWidth = 51;
            this.takeGdView.RowTemplate.Height = 29;
            this.takeGdView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.takeGdView.Size = new System.Drawing.Size(530, 229);
            this.takeGdView.TabIndex = 2;
            // 
            // sumPriceLbl
            // 
            this.sumPriceLbl.AutoSize = true;
            this.sumPriceLbl.Location = new System.Drawing.Point(471, 350);
            this.sumPriceLbl.Name = "sumPriceLbl";
            this.sumPriceLbl.Size = new System.Drawing.Size(112, 20);
            this.sumPriceLbl.TabIndex = 3;
            this.sumPriceLbl.Text = "총 금액 : 00000";
            // 
            // noCol
            // 
            this.noCol.HeaderText = "주문번호";
            this.noCol.MinimumWidth = 6;
            this.noCol.Name = "noCol";
            // 
            // ItemNameCol
            // 
            this.ItemNameCol.HeaderText = "제품명";
            this.ItemNameCol.MinimumWidth = 6;
            this.ItemNameCol.Name = "ItemNameCol";
            // 
            // priceCol
            // 
            this.priceCol.HeaderText = "가격";
            this.priceCol.MinimumWidth = 6;
            this.priceCol.Name = "priceCol";
            // 
            // countCol
            // 
            this.countCol.HeaderText = "주문량";
            this.countCol.MinimumWidth = 6;
            this.countCol.Name = "countCol";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(634, 506);
            this.Controls.Add(this.sumPriceLbl);
            this.Controls.Add(this.takeGdView);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.takeGdView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.DataGridView takeGdView;
        private System.Windows.Forms.Label sumPriceLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn countCol;
    }
}