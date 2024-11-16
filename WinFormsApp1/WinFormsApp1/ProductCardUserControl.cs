using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ProductCardUserControl : UserControl
    {
        public ProductCardUserControl()
        {
            InitializeComponent();
        }

        // Method to load product data into the control
        public void LoadProductData(string productName, Image productImage, decimal productPrice,
                                    string productSize, string productDuration, string productCondition, string sellerName)
        {
            ProductName = productName;
            ProductImage = productImage;
            ProductDetails = $"Harga: Rp{productPrice:N0}\n" +
                             $"Ukuran: {productSize}\n" +
                             $"Durasi Pakai: {productDuration}\n" +
                             $"Kondisi: {productCondition}\n" +
                             $"Penjual: {sellerName}";

            // You can set additional properties such as product rating or add buttons for actions if needed
        }

        private void ProductCardUserControl_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(128, 7, 79, 84);
            lblProductDetails.BackColor = Color.FromArgb(0, 0, 0, 0);
            lblProductName.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void btnAdd_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            // Membuat button berbentuk lingkaran
            buttonPath.AddEllipse(0, 0, btnAdd.Width, btnAdd.Height);
            btnAdd.Region = new Region(buttonPath);
        }

        // Property for product name
        public string ProductName
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }

        // Property for product image
        public Image ProductImage
        {
            get { return pictureBoxProduct.Image; }
            set { pictureBoxProduct.Image = value; }
        }

        // Property for product details (price, size, condition, etc.)
        public string ProductDetails
        {
            get { return lblProductDetails.Text; }
            set { lblProductDetails.Text = value; }
        }
    }
}
