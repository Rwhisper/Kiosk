
namespace KIOSK
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.r = new System.Windows.Forms.HelpProvider();
            this.storeRButton = new System.Windows.Forms.RadioButton();
            this.packRButton = new System.Windows.Forms.RadioButton();
            this.storeButton = new System.Windows.Forms.Button();
            this.packButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sumPriceLbl = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.orderGridView2 = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 38);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(551, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.White;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backBtn.Location = new System.Drawing.Point(70, 551);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(199, 96);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "취소";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // storeRButton
            // 
            this.storeRButton.AutoSize = true;
            this.storeRButton.Enabled = false;
            this.storeRButton.Location = new System.Drawing.Point(158, 489);
            this.storeRButton.Name = "storeRButton";
            this.storeRButton.Size = new System.Drawing.Size(49, 19);
            this.storeRButton.TabIndex = 7;
            this.storeRButton.TabStop = true;
            this.storeRButton.Text = "매장";
            this.storeRButton.UseVisualStyleBackColor = true;
            this.storeRButton.CheckedChanged += new System.EventHandler(this.storeRButton_CheckedChanged);
            // 
            // packRButton
            // 
            this.packRButton.AutoSize = true;
            this.packRButton.Enabled = false;
            this.packRButton.Location = new System.Drawing.Point(357, 489);
            this.packRButton.Name = "packRButton";
            this.packRButton.Size = new System.Drawing.Size(49, 19);
            this.packRButton.TabIndex = 8;
            this.packRButton.TabStop = true;
            this.packRButton.Text = "포장";
            this.packRButton.UseVisualStyleBackColor = true;
            // 
            // storeButton
            // 
            this.storeButton.Location = new System.Drawing.Point(120, 449);
            this.storeButton.Name = "storeButton";
            this.storeButton.Size = new System.Drawing.Size(122, 23);
            this.storeButton.TabIndex = 9;
            this.storeButton.Text = "매장에서 먹을게요";
            this.storeButton.UseVisualStyleBackColor = true;
            this.storeButton.Click += new System.EventHandler(this.storeButton_Click);
            // 
            // packButton
            // 
            this.packButton.Location = new System.Drawing.Point(326, 449);
            this.packButton.Name = "packButton";
            this.packButton.Size = new System.Drawing.Size(118, 23);
            this.packButton.TabIndex = 10;
            this.packButton.Text = "포장 해갈게요";
            this.packButton.UseVisualStyleBackColor = true;
            this.packButton.Click += new System.EventHandler(this.packButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // sumPriceLbl
            // 
            this.sumPriceLbl.AutoSize = true;
            this.sumPriceLbl.Location = new System.Drawing.Point(120, 422);
            this.sumPriceLbl.Name = "sumPriceLbl";
            this.sumPriceLbl.Size = new System.Drawing.Size(58, 15);
            this.sumPriceLbl.TabIndex = 11;
            this.sumPriceLbl.Text = "총 금액 : ";
            this.sumPriceLbl.Click += new System.EventHandler(this.sumPriceLbl_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // orderGridView2
            // 
            this.orderGridView2.AllowUserToAddRows = false;
            this.orderGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Price,
            this.count});
            this.orderGridView2.Location = new System.Drawing.Point(70, 91);
            this.orderGridView2.Name = "orderGridView2";
            this.orderGridView2.ReadOnly = true;
            this.orderGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.orderGridView2.RowHeadersVisible = false;
            this.orderGridView2.RowTemplate.Height = 25;
            this.orderGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.orderGridView2.Size = new System.Drawing.Size(455, 314);
            this.orderGridView2.TabIndex = 13;
            // 
            // ItemName
            // 
            this.ItemName.Frozen = true;
            this.ItemName.HeaderText = "상품명";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 250;
            // 
            // Price
            // 
            this.Price.Frozen = true;
            this.Price.HeaderText = "가격";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 130;
            // 
            // count
            // 
            this.count.Frozen = true;
            this.count.HeaderText = "개수";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // paymentBtn
            // 
            this.paymentBtn.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentBtn.Location = new System.Drawing.Point(326, 551);
            this.paymentBtn.Name = "paymentBtn";
            this.paymentBtn.Size = new System.Drawing.Size(199, 96);
            this.paymentBtn.TabIndex = 14;
            this.paymentBtn.Text = "결제";
            this.paymentBtn.UseVisualStyleBackColor = true;
            this.paymentBtn.Click += new System.EventHandler(this.paymentBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("메이플스토리", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(212, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 54);
            this.label1.TabIndex = 15;
            this.label1.Text = "주문결제";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(584, 781);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paymentBtn);
            this.Controls.Add(this.orderGridView2);
            this.Controls.Add(this.sumPriceLbl);
            this.Controls.Add(this.packButton);
            this.Controls.Add(this.storeButton);
            this.Controls.Add(this.packRButton);
            this.Controls.Add(this.storeRButton);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.HelpProvider r;
        private System.Windows.Forms.RadioButton storeRButton;
        private System.Windows.Forms.RadioButton packRButton;
        private System.Windows.Forms.Button storeButton;
        private System.Windows.Forms.Button packButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DataGridView orderGridView2;
        private System.Windows.Forms.Label sumPriceLbl;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button paymentBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.Label label1;
    }
}