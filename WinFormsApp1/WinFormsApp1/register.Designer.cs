namespace WinFormsApp1
{
    partial class register
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
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 29);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "REGISTRATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 85);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Name : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 129);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Email : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 182);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 282);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 4;
            label5.Text = "Password : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 238);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 5;
            label6.Text = "Address :";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(123, 82);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(311, 23);
            tbUsername.TabIndex = 6;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(123, 129);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(311, 23);
            tbEmail.TabIndex = 7;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(123, 179);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(311, 23);
            tbPhone.TabIndex = 8;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(123, 235);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(311, 23);
            tbAddress.TabIndex = 9;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(123, 279);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(311, 23);
            tbPassword.TabIndex = 10;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(331, 326);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(103, 35);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
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
            Name = "register";
            Text = "register";
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
        private Button btnRegister;
    }
}