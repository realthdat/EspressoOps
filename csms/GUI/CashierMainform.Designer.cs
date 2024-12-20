﻿namespace GUI
{
    partial class CashierMainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierMainform));
            mainboard = new Panel();
            navbar = new Panel();
            btnReceipt = new Button();
            btnExit = new Button();
            label_username = new Label();
            Logout = new PictureBox();
            label2 = new Label();
            btnOrder = new Button();
            btnMem = new Button();
            pictureBox1 = new PictureBox();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainboard
            // 
            mainboard.BackColor = Color.FromArgb(242, 239, 229);
            mainboard.ForeColor = Color.Turquoise;
            mainboard.Location = new Point(0, 68);
            mainboard.Margin = new Padding(3, 2, 3, 2);
            mainboard.Name = "mainboard";
            mainboard.Size = new Size(960, 552);
            mainboard.TabIndex = 0;
            // 
            // navbar
            // 
            navbar.BackColor = Color.FromArgb(227, 225, 217);
            navbar.Controls.Add(btnReceipt);
            navbar.Controls.Add(btnExit);
            navbar.Controls.Add(label_username);
            navbar.Controls.Add(Logout);
            navbar.Controls.Add(label2);
            navbar.Controls.Add(btnOrder);
            navbar.Controls.Add(btnMem);
            navbar.Controls.Add(pictureBox1);
            navbar.Location = new Point(0, -1);
            navbar.Margin = new Padding(3, 2, 3, 2);
            navbar.Name = "navbar";
            navbar.Size = new Size(960, 73);
            navbar.TabIndex = 1;
            // 
            // btnReceipt
            // 
            btnReceipt.Location = new Point(314, 12);
            btnReceipt.Margin = new Padding(3, 2, 3, 2);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(105, 42);
            btnReceipt.TabIndex = 5;
            btnReceipt.Text = "Receipt";
            btnReceipt.UseVisualStyleBackColor = true;
            btnReceipt.Click += btnReceipt_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(919, 5);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(32, 22);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Segoe UI", 13F);
            label_username.Location = new Point(805, 13);
            label_username.Name = "label_username";
            label_username.Size = new Size(59, 25);
            label_username.TabIndex = 0;
            label_username.Text = "label1";
            label_username.TextAlign = ContentAlignment.TopRight;
            label_username.Click += label_username_Click;
            // 
            // Logout
            // 
            Logout.Image = (Image)resources.GetObject("Logout.Image");
            Logout.Location = new Point(924, 42);
            Logout.Margin = new Padding(3, 2, 3, 2);
            Logout.Name = "Logout";
            Logout.Size = new Size(22, 23);
            Logout.SizeMode = PictureBoxSizeMode.Zoom;
            Logout.TabIndex = 1;
            Logout.TabStop = false;
            Logout.Click += Logout_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(721, 13);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 0;
            label2.Text = "Welcome, ";
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(195, 12);
            btnOrder.Margin = new Padding(3, 2, 3, 2);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(105, 42);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "Take order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnMem
            // 
            btnMem.Location = new Point(433, 12);
            btnMem.Margin = new Padding(3, 2, 3, 2);
            btnMem.Name = "btnMem";
            btnMem.Size = new Size(105, 42);
            btnMem.TabIndex = 1;
            btnMem.Text = "Membership Customer";
            btnMem.UseVisualStyleBackColor = true;
            btnMem.Click += btnMem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CashierMainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 621);
            Controls.Add(mainboard);
            Controls.Add(navbar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CashierMainform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainboard;
        private Panel navbar;
        private PictureBox pictureBox1;
        private Button btnMem;
        private Label label_username;
        private Label label2;
        private Button btnOrder;
        private PictureBox Logout;
        private Button btnExit;
        private Button btnReceipt;
    }
}