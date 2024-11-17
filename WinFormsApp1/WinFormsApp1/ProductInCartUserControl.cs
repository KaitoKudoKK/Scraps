using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ProductInCartUserControl : UserControl
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public Image ProductImage
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }

        public int Quantity
        {
            get => (int)numericUpDown1.Value;
            set => numericUpDown1.Value = value;
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
            ProductName = productName;
            ProductPrice = productPrice;
            ProductImage = productImage;
            Quantity = quantity;
            lblHarga.Text = $"Harga: Rp{ProductPrice:N0}";
            Subtotal = ProductPrice * Quantity;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Subtotal = ProductPrice * Quantity;
        }
    }
}
