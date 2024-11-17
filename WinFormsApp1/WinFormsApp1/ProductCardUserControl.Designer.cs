namespace WinFormsApp1
{
    partial class ProductCardUserControl
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
            btnAdd = new Button();
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
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(lblProductDetails);
            panel1.Controls.Add(lblProductName);
            panel1.Controls.Add(pictureBoxProduct);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 671);
            panel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.BackgroundImageLayout = ImageLayout.None;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Montserrat Medium", 32F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btnAdd.Location = new Point(407, 404);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(60, 60);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            btnAdd.Paint += btnAdd_Paint;
            // 
            // lblProductDetails
            // 
            lblProductDetails.Font = new Font("Montserrat", 24F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            lblProductDetails.Location = new Point(16, 404);
            lblProductDetails.Name = "lblProductDetails";
            lblProductDetails.Size = new Size(371, 246);
            lblProductDetails.TabIndex = 5;
            lblProductDetails.Text = "Harga : -\r\nUkuran : -\r\nBahan : -\r\nDurasi Pakai : - \r\nKondisi : -";
            // 
            // lblProductName
            // 
            lblProductName.Font = new Font("Montserrat SemiBold", 48F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            lblProductName.Location = new Point(16, 19);
            lblProductName.Margin = new Padding(0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(451, 66);
            lblProductName.TabIndex = 3;
            lblProductName.Text = "Nama Produk";
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.Location = new Point(0, 104);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(484, 280);
            pictureBoxProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProduct.TabIndex = 10;
            pictureBoxProduct.TabStop = false;
            // 
            // ProductCardUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ProductCardUserControl";
            Size = new Size(484, 671);
            Load += ProductCardUserControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAdd;
        private Label lblProductDetails;
        private PictureBox pictureBox1;
        private Label lblProductName;
        private PictureBox pictureBoxProduct;
    }
}
