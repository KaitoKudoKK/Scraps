namespace WinFormsApp1
{
    partial class HomeSellerUserControl
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
            productCardUserControl1 = new ProductCardUserControl();
            flowLayoutPanelProducts = new FlowLayoutPanel();
            flowLayoutPanelProducts.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 64F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label1.Location = new Point(122, 0);
            label1.Name = "label1";
            label1.Size = new Size(366, 73);
            label1.TabIndex = 12;
            label1.Text = "My Product";
            // 
            // productCardUserControl1
            // 
            productCardUserControl1.CartControl = null;
            productCardUserControl1.Location = new Point(3, 2);
            productCardUserControl1.Margin = new Padding(3, 2, 3, 2);
            productCardUserControl1.Name = "productCardUserControl1";
            productCardUserControl1.ProductDetails = "Harga : -\r\nUkuran : -\r\nBahan : -\r\nDurasi Pakai : - \r\nKondisi : -";
            productCardUserControl1.ProductImage = null;
            productCardUserControl1.ProductPrice = 0D;
            productCardUserControl1.Size = new Size(471, 506);
            productCardUserControl1.TabIndex = 0;
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.AutoScroll = true;
            flowLayoutPanelProducts.Controls.Add(productCardUserControl1);
            flowLayoutPanelProducts.Location = new Point(94, 86);
            flowLayoutPanelProducts.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Size = new Size(1476, 508);
            flowLayoutPanelProducts.TabIndex = 13;
            // 
            // HomeSellerUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanelProducts);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomeSellerUserControl";
            Size = new Size(1664, 681);
            Load += HomeSellerUserControl_Load;
            flowLayoutPanelProducts.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ProductCardUserControl productCardUserControl1;
        private FlowLayoutPanel flowLayoutPanelProducts;
    }
}
