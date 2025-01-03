﻿namespace GUI
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            mainboard = new Panel();
            panel4 = new Panel();
            totalStaff_tb = new Label();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            panel3 = new Panel();
            totalCustomer_tb = new Label();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            panel2 = new Panel();
            totalIncome_tb = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            todayIncome_tb = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            mainboard.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainboard
            // 
            mainboard.BackColor = Color.FromArgb(242, 239, 229);
            mainboard.Controls.Add(panel4);
            mainboard.Controls.Add(panel3);
            mainboard.Controls.Add(panel2);
            mainboard.Controls.Add(panel1);
            mainboard.Controls.Add(label1);
            mainboard.Controls.Add(pictureBox1);
            mainboard.ForeColor = SystemColors.ActiveCaptionText;
            mainboard.Location = new Point(0, -1);
            mainboard.Margin = new Padding(3, 2, 3, 2);
            mainboard.Name = "mainboard";
            mainboard.Size = new Size(965, 548);
            mainboard.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(141, 123, 104);
            panel4.Controls.Add(totalStaff_tb);
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(483, 320);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(207, 131);
            panel4.TabIndex = 5;
            // 
            // totalStaff_tb
            // 
            totalStaff_tb.AutoSize = true;
            totalStaff_tb.Font = new Font("Segoe UI", 13F);
            totalStaff_tb.ForeColor = Color.White;
            totalStaff_tb.Location = new Point(77, 62);
            totalStaff_tb.Name = "totalStaff_tb";
            totalStaff_tb.Size = new Size(22, 25);
            totalStaff_tb.TabIndex = 11;
            totalStaff_tb.Text = "0";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(142, 79);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(52, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(70, 10);
            label5.Name = "label5";
            label5.Size = new Size(49, 17);
            label5.TabIndex = 9;
            label5.Text = "Staff   ";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(141, 123, 104);
            panel3.Controls.Add(totalCustomer_tb);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(704, 320);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(207, 131);
            panel3.TabIndex = 4;
            // 
            // totalCustomer_tb
            // 
            totalCustomer_tb.AutoSize = true;
            totalCustomer_tb.Font = new Font("Segoe UI", 13F);
            totalCustomer_tb.ForeColor = Color.White;
            totalCustomer_tb.Location = new Point(73, 62);
            totalCustomer_tb.Name = "totalCustomer_tb";
            totalCustomer_tb.Size = new Size(22, 25);
            totalCustomer_tb.TabIndex = 10;
            totalCustomer_tb.Text = "0";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(143, 79);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(10, 10);
            label4.Name = "label4";
            label4.Size = new Size(163, 17);
            label4.TabIndex = 8;
            label4.Text = "Membership customer    ";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(141, 123, 104);
            panel2.Controls.Add(totalIncome_tb);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(704, 136);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(207, 131);
            panel2.TabIndex = 3;
            // 
            // totalIncome_tb
            // 
            totalIncome_tb.AutoSize = true;
            totalIncome_tb.Font = new Font("Segoe UI", 13F);
            totalIncome_tb.ForeColor = Color.White;
            totalIncome_tb.Location = new Point(73, 57);
            totalIncome_tb.Name = "totalIncome_tb";
            totalIncome_tb.Size = new Size(22, 25);
            totalIncome_tb.TabIndex = 9;
            totalIncome_tb.Text = "0";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(143, 80);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(38, 13);
            label3.Name = "label3";
            label3.Size = new Size(111, 17);
            label3.TabIndex = 7;
            label3.Text = "Total income ($)";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(141, 123, 104);
            panel1.Controls.Add(todayIncome_tb);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(483, 136);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 131);
            panel1.TabIndex = 2;
            // 
            // todayIncome_tb
            // 
            todayIncome_tb.AutoSize = true;
            todayIncome_tb.Font = new Font("Segoe UI", 13F);
            todayIncome_tb.ForeColor = Color.White;
            todayIncome_tb.Location = new Point(77, 57);
            todayIncome_tb.Name = "todayIncome_tb";
            todayIncome_tb.Size = new Size(22, 25);
            todayIncome_tb.TabIndex = 8;
            todayIncome_tb.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(142, 80);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(33, 13);
            label2.Name = "label2";
            label2.Size = new Size(129, 17);
            label2.TabIndex = 6;
            label2.Text = "Today's income ($)";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(597, 62);
            label1.Name = "label1";
            label1.Size = new Size(187, 31);
            label1.TabIndex = 1;
            label1.Text = "DASHBOARD";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Coffee1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 548);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 546);
            Controls.Add(mainboard);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboard";
            Load += dashboard_Load_1;
            mainboard.ResumeLayout(false);
            mainboard.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainboard;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private Panel panel1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label totalStaff_tb;
        private PictureBox pictureBox5;
        private Label totalCustomer_tb;
        private PictureBox pictureBox4;
        private Label totalIncome_tb;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label todayIncome_tb;
    }
}