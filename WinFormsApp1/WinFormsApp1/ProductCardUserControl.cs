using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ProductCardUserControl : UserControl
    {
        // Reference ke CartUserControl untuk menambahkan produk ke keranjang
        public CartUserControl CartControlPC { get ; set; }

        public ProductCardUserControl()
        {
            InitializeComponent();
        }

        // Memuat data produk ke dalam user control
        public void LoadProductData(string productId, string productName, Image productImage, double productPrice,
                                    string productSize, string productDuration, string productCondition, string sellerName)
        {
            ProductId = productId;
            ProductNamePC = productName;
            ProductImage = productImage;
            ProductPrice = productPrice;
            ProductDetails = $"Harga: Rp{productPrice:N0}\n" +
                             $"Ukuran: {productSize}\n" +
                             $"Durasi Pakai: {productDuration}\n" +
                             $"Kondisi: {productCondition}\n" +
                             $"Penjual: {sellerName}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CartControlPC != null)
            {
                // Menambahkan produk ke keranjang
                CartControlPC.AddProductToCart(LoginForm.currentBuyerID, ProductId, ProductName, ProductImage, ProductPrice);
                MessageBox.Show($"{ProductName} berhasil ditambahkan ke keranjang!");
            }
            else
            {
                MessageBox.Show("Keranjang belum diatur!");
            }
        }

        private void btnAdd_Paint(object sender, PaintEventArgs e)
        {
            var buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            buttonPath.AddEllipse(0, 0, btnAdd.Width, btnAdd.Height);
            btnAdd.Region = new Region(buttonPath);
        }

        private void ProductCardUserControl_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(128, 7, 79, 84);
            lblProductDetails.BackColor = Color.Transparent;
            lblProductName.BackColor = Color.Transparent;
        }

        public string ProductId { get; set; }

        public string ProductNamePC
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

        public double ProductPrice { get; set; }
    }
}
