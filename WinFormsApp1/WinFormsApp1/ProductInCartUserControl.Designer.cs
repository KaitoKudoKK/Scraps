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
            numericUpDown1 = new NumericUpDown();
            lblHarga = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSubtotalProduk
            // 
            lblSubtotalProduk.AutoSize = true;
            lblSubtotalProduk.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            lblSubtotalProduk.Location = new Point(918, 69);
            lblSubtotalProduk.Name = "lblSubtotalProduk";
            lblSubtotalProduk.Size = new Size(106, 29);
            lblSubtotalProduk.TabIndex = 20;
            lblSubtotalProduk.Text = "Subtotal";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(688, 78);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(47, 27);
            numericUpDown1.TabIndex = 19;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            lblHarga.Location = new Point(334, 72);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(81, 29);
            lblHarga.TabIndex = 18;
            lblHarga.Text = "Harga";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 181);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // ProductInCartUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblSubtotalProduk);
            Controls.Add(numericUpDown1);
            Controls.Add(lblHarga);
            Controls.Add(pictureBox1);
            Name = "ProductInCartUserControl";
            Size = new Size(1056, 200);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubtotalProduk;
        private NumericUpDown numericUpDown1;
        private Label lblHarga;
        private PictureBox pictureBox1;
    }
}
