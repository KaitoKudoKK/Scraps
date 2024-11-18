namespace WinFormsApp1
{
    partial class EditAkunUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            panel4 = new Panel();
            txtAlamat = new TextBox();
            label8 = new Label();
            panel2 = new Panel();
            txtEmail = new TextBox();
            label3 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            txtName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            btnChat = new Button();
            image1 = new PictureBox();
            textBox1 = new TextBox();
            txtNoHP = new TextBox();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(7, 79, 84);
            button1.Font = new Font("Microsoft Sans Serif", 34F, FontStyle.Regular, GraphicsUnit.Pixel);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(1511, 794);
            button1.Name = "button1";
            button1.Size = new Size(169, 61);
            button1.TabIndex = 53;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label13
            // 
            label13.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold, GraphicsUnit.Pixel);
            label13.Location = new Point(221, 622);
            label13.Name = "label13";
            label13.Size = new Size(280, 50);
            label13.TabIndex = 48;
            label13.Text = "Alamat";
            // 
            // label12
            // 
            label12.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold, GraphicsUnit.Pixel);
            label12.Location = new Point(221, 509);
            label12.Name = "label12";
            label12.Size = new Size(280, 50);
            label12.TabIndex = 47;
            label12.Text = "Nomor HP";
            // 
            // label11
            // 
            label11.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold, GraphicsUnit.Pixel);
            label11.Location = new Point(221, 398);
            label11.Name = "label11";
            label11.Size = new Size(280, 50);
            label11.TabIndex = 46;
            label11.Text = "Email";
            // 
            // label10
            // 
            label10.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold, GraphicsUnit.Pixel);
            label10.Location = new Point(221, 277);
            label10.Name = "label10";
            label10.Size = new Size(280, 50);
            label10.TabIndex = 45;
            label10.Text = "Nama";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(txtAlamat);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(221, 674);
            panel4.Name = "panel4";
            panel4.Size = new Size(1462, 60);
            panel4.TabIndex = 44;
            // 
            // txtAlamat
            // 
            txtAlamat.BorderStyle = BorderStyle.None;
            txtAlamat.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAlamat.Location = new Point(0, 0);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(1462, 60);
            txtAlamat.TabIndex = 10;
            txtAlamat.TextChanged += textBox4_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label8.Location = new Point(1455, 75);
            label8.Name = "label8";
            label8.Size = new Size(76, 29);
            label8.TabIndex = 8;
            label8.Text = "16.35";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(221, 449);
            panel2.Name = "panel2";
            panel2.Size = new Size(1462, 60);
            panel2.TabIndex = 42;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.Location = new Point(-3, 0);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(1465, 60);
            txtEmail.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label3.Location = new Point(1455, 75);
            label3.Name = "label3";
            label3.Size = new Size(76, 29);
            label3.TabIndex = 8;
            label3.Text = "16.35";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label5.ForeColor = Color.FromArgb(7, 79, 84);
            label5.Location = new Point(55, 10);
            label5.Name = "label5";
            label5.Size = new Size(0, 0);
            label5.TabIndex = 6;
            label5.Text = "kaitokudokk@gmail.com";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(221, 329);
            panel1.Name = "panel1";
            panel1.Size = new Size(1462, 60);
            panel1.TabIndex = 41;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.Location = new Point(0, 0);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(1462, 60);
            txtName.TabIndex = 9;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label4.Location = new Point(1455, 75);
            label4.Name = "label4";
            label4.Size = new Size(76, 29);
            label4.TabIndex = 8;
            label4.Text = "16.35";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label2.ForeColor = Color.FromArgb(7, 79, 84);
            label2.Location = new Point(55, 12);
            label2.Name = "label2";
            label2.Size = new Size(0, 0);
            label2.TabIndex = 6;
            label2.Text = "Steven";
            // 
            // btnChat
            // 
            btnChat.BackColor = Color.Transparent;
            btnChat.BackgroundImageLayout = ImageLayout.None;
            btnChat.Cursor = Cursors.Hand;
            btnChat.FlatAppearance.BorderSize = 0;
            btnChat.FlatStyle = FlatStyle.Flat;
            btnChat.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btnChat.ForeColor = Color.Gray;
            btnChat.Location = new Point(868, 240);
            btnChat.Margin = new Padding(0);
            btnChat.Name = "btnChat";
            btnChat.Size = new Size(482, 38);
            btnChat.TabIndex = 40;
            btnChat.Text = "Upload Image";
            btnChat.UseVisualStyleBackColor = false;
            btnChat.Click += btnChat_Click_3;
            // 
            // image1
            // 
            image1.Location = new Point(1006, 63);
            image1.Name = "image1";
            image1.Size = new Size(192, 168);
            image1.SizeMode = PictureBoxSizeMode.Zoom;
            image1.TabIndex = 39;
            image1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 54;
            // 
            // txtNoHP
            // 
            txtNoHP.BorderStyle = BorderStyle.None;
            txtNoHP.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNoHP.Location = new Point(221, 559);
            txtNoHP.Multiline = true;
            txtNoHP.Name = "txtNoHP";
            txtNoHP.Size = new Size(1462, 60);
            txtNoHP.TabIndex = 11;
            // 
            // EditAkunUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtNoHP);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnChat);
            Controls.Add(image1);
            Name = "EditAkunUserControl";
            Size = new Size(1904, 947);
            Load += AkunuserControl_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)image1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label4;
        private Label label2;
        private Button button1;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Panel panel4;
        private Label label8;
        private Panel panel2;
        private Label label3;
        private Label label5;
        private TextBox txtName;
        private Button btnChat;
        private PictureBox image1;
        private TextBox textBox1;
        private TextBox txtAlamat;
        private TextBox txtEmail;
        private TextBox txtNoHP;
    }
}
