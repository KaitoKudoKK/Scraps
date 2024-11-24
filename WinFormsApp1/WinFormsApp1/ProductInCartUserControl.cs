using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ProductInCartUserControl : UserControl
    {
        public string ProductNameIC { get; set; }
        public double ProductPrice { get; set; }
        public Image ProductImage
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }

        public int Quantity
        {
            get => (int)nUDQuantity.Value;
            set => nUDQuantity.Value = value;
        }

        public double Subtotal
        {
            get => ProductPrice * Quantity;
            private set => lblSubtotalProduk.Text = $"Rp{value:N0}";
        }

        public ProductInCartUserControl()
        {
            InitializeComponent();
        }

        public void LoadProduct(string productName, double productPrice, Image productImage, int quantity = 1)
        {
            ProductNameIC = productName;
            ProductPrice = productPrice;
            ProductImage = productImage;
            Quantity = quantity;
            lblHarga.Text = $"Harga: Rp{ProductPrice:N0}";
            Subtotal = ProductPrice * Quantity;
        }

        private void nUDQuantity_ValueChanged(object sender, EventArgs e)
        {
            Subtotal = ProductPrice * Quantity;
        }
    }
}
