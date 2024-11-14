namespace WinFormsApp1
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbUsername = new TextBox();
            tbEmail = new TextBox();
            tbPhone = new TextBox();
            tbAddress = new TextBox();
            tbPassword = new TextBox();
            label7 = new Label();
            btnRegister = new Button();
            label8 = new Label();
            lblLogin = new Label();
            rbBuyer = new RadioButton();
            rbSeller = new RadioButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 29);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 40F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label2.Location = new Point(100, 252);
            label2.Name = "label2";
            label2.Size = new Size(236, 46);
            label2.TabIndex = 1;
            label2.Text = "Username : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 40F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.Location = new Point(100, 308);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(153, 46);
            label3.TabIndex = 2;
            label3.Text = "Email : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 40F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.Location = new Point(100, 369);
            label4.Name = "label4";
            label4.Size = new Size(169, 46);
            label4.TabIndex = 3;
            label4.Text = "Phone : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 40F, FontStyle.Regular, GraphicsUnit.Pixel);
            label5.Location = new Point(100, 482);
            label5.Name = "label5";
            label5.Size = new Size(229, 46);
            label5.TabIndex = 4;
            label5.Text = "Password : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 40F, FontStyle.Regular, GraphicsUnit.Pixel);
            label6.Location = new Point(100, 425);
            label6.Name = "label6";
            label6.Size = new Size(188, 46);
            label6.TabIndex = 5;
            label6.Text = "Address :";
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.FixedSingle;
            tbUsername.Font = new Font("Microsoft Sans Serif", 35F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbUsername.Location = new Point(328, 257);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(445, 47);
            tbUsername.TabIndex = 6;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.FixedSingle;
            tbEmail.Font = new Font("Microsoft Sans Serif", 35F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbEmail.Location = new Point(328, 314);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(445, 47);
            tbEmail.TabIndex = 7;
            // 
            // tbPhone
            // 
            tbPhone.BorderStyle = BorderStyle.FixedSingle;
            tbPhone.Font = new Font("Microsoft Sans Serif", 35F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPhone.Location = new Point(328, 374);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(445, 47);
            tbPhone.TabIndex = 8;
            // 
            // tbAddress
            // 
            tbAddress.BorderStyle = BorderStyle.FixedSingle;
            tbAddress.Font = new Font("Microsoft Sans Serif", 35F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbAddress.Location = new Point(328, 430);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(445, 47);
            tbAddress.TabIndex = 9;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.FixedSingle;
            tbPassword.Font = new Font("Microsoft Sans Serif", 35F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPassword.Location = new Point(328, 487);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(445, 47);
            tbPassword.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 78F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label7.ForeColor = Color.FromArgb(7, 79, 84);
            label7.Location = new Point(248, 80);
            label7.Name = "label7";
            label7.Size = new Size(464, 89);
            label7.TabIndex = 12;
            label7.Text = "Registration";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(7, 79, 84);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(421, 620);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(258, 60);
            btnRegister.TabIndex = 14;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label8.Location = new Point(329, 582);
            label8.Name = "label8";
            label8.Size = new Size(284, 29);
            label8.TabIndex = 14;
            label8.Text = "Already have an account?";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Cursor = Cursors.Hand;
            lblLogin.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblLogin.Location = new Point(602, 582);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(85, 29);
            lblLogin.TabIndex = 13;
            lblLogin.Text = "Log in";
            lblLogin.Click += lblLogin_Click;
            lblLogin.MouseEnter += lblLogin_MouseEnter;
            lblLogin.MouseLeave += lblLogin_MouseLeave;
            // 
            // rbBuyer
            // 
            rbBuyer.AutoSize = true;
            rbBuyer.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            rbBuyer.Location = new Point(324, 538);
            rbBuyer.Margin = new Padding(3, 2, 3, 2);
            rbBuyer.Name = "rbBuyer";
            rbBuyer.Size = new Size(93, 33);
            rbBuyer.TabIndex = 11;
            rbBuyer.TabStop = true;
            rbBuyer.Text = "Buyer";
            rbBuyer.UseVisualStyleBackColor = true;
            // 
            // rbSeller
            // 
            rbSeller.AutoSize = true;
            rbSeller.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            rbSeller.Location = new Point(539, 538);
            rbSeller.Margin = new Padding(3, 2, 3, 2);
            rbSeller.Name = "rbSeller";
            rbSeller.Size = new Size(95, 33);
            rbSeller.TabIndex = 12;
            rbSeller.TabStop = true;
            rbSeller.Text = "Seller";
            rbSeller.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 79, 84);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(549, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 562);
            panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(80, 291);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(517, 507);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 562);
            Controls.Add(panel1);
            Controls.Add(rbSeller);
            Controls.Add(rbBuyer);
            Controls.Add(lblLogin);
            Controls.Add(label8);
            Controls.Add(btnRegister);
            Controls.Add(label7);
            Controls.Add(tbPassword);
            Controls.Add(tbAddress);
            Controls.Add(tbPhone);
            Controls.Add(tbEmail);
            Controls.Add(tbUsername);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            KeyPreview = true;
            MaximumSize = new Size(1682, 820);
            MinimumSize = new Size(562, 280);
            Name = "RegisterForm";
            Text = "register";
            KeyDown += RegisterForm_KeyDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbUsername;
        private TextBox tbEmail;
        private TextBox tbPhone;
        private TextBox tbAddress;
        private TextBox tbPassword;
        private Label label7;
        private Button btnRegister;
        private Label label8;
        private Label lblLogin;
        private RadioButton rbBuyer;
        private RadioButton rbSeller;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}