namespace WinFormsApp1
{
    partial class CartUserControl
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
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label10 = new Label();
            button1 = new Button();
            lblSubtotal = new Label();
            label12 = new Label();
            panel1 = new Panel();
            label13 = new Label();
            label14 = new Label();
            panel2 = new Panel();
            label15 = new Label();
            lblTotal = new Label();
            label11 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            productInCartUserControl1 = new ProductInCartUserControl();
            label6 = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 64F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label1.Location = new Point(124, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 73);
            label1.TabIndex = 3;
            label1.Text = "Cart";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label3.Location = new Point(128, 108);
            label3.Name = "label3";
            label3.Size = new Size(119, 37);
            label3.TabIndex = 6;
            label3.Text = "Produk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label2.Location = new Point(760, 108);
            label2.Name = "label2";
            label2.Size = new Size(105, 37);
            label2.TabIndex = 7;
            label2.Text = "Harga";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label4.Location = new Point(1003, 108);
            label4.Name = "label4";
            label4.Size = new Size(151, 37);
            label4.TabIndex = 8;
            label4.Text = "Kuantitas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label5.Location = new Point(1261, 108);
            label5.Name = "label5";
            label5.Size = new Size(135, 37);
            label5.TabIndex = 9;
            label5.Text = "Subtotal";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label10.Location = new Point(95, 608);
            label10.Name = "label10";
            label10.Size = new Size(159, 37);
            label10.TabIndex = 18;
            label10.Text = "Cart Total";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(7, 79, 84);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1181, 608);
            button1.Name = "button1";
            button1.Size = new Size(295, 80);
            button1.TabIndex = 19;
            button1.Text = "Checkout";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoEllipsis = true;
            lblSubtotal.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            lblSubtotal.Location = new Point(365, 654);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.RightToLeft = RightToLeft.No;
            lblSubtotal.Size = new Size(343, 33);
            lblSubtotal.TabIndex = 20;
            lblSubtotal.Text = "Rp920.000";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label12.Location = new Point(95, 654);
            label12.Name = "label12";
            label12.Size = new Size(120, 29);
            label12.TabIndex = 21;
            label12.Text = "Subtotal: ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Location = new Point(95, 690);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 2);
            panel1.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label13.Location = new Point(95, 695);
            label13.Name = "label13";
            label13.Size = new Size(227, 29);
            label13.TabIndex = 23;
            label13.Text = "Biaya Pengiriman: ";
            // 
            // label14
            // 
            label14.AutoEllipsis = true;
            label14.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label14.Location = new Point(365, 695);
            label14.Name = "label14";
            label14.RightToLeft = RightToLeft.Yes;
            label14.Size = new Size(146, 33);
            label14.TabIndex = 24;
            label14.Text = "Rp0";
            label14.TextAlign = ContentAlignment.TopRight;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(95, 731);
            panel2.Name = "panel2";
            panel2.Size = new Size(446, 2);
            panel2.TabIndex = 23;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label15.Location = new Point(95, 736);
            label15.Name = "label15";
            label15.Size = new Size(83, 29);
            label15.TabIndex = 25;
            label15.Text = "Total: ";
            // 
            // lblTotal
            // 
            lblTotal.AutoEllipsis = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            lblTotal.Location = new Point(365, 736);
            lblTotal.Name = "lblTotal";
            lblTotal.RightToLeft = RightToLeft.No;
            lblTotal.Size = new Size(345, 33);
            lblTotal.TabIndex = 26;
            lblTotal.Text = "Rp920.000";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label11.Location = new Point(692, 608);
            label11.Name = "label11";
            label11.Size = new Size(312, 37);
            label11.TabIndex = 27;
            label11.Text = "Metode Pembayaran";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(693, 654);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(139, 33);
            radioButton1.TabIndex = 28;
            radioButton1.TabStop = true;
            radioButton1.Text = "Bank BRI ";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(692, 693);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(139, 33);
            radioButton2.TabIndex = 29;
            radioButton2.TabStop = true;
            radioButton2.Text = "Bank BRI ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(productInCartUserControl1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(95, 179);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1381, 368);
            flowLayoutPanel1.TabIndex = 30;
            flowLayoutPanel1.WrapContents = false;
            // 
            // productInCartUserControl1
            // 
            productInCartUserControl1.Location = new Point(3, 3);
            productInCartUserControl1.Name = "productInCartUserControl1";
            productInCartUserControl1.ProductImage = null;
            productInCartUserControl1.ProductPrice = 0D;
            productInCartUserControl1.Quantity = 1;
            productInCartUserControl1.Size = new Size(1378, 227);
            productInCartUserControl1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label6.Location = new Point(386, 108);
            label6.Name = "label6";
            label6.Size = new Size(215, 37);
            label6.TabIndex = 31;
            label6.Text = "Nama Produk";
            // 
            // CartUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label11);
            Controls.Add(lblTotal);
            Controls.Add(label15);
            Controls.Add(panel2);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(panel1);
            Controls.Add(label12);
            Controls.Add(lblSubtotal);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Name = "CartUserControl";
            Size = new Size(1920, 908);
            Load += CartUserControl_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label10;
        private Button button1;
        private Label lblSubtotal;
        private Label label12;
        private Panel panel1;
        private Label label13;
        private Label label14;
        private Panel panel2;
        private Label label15;
        private Label lblTotal;
        private Label label11;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private FlowLayoutPanel flowLayoutPanel1;
        private ProductInCartUserControl productInCartUserControl1;
        private Label label6;
    }
}
