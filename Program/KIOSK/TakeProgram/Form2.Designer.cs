
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
            this.noCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumPriceLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.takeGdView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(138, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "주문 들어왔습니다.";
            // 
            // OkBtn
            // 
            this.OkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.OkBtn.FlatAppearance.BorderSize = 0;
            this.OkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkBtn.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OkBtn.Location = new System.Drawing.Point(183, 293);
            this.OkBtn.Margin = new System.Windows.Forms.Padding(2);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(135, 51);
            this.OkBtn.TabIndex = 1;
            this.OkBtn.Text = "확인";
            this.OkBtn.UseVisualStyleBackColor = false;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // takeGdView
            // 
            this.takeGdView.AllowUserToAddRows = false;
            this.takeGdView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.takeGdView.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.takeGdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.takeGdView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noCol,
            this.ItemNameCol,
            this.priceCol,
            this.countCol});
            this.takeGdView.Location = new System.Drawing.Point(41, 76);
            this.takeGdView.Margin = new System.Windows.Forms.Padding(2);
            this.takeGdView.Name = "takeGdView";
            this.takeGdView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.takeGdView.RowHeadersVisible = false;
            this.takeGdView.RowHeadersWidth = 51;
            this.takeGdView.RowTemplate.Height = 29;
            this.takeGdView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.takeGdView.Size = new System.Drawing.Size(412, 172);
            this.takeGdView.TabIndex = 2;
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
            // sumPriceLbl
            // 
            this.sumPriceLbl.AutoSize = true;
            this.sumPriceLbl.Location = new System.Drawing.Point(366, 262);
            this.sumPriceLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sumPriceLbl.Name = "sumPriceLbl";
            this.sumPriceLbl.Size = new System.Drawing.Size(93, 15);
            this.sumPriceLbl.TabIndex = 3;
            this.sumPriceLbl.Text = "총 금액 : 00000";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(493, 380);
            this.Controls.Add(this.sumPriceLbl);
            this.Controls.Add(this.takeGdView);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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