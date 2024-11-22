namespace GUI
{
    partial class SignUp
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
            btnRegister = new Button();
            ckbShowPass = new CheckBox();
            tbPass = new TextBox();
            lbPass = new Label();
            tbUsername = new TextBox();
            lbUser = new Label();
            lbSignUp = new Label();
            btnExit = new Label();
            tbCP = new TextBox();
            lbCP = new Label();
            panel1 = new Panel();
            btnSignIn = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label = new Label();
            cbGender = new ComboBox();
            cbRole = new ComboBox();
            tbPhoneNumber = new TextBox();
            label3 = new Label();
            dob = new DateTimePicker();
            label5 = new Label();
            tbFullname = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(126, 99, 99);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.FromArgb(242, 239, 229);
            btnRegister.Location = new Point(545, 450);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(110, 42);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // ckbShowPass
            // 
            ckbShowPass.AutoSize = true;
            ckbShowPass.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbShowPass.ForeColor = Color.FromArgb(126, 99, 99);
            ckbShowPass.Location = new Point(433, 420);
            ckbShowPass.Name = "ckbShowPass";
            ckbShowPass.Size = new Size(136, 22);
            ckbShowPass.TabIndex = 11;
            ckbShowPass.Text = "Show Password";
            ckbShowPass.UseVisualStyleBackColor = true;
            ckbShowPass.CheckedChanged += ckbShowPass_CheckedChanged;
            // 
            // tbPass
            // 
            tbPass.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPass.Location = new Point(433, 334);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(325, 26);
            tbPass.TabIndex = 7;
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPass.ForeColor = Color.FromArgb(126, 99, 99);
            lbPass.Location = new Point(433, 312);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(75, 18);
            lbPass.TabIndex = 14;
            lbPass.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(433, 281);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(325, 26);
            tbUsername.TabIndex = 6;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUser.ForeColor = Color.FromArgb(126, 99, 99);
            lbUser.Location = new Point(433, 260);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(77, 18);
            lbUser.TabIndex = 12;
            lbUser.Text = "Username";
            // 
            // lbSignUp
            // 
            lbSignUp.AutoSize = true;
            lbSignUp.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSignUp.ForeColor = Color.FromArgb(126, 99, 99);
            lbSignUp.Location = new Point(558, 14);
            lbSignUp.Name = "lbSignUp";
            lbSignUp.Size = new Size(84, 24);
            lbSignUp.TabIndex = 11;
            lbSignUp.Text = "SIGN UP";
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(754, 9);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(20, 20);
            btnExit.TabIndex = 10;
            btnExit.Text = "X";
            btnExit.Click += btnExit_Click;
            // 
            // tbCP
            // 
            tbCP.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCP.Location = new Point(433, 388);
            tbCP.Name = "tbCP";
            tbCP.PasswordChar = '*';
            tbCP.Size = new Size(325, 26);
            tbCP.TabIndex = 8;
            // 
            // lbCP
            // 
            lbCP.AutoSize = true;
            lbCP.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCP.ForeColor = Color.FromArgb(126, 99, 99);
            lbCP.Location = new Point(433, 366);
            lbCP.Name = "lbCP";
            lbCP.Size = new Size(132, 18);
            lbCP.TabIndex = 18;
            lbCP.Text = "Confirm Password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(126, 99, 99);
            panel1.Controls.Add(btnSignIn);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 513);
            panel1.TabIndex = 20;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(242, 239, 229);
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.FromArgb(126, 99, 99);
            btnSignIn.Location = new Point(88, 450);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(225, 42);
            btnSignIn.TabIndex = 10;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.AUBERT;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 513);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(126, 99, 99);
            label1.Location = new Point(433, 37);
            label1.Name = "label1";
            label1.Size = new Size(72, 18);
            label1.TabIndex = 21;
            label1.Text = "Full name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(126, 99, 99);
            label2.Location = new Point(433, 150);
            label2.Name = "label2";
            label2.Size = new Size(39, 18);
            label2.TabIndex = 23;
            label2.Text = "Role";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = Color.FromArgb(126, 99, 99);
            label.Location = new Point(598, 150);
            label.Name = "label";
            label.Size = new Size(57, 18);
            label.TabIndex = 25;
            label.Text = "Gender";
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(598, 170);
            cbGender.Margin = new Padding(3, 2, 3, 2);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(160, 23);
            cbGender.TabIndex = 4;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(433, 170);
            cbRole.Margin = new Padding(3, 2, 3, 2);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(158, 23);
            cbRole.TabIndex = 3;
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPhoneNumber.Location = new Point(433, 223);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(325, 26);
            tbPhoneNumber.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(126, 99, 99);
            label3.Location = new Point(433, 202);
            label3.Name = "label3";
            label3.Size = new Size(105, 18);
            label3.TabIndex = 30;
            label3.Text = "Phone number";
            // 
            // dob
            // 
            dob.CalendarFont = new Font("Segoe UI", 12F);
            dob.Location = new Point(433, 116);
            dob.Margin = new Padding(3, 2, 3, 2);
            dob.Name = "dob";
            dob.Size = new Size(325, 23);
            dob.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(126, 99, 99);
            label5.Location = new Point(433, 95);
            label5.Name = "label5";
            label5.Size = new Size(88, 18);
            label5.TabIndex = 33;
            label5.Text = "Date of birth";
            // 
            // tbFullname
            // 
            tbFullname.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbFullname.Location = new Point(433, 59);
            tbFullname.Name = "tbFullname";
            tbFullname.Size = new Size(325, 26);
            tbFullname.TabIndex = 1;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 239, 229);
            ClientSize = new Size(794, 513);
            Controls.Add(label5);
            Controls.Add(dob);
            Controls.Add(label3);
            Controls.Add(tbPhoneNumber);
            Controls.Add(cbRole);
            Controls.Add(cbGender);
            Controls.Add(label);
            Controls.Add(label2);
            Controls.Add(tbFullname);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(tbCP);
            Controls.Add(lbCP);
            Controls.Add(btnRegister);
            Controls.Add(ckbShowPass);
            Controls.Add(tbPass);
            Controls.Add(lbPass);
            Controls.Add(tbUsername);
            Controls.Add(lbUser);
            Controls.Add(lbSignUp);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += SignUp_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label btnExit;
        private Label lbUser;
        private Label lbPass;
        private Label lbCP;
        private TextBox tbUsername;
        private TextBox tbPass;
        private TextBox tbCP;
        private CheckBox ckbShowPass;
        private Button btnRegister;
        private Label lbSignUp;
        private Panel panel1;
        private Button btnSignIn;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label;
        private ComboBox cbGender;
        private ComboBox cbRole;
        private TextBox tbPhoneNumber;
        private Label label3;
        private DateTimePicker dob;
        private Label label5;
        private TextBox tbFullname;
        private Label label4;
    }
}