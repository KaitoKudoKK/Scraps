namespace WinFormsApp1
{
    partial class PesananMasuk
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesananMasuk));
            panel1 = new Panel();
            panel2 = new Panel();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            imageList1 = new ImageList(components);
            panel3 = new Panel();
            panel4 = new Panel();
            textBox3 = new TextBox();
            button2 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            panel6 = new Panel();
            textBox5 = new TextBox();
            button3 = new Button();
            textBox6 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(62, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 402);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(22, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(277, 335);
            panel2.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F);
            textBox2.Location = new Point(208, 230);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(56, 25);
            textBox2.TabIndex = 5;
            textBox2.Text = "BNI";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(78, 273);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(115, 41);
            button1.TabIndex = 43;
            button1.Text = "Konfirmasi";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F);
            textBox1.Location = new Point(72, 201);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 25);
            textBox1.TabIndex = 4;
            textBox1.Text = "Siti Nurmalina";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(3, 230);
            label3.Name = "label3";
            label3.Size = new Size(205, 25);
            label3.TabIndex = 3;
            label3.Text = "Metode Pembayaran :";
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(3, 201);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 2;
            label2.Text = "Buyer : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 18);
            label1.Name = "label1";
            label1.Size = new Size(60, 36);
            label1.TabIndex = 1;
            label1.Text = "laci";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(452, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(325, 402);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(22, 30);
            panel4.Name = "panel4";
            panel4.Size = new Size(277, 335);
            panel4.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 12F);
            textBox3.Location = new Point(208, 230);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(56, 25);
            textBox3.TabIndex = 5;
            textBox3.Text = "BRI";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkCyan;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(77, 273);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(115, 41);
            button2.TabIndex = 43;
            button2.Text = "Konfirmasi";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Microsoft Sans Serif", 12F);
            textBox4.Location = new Point(72, 201);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(132, 25);
            textBox4.TabIndex = 4;
            textBox4.Text = "Adinda Syala";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(3, 230);
            label4.Name = "label4";
            label4.Size = new Size(205, 25);
            label4.TabIndex = 3;
            label4.Text = "Metode Pembayaran :";
            // 
            // label5
            // 
            label5.AllowDrop = true;
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(3, 201);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 2;
            label5.Text = "Buyer : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(114, 18);
            label6.Name = "label6";
            label6.Size = new Size(60, 36);
            label6.TabIndex = 1;
            label6.Text = "laci";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(272, 138);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(856, 61);
            panel5.Name = "panel5";
            panel5.Size = new Size(325, 402);
            panel5.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(textBox5);
            panel6.Controls.Add(button3);
            panel6.Controls.Add(textBox6);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(pictureBox3);
            panel6.Location = new Point(22, 30);
            panel6.Name = "panel6";
            panel6.Size = new Size(277, 335);
            panel6.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Microsoft Sans Serif", 12F);
            textBox5.Location = new Point(208, 230);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(56, 25);
            textBox5.TabIndex = 5;
            textBox5.Text = "BRI";
            // 
            // button3
            // 
            button3.BackColor = Color.DarkCyan;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(80, 273);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(115, 41);
            button3.TabIndex = 43;
            button3.Text = "Konfirmasi";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Microsoft Sans Serif", 12F);
            textBox6.Location = new Point(72, 201);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(132, 25);
            textBox6.TabIndex = 4;
            textBox6.Text = "Kurniawan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(3, 230);
            label7.Name = "label7";
            label7.Size = new Size(205, 25);
            label7.TabIndex = 3;
            label7.Text = "Metode Pembayaran :";
            // 
            // label8
            // 
            label8.AllowDrop = true;
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(3, 201);
            label8.Name = "label8";
            label8.Size = new Size(79, 25);
            label8.TabIndex = 2;
            label8.Text = "Buyer : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(114, 18);
            label9.Name = "label9";
            label9.Size = new Size(60, 36);
            label9.TabIndex = 1;
            label9.Text = "laci";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(2, 57);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(272, 138);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // PesananMasuk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "PesananMasuk";
            Size = new Size(1902, 908);
            Load += PesananMasuk_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private Panel panel3;
        private Panel panel4;
        private TextBox textBox3;
        private Button button2;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox2;
        private Panel panel5;
        private Panel panel6;
        private TextBox textBox5;
        private Button button3;
        private TextBox textBox6;
        private Label label7;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox3;
    }
}
