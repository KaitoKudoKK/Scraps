namespace WinFormsApp1
{
    partial class AddProductUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductUserControl));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();

            tbNamaProduk = new TextBox();
            tbUkuranProduk = new TextBox();
            tbDurasiPakaiProduk = new TextBox();
            tbKondisiProduk = new TextBox();
            tbHargaProduk = new TextBox();
            label7 = new Label();
            pbProductImage = new PictureBox();
            btnAddProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(648, 149);
            label2.Name = "label2";
            label2.Size = new Size(146, 26);
            label2.TabIndex = 1;
            label2.Text = "Nama Produk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16.2F);
            label3.Location = new Point(648, 226);
            label3.Name = "label3";
            label3.Size = new Size(82, 26);
            label3.TabIndex = 2;
            label3.Text = "Ukuran";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 16.2F);
            label4.Location = new Point(648, 301);
            label4.Name = "label4";
            label4.Size = new Size(136, 26);
            label4.TabIndex = 3;
            label4.Text = "Durasi Pakai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16.2F);
            label5.Location = new Point(648, 377);
            label5.Name = "label5";
            label5.Size = new Size(84, 26);
            label5.TabIndex = 4;
            label5.Text = "Kondisi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 16.2F);
            label6.Location = new Point(648, 454);
            label6.Name = "label6";
            label6.Size = new Size(71, 26);
            label6.TabIndex = 5;
            label6.Text = "Harga";
            // 
            // tbNamaProduk
            // 
            tbNamaProduk.BorderStyle = BorderStyle.None;
            tbNamaProduk.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            tbNamaProduk.Location = new Point(828, 142);
            tbNamaProduk.Margin = new Padding(3, 2, 3, 2);
            tbNamaProduk.Name = "tbNamaProduk";
            tbNamaProduk.Size = new Size(754, 55);
            tbNamaProduk.TabIndex = 6;
            // 
            // tbUkuranProduk
            // 
            tbUkuranProduk.BorderStyle = BorderStyle.None;
            tbUkuranProduk.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbUkuranProduk.Location = new Point(828, 217);
            tbUkuranProduk.Margin = new Padding(3, 2, 3, 2);
            tbUkuranProduk.Name = "tbUkuranProduk";
            tbUkuranProduk.Size = new Size(754, 55);
            tbUkuranProduk.TabIndex = 7;
            // 
            // tbDurasiPakaiProduk
            // 
            tbDurasiPakaiProduk.BorderStyle = BorderStyle.None;
            tbDurasiPakaiProduk.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbDurasiPakaiProduk.Location = new Point(828, 290);
            tbDurasiPakaiProduk.Margin = new Padding(3, 2, 3, 2);
            tbDurasiPakaiProduk.Name = "tbDurasiPakaiProduk";
            tbDurasiPakaiProduk.Size = new Size(754, 55);
            tbDurasiPakaiProduk.TabIndex = 8;
            // 
            // tbKondisiProduk
            // 
            tbKondisiProduk.BorderStyle = BorderStyle.None;
            tbKondisiProduk.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbKondisiProduk.Location = new Point(828, 367);
            tbKondisiProduk.Margin = new Padding(3, 2, 3, 2);
            tbKondisiProduk.Name = "tbKondisiProduk";
            tbKondisiProduk.Size = new Size(754, 55);
            tbKondisiProduk.TabIndex = 9;
            // 
            // tbHargaProduk
            // 
            tbHargaProduk.BorderStyle = BorderStyle.None;
            tbHargaProduk.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbHargaProduk.Location = new Point(828, 444);
            tbHargaProduk.Margin = new Padding(3, 2, 3, 2);
            tbHargaProduk.Name = "tbHargaProduk";
            tbHargaProduk.Size = new Size(754, 55);
            tbHargaProduk.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 64F, FontStyle.Bold, GraphicsUnit.Pixel);
            label7.Location = new Point(130, 0);
            label7.Name = "label7";
            label7.Size = new Size(397, 73);
            label7.TabIndex = 12;
            label7.Text = "Add Product";
            // 
            // pbProductImage
            // 
            pbProductImage.Cursor = Cursors.Hand;
            pbProductImage.Image = (Image)resources.GetObject("pbProductImage.Image");
            pbProductImage.InitialImage = (Image)resources.GetObject("pbProductImage.InitialImage");
            pbProductImage.Location = new Point(93, 107);
            pbProductImage.Margin = new Padding(0);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(442, 472);
            pbProductImage.TabIndex = 13;
            pbProductImage.TabStop = false;
            pbProductImage.Click += pbProductImage_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(7, 79, 84);
            btnAddProduct.Cursor = Cursors.Hand;
            btnAddProduct.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(828, 556);
            btnAddProduct.Margin = new Padding(3, 2, 3, 2);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(258, 60);
            btnAddProduct.TabIndex = 20;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // AddProductUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddProduct);
            Controls.Add(pbProductImage);
            Controls.Add(label7);
            Controls.Add(tbHargaProduk);
            Controls.Add(tbKondisiProduk);
            Controls.Add(tbDurasiPakaiProduk);
            Controls.Add(tbUkuranProduk);
            Controls.Add(tbNamaProduk);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            ForeColor = Color.Black;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddProductUserControl";
            Size = new Size(1680, 681);
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbNamaProduk;
        private TextBox tbUkuranProduk;
        private TextBox tbDurasiPakaiProduk;
        private TextBox tbKondisiProduk;
        private TextBox tbHargaProduk;
        private Label label7;
        private PictureBox pbProductImage;
        private Button btnAddProduct;
    }
}
