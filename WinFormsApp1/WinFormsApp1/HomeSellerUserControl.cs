using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class HomeSellerUserControl : UserControl
    {
        public HomeSellerUserControl()
        {
            InitializeComponent();
            
        }

        private void HomeSellerUserControl_Load(object sender, EventArgs e)
        {
            LoadProductsFromDatabase();
        }

        public void LoadProductsFromDatabase()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["AivenScrapsDB"].ConnectionString))
            {
                try
                {
                    productCardUserControl1.Hide();
                    flowLayoutPanelProducts.Controls.Clear(); // Bersihkan kontrol sebelumnya

                    conn.Open();
                    string query = "SELECT p.productid, p.product_name, p.product_size, p.product_duration, " +
                                   "p.product_condition, p.product_price, p.product_image " +
                                   "FROM product p " +
                                   "JOIN seller s ON p.sellerid = s.sellerid";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string productId = reader["productid"].ToString();
                            string productName = reader["product_name"].ToString();
                            string productSize = reader["product_size"].ToString();
                            string productDuration = reader["product_duration"].ToString();
                            string productCondition = reader["product_condition"].ToString();
                            double productPrice = reader.IsDBNull(reader.GetOrdinal("product_price")) ? 0.0 : reader.GetDouble(reader.GetOrdinal("product_price"));

                            byte[] imageBytes = reader.IsDBNull(reader.GetOrdinal("product_image")) ? null : (byte[])reader["product_image"];
                            Image productImage = null;
                            if (imageBytes != null)
                            {
                                using (var ms = new System.IO.MemoryStream(imageBytes))
                                {
                                    productImage = Image.FromStream(ms);
                                }
                            }

                            // Buat instance ProductCardUserControl
                            ProductCardSellerUserControl productCard = new ProductCardSellerUserControl();
                            productCard.LoadProductData(productId, productName, productImage, productPrice, productSize, productDuration, productCondition);

                            // Tambahkan ke layout panel atau container lain di form
                            flowLayoutPanelProducts.Controls.Add(productCard);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in LoadProductsFromDatabase: {ex.Message}");
                }
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
