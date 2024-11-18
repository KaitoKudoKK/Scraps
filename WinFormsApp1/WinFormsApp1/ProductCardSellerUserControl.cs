using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ProductCardSellerUserControl : UserControl
    {
        public ProductCardSellerUserControl()
        {
            InitializeComponent();
        }

        public void LoadProductData(string productId, string productName, Image productImage, double productPrice,
                                    string productSize, string productDuration, string productCondition)
        {
            ProductName = productName;
            ProductImage = productImage;
            ProductDetails = $"Harga: Rp{productPrice:N0}\n" +
                             $"Ukuran: {productSize}\n" +
                             $"Durasi Pakai: {productDuration}\n" +
                             $"Kondisi: {productCondition}\n";
        }

        private void ProductCardSellerUserControl_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(128, 7, 79, 84);
            lblProductDetails.BackColor = Color.Transparent;
            lblProductName.BackColor = Color.Transparent;
        }
        public string ProductName
        {
            get => lblProductName.Text;
            set => lblProductName.Text = value;
        }

        public Image ProductImage
        {
            get => pictureBoxProduct.Image;
            set => pictureBoxProduct.Image = value;
        }

        public string ProductDetails
        {
            get => lblProductDetails.Text;
            set => lblProductDetails.Text = value;
        }
    }
}
