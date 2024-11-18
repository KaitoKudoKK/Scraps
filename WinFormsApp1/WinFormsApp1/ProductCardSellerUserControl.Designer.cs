namespace WinFormsApp1
{
    partial class ProductCardSellerUserControl
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
            panel1 = new Panel();
            lblProductDetails = new Label();
            lblProductName = new Label();
            pictureBoxProduct = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lblProductDetails);
            panel1.Controls.Add(lblProductName);
            panel1.Controls.Add(pictureBoxProduct);
            panel1.Location = new Point(13, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 503);
            panel1.TabIndex = 2;
            // 
            // lblProductDetails
            // 
            lblProductDetails.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            lblProductDetails.Location = new Point(14, 303);
            lblProductDetails.Name = "lblProductDetails";
            lblProductDetails.Size = new Size(325, 184);
            lblProductDetails.TabIndex = 5;
            lblProductDetails.Text = "Harga : -\r\nUkuran : -\r\nBahan : -\r\nDurasi Pakai : - \r\nKondisi : -";
            // 
            // lblProductName
            // 
            lblProductName.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            lblProductName.Location = new Point(14, 14);
            lblProductName.Margin = new Padding(0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(395, 50);
            lblProductName.TabIndex = 3;
            lblProductName.Text = "Nama Produk";
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.Location = new Point(0, 78);
            pictureBoxProduct.Margin = new Padding(3, 2, 3, 2);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(424, 210);
            pictureBoxProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProduct.TabIndex = 10;
            pictureBoxProduct.TabStop = false;
            // 
            // ProductCardSellerUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ProductCardSellerUserControl";
            Size = new Size(450, 503);
            Load += ProductCardSellerUserControl_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblProductDetails;
        private Label lblProductName;
        private PictureBox pictureBoxProduct;
    }
}
