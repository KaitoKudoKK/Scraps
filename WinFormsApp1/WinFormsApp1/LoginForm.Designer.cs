
namespace WinFormsApp1
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbUsername = new TextBox();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(7, 79, 84);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 465);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 568);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 79, 84);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 1033);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Merriweather Sans ExtraBold", 128F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(835, 207);
            label1.TabIndex = 2;
            label1.Text = "Welcome to";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Merriweather Sans ExtraBold", 128F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 152);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(560, 207);
            label2.TabIndex = 3;
            label2.Text = "Scraps!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 78F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label3.ForeColor = Color.FromArgb(7, 79, 84);
            label3.Location = new Point(1307, 129);
            label3.Name = "label3";
            label3.Size = new Size(299, 108);
            label3.TabIndex = 2;
            label3.Text = "Log In";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 40F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label4.Location = new Point(1077, 352);
            label4.Name = "label4";
            label4.Size = new Size(261, 55);
            label4.TabIndex = 3;
            label4.Text = "Username : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 40F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label5.Location = new Point(1077, 420);
            label5.Name = "label5";
            label5.Size = new Size(167, 55);
            label5.TabIndex = 4;
            label5.Text = "Email : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 40F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label6.Location = new Point(1077, 484);
            label6.Name = "label6";
            label6.Size = new Size(245, 55);
            label6.TabIndex = 5;
            label6.Text = "Password : ";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(1344, 352);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(502, 56);
            tbUsername.TabIndex = 6;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(1344, 420);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(502, 56);
            tbEmail.TabIndex = 7;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(1344, 484);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(502, 56);
            tbPassword.TabIndex = 8;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(7, 79, 84);
            btnLogin.Font = new Font("Montserrat Medium", 32F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(1432, 590);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(295, 80);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(tbUsername);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Montserrat", 40F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            KeyPreview = true;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(640, 360);
            Name = "LoginForm";
            Text = "Login";
            FormClosed += LoginForm_FormClosed;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbUsername;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private Button btnLogin;
    }
}
#endregion