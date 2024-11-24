using Npgsql;
using System.Configuration;

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
            productCardUserControl1.Hide();
        }

        private void LoadProductsFromDatabase()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["AivenScrapsDB"].ConnectionString))
            {
                try
                {

                    conn.Open();
                    string query = "SELECT p.productid, p.product_name, p.product_size, p.product_duration, p.product_condition, p.product_price, p.product_image, s.seller_username " +
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
                            double productPrice = reader.GetDouble(reader.GetOrdinal("product_price"));

                            byte[] imageBytes = reader.IsDBNull(reader.GetOrdinal("product_image")) ? null : (byte[])reader["product_image"];
                            Image productImage = imageBytes != null ? Image.FromStream(new System.IO.MemoryStream(imageBytes)) : null;

                            string sellerName = reader["seller_username"].ToString();

                            // Buat instance ProductCardUserControl
                            ProductCardUserControl productCard = new ProductCardUserControl();
                            productCard.LoadProductData(productId, productName, productImage, productPrice, productSize, productDuration, productCondition, sellerName);


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
    }
}
