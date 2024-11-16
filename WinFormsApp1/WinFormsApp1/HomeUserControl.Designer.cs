namespace WinFormsApp1
{
    partial class HomeUserControl
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
            flowLayoutPanelProducts = new FlowLayoutPanel();
            productCardUserControl1 = new ProductCardUserControl();
            flowLayoutPanelProducts.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Medium", 64F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label1.Location = new Point(124, 0);
            label1.Name = "label1";
            label1.Size = new Size(298, 88);
            label1.TabIndex = 2;
            label1.Text = "Product";
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.Controls.Add(productCardUserControl1);
            flowLayoutPanelProducts.Location = new Point(142, 135);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Size = new Size(1600, 677);
            flowLayoutPanelProducts.TabIndex = 11;
            // 
            // productCardUserControl1
            // 
            productCardUserControl1.Location = new Point(3, 3);
            productCardUserControl1.Name = "productCardUserControl1";
            productCardUserControl1.ProductDetails = "Harga : -\r\nUkuran : -\r\nBahan : -\r\nDurasi Pakai : - \r\nKondisi : -";
            productCardUserControl1.ProductImage = null;
            productCardUserControl1.Size = new Size(538, 674);
            productCardUserControl1.TabIndex = 0;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(flowLayoutPanelProducts);
            Name = "HomeUserControl";
            Size = new Size(1902, 908);
            Load += HomeUserControl_Load;
            flowLayoutPanelProducts.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private FlowLayoutPanel flowLayoutPanelProducts;
        private ProductCardUserControl productCardUserControl1;
    }
}
