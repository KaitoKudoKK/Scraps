using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Npgsql;

namespace WinFormsApp1
{
    public partial class CartUserControl : UserControl
    {
        private static Dictionary<int, Image> imageCache = new Dictionary<int, Image>();

        private List<(string productName, double productPrice, Image productImage)> LoadCart(string buyerId)
        {
            var cartItems = new List<(string productName, double productPrice, Image productImage)>();

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=qwerty123;Database=scraps"))
                {
                    conn.Open();
                    var query = @"
                        SELECT P.ProductID, P.ProductName, P.ProductPrice, P.ProductImage
                        FROM Cart C
                        INNER JOIN Product P ON C.ProductID = P.ProductID
                        WHERE C.BuyerID = @BuyerID";

                    using (var command = new NpgsqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@BuyerID", buyerId);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var productId = reader["ProductID"].ToString();
                                var productName = reader["ProductName"].ToString();
                                var productPrice = Convert.ToDouble(reader["ProductPrice"]);

                                Image productImage = GetProductImageFromCache(productId);
                                if (productImage == null)
                                {
                                    byte[] imageBytes = reader["ProductImage"] as byte[];
                                    if (imageBytes != null)
                                    {
                                        using (var ms = new MemoryStream(imageBytes))
                                        {
                                            productImage = Image.FromStream(ms);
                                        }
                                        CacheProductImage(productId, productImage);
                                    }
                                }

                                cartItems.Add((productName, productPrice, productImage));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return cartItems;
        }

        private Image GetProductImageFromCache(string productId)
        {
            int id = int.Parse(productId);
            return imageCache.ContainsKey(id) ? imageCache[id] : null;
        }

        private void CacheProductImage(string productId, Image productImage)
        {
            int id = int.Parse(productId);
            if (!imageCache.ContainsKey(id))
            {
                imageCache.Add(id, productImage);
            }
        }

        public FlowLayoutPanel CartContainer { get; private set; }

        public CartUserControl()
        {
            InitializeComponent();
            CartContainer = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };
            this.Controls.Add(CartContainer);
        }

        public void AddProductToCart(string buyerId, string productId, string productName, Image productImage, double productPrice)
        {
            var productInCart = new ProductInCartUserControl();
            productInCart.LoadProduct(productName, productPrice, productImage);
            CartContainer.Controls.Add(productInCart);

            SaveToDatabase(buyerId, productId, productName, productPrice, productImage);
        }

        private void SaveToDatabase(string buyerId, string productId, string productName, double productPrice, Image productImage)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=qwerty123;Database=scraps"))
                {
                    conn.Open();

                    byte[] imageBytes = null;
                    if (productImage != null)
                    {
                        using (var ms = new MemoryStream())
                        {
                            productImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            imageBytes = ms.ToArray();
                        }
                    }

                    var query = @"
                        INSERT INTO Cart (BuyerID, ProductID, ProductName, ProductPrice, ProductImage)
                        VALUES (@BuyerID, @ProductID, @ProductName, @ProductPrice, @ProductImage)";

                    using (var command = new NpgsqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@BuyerID", buyerId);
                        command.Parameters.AddWithValue("@ProductID", productId);
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@ProductPrice", productPrice);
                        command.Parameters.AddWithValue("@ProductImage", imageBytes ?? (object)DBNull.Value);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while saving to database: {ex.Message}");
            }
        }
    }
}
