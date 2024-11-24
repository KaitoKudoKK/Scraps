namespace WinFormsApp1
{
    partial class ProductInCartUserControl
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
            lblSubtotalProduk = new Label();
            nUDQuantity = new NumericUpDown();
            lblHarga = new Label();
            pictureBox1 = new PictureBox();
            lblNamaProduk = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)nUDQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSubtotalProduk
            // 
            lblSubtotalProduk.AutoSize = true;
            lblSubtotalProduk.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            lblSubtotalProduk.Location = new Point(1172, 79);
            lblSubtotalProduk.Name = "lblSubtotalProduk";
            lblSubtotalProduk.Size = new Size(106, 29);
            lblSubtotalProduk.TabIndex = 20;
            lblSubtotalProduk.Text = "Subtotal";
            // 
            // nUDQuantity
            // 
            nUDQuantity.Location = new Point(958, 81);
            nUDQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUDQuantity.Name = "nUDQuantity";
            nUDQuantity.Size = new Size(47, 27);
            nUDQuantity.TabIndex = 19;
            nUDQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nUDQuantity.ValueChanged += nUDQuantity_ValueChanged;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            lblHarga.Location = new Point(674, 79);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(81, 29);
            lblHarga.TabIndex = 18;
            lblHarga.Text = "Harga";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(26, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 181);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // lblNamaProduk
            // 
            lblNamaProduk.AutoSize = true;
            lblNamaProduk.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            lblNamaProduk.Location = new Point(314, 79);
            lblNamaProduk.Name = "lblNamaProduk";
            lblNamaProduk.Size = new Size(168, 29);
            lblNamaProduk.TabIndex = 21;
            lblNamaProduk.Text = "Nama Produk";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblSubtotalProduk);
            panel1.Controls.Add(lblNamaProduk);
            panel1.Controls.Add(nUDQuantity);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblHarga);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1378, 208);
            panel1.TabIndex = 22;
            // 
            // ProductInCartUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ProductInCartUserControl";
            Size = new Size(1378, 227);
            ((System.ComponentModel.ISupportInitialize)nUDQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblSubtotalProduk;
        private NumericUpDown nUDQuantity;
        private Label lblHarga;
        private PictureBox pictureBox1;
        private Label lblNamaProduk;
        private Panel panel1;
    }
}
