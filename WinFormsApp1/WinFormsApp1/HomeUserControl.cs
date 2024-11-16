using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WinFormsApp1
{
    public partial class HomeUserControl : UserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();
            LoadProductsFromDatabase();
        }

        private void HomeUserControl_Load(object sender, EventArgs e)
        {
           
        }

        private void LoadProductsFromDatabase()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=lisha;Database=scraps"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT p.product_name, p.product_size, p.product_duration, p.product_condition, p.product_price, p.product_image, s.seller_name " +
                                   "FROM product p " +
                                   "JOIN seller s ON p.sellerid = s.sellerid";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string productName = reader["product_name"].ToString();
                            string productSize = reader["product_size"].ToString();
                            string productDuration = reader["product_duration"].ToString();
                            string productCondition = reader["product_condition"].ToString();
                            double productPrice = reader.GetDouble(reader.GetOrdinal("product_price"));

                            byte[] imageBytes = reader.IsDBNull(reader.GetOrdinal("product_image")) ? null : (byte[])reader["product_image"];
                            Image productImage = imageBytes != null ? Image.FromStream(new System.IO.MemoryStream(imageBytes)) : null;

                            string sellerName = reader["seller_name"].ToString();

                            // Buat instance ProductCardUserControl
                            ProductCardUserControl productCard = new ProductCardUserControl();
                            productCard.LoadProductData(productName, productImage, (decimal)productPrice, productSize, productDuration, productCondition, sellerName);

                            // Tambahkan ke layout panel atau container lain di form
                            flowLayoutPanelProducts.Controls.Add(productCard); // Pastikan flowLayoutPanelProducts ada di form
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Barang ditambahkan ke cart!");
        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Barang ditambahkan ke cart!");
        }

        private void btnPlus3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Barang ditambahkan ke cart!");
        }
    }
}
