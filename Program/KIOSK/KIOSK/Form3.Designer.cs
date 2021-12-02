
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.r = new System.Windows.Forms.HelpProvider();
            this.storeRButton = new System.Windows.Forms.RadioButton();
            this.packRButton = new System.Windows.Forms.RadioButton();
            this.storeButton = new System.Windows.Forms.Button();
            this.packButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 38);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.backBtn.Location = new System.Drawing.Point(13, 44);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "뒤로가기";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // storeRButton
            // 
            this.storeRButton.AutoSize = true;
            this.storeRButton.Enabled = false;
            this.storeRButton.Location = new System.Drawing.Point(156, 422);
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
            this.packRButton.Location = new System.Drawing.Point(355, 422);
            this.packRButton.Name = "packRButton";
            this.packRButton.Size = new System.Drawing.Size(49, 19);
            this.packRButton.TabIndex = 8;
            this.packRButton.TabStop = true;
            this.packRButton.Text = "포장";
            this.packRButton.UseVisualStyleBackColor = true;
            // 
            // storeButton
            // 
            this.storeButton.Location = new System.Drawing.Point(118, 382);
            this.storeButton.Name = "storeButton";
            this.storeButton.Size = new System.Drawing.Size(122, 23);
            this.storeButton.TabIndex = 9;
            this.storeButton.Text = "매장에서 먹을게요";
            this.storeButton.UseVisualStyleBackColor = true;
            this.storeButton.Click += new System.EventHandler(this.storeButton_Click);
            // 
            // packButton
            // 
            this.packButton.Location = new System.Drawing.Point(324, 382);
            this.packButton.Name = "packButton";
            this.packButton.Size = new System.Drawing.Size(118, 23);
            this.packButton.TabIndex = 10;
            this.packButton.Text = "포장 해갈게요";
            this.packButton.UseVisualStyleBackColor = true;
            this.packButton.Click += new System.EventHandler(this.packButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(584, 781);
            this.Controls.Add(this.packButton);
            this.Controls.Add(this.storeButton);
            this.Controls.Add(this.packRButton);
            this.Controls.Add(this.storeRButton);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
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
    }
}