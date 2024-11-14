using Npgsql;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddProductUserControl : UserControl
    {
        private string sellerID;

        // Constructor with sellerID parameter
        public AddProductUserControl(string sellerID)
        {
            InitializeComponent();
            this.sellerID = sellerID;  // Store the sellerID
        }

        // This event is triggered when the PictureBox is clicked to select an image
        private void pbProductImage_Click(object sender, EventArgs e)
        {
            // Open the file dialog to select an image
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Display the selected image in the PictureBox
                string filePath = openFileDialog.FileName;
                pbProductImage.Image = Image.FromFile(filePath);
            }
        }

        // This event is triggered when the "Add Product" button is clicked
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Retrieve the product information from the textboxes
            string namaProduk = tbNamaProduk.Text;
            string ukuran = tbUkuranProduk.Text;
            string durasiPakai = tbDurasiPakaiProduk.Text;
            string kondisi = tbKondisiProduk.Text;
            decimal harga = Convert.ToDecimal(tbHargaProduk.Text);

            // Convert the image in PictureBox to a byte array
            byte[] imageBytes = null;
            if (pbProductImage.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pbProductImage.Image.Save(ms, pbProductImage.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }
            }

            // Save the product details to the database
            using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=lisha;Database=scraps"))
            {
                conn.Open();
                string query = "INSERT INTO product (product_name, product_size, product_duration, product_condition, product_price, product_image, sellerid) " +
                               "VALUES (@namaProduk, @ukuran, @durasiPakai, @kondisi, @harga, @imageBytes,)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    // Menambahkan parameter untuk mencegah SQL Injection
                    cmd.Parameters.AddWithValue("namaProduk", namaProduk);
                    cmd.Parameters.AddWithValue("ukuran", ukuran);
                    cmd.Parameters.AddWithValue("durasiPakai", durasiPakai);
                    cmd.Parameters.AddWithValue("kondisi", kondisi);
                    cmd.Parameters.AddWithValue("harga", harga);
                    cmd.Parameters.AddWithValue("imageBytes", imageBytes ?? (object)DBNull.Value); // Jika gambar tidak ada, simpan NULL

                        // Execute the query to insert the product data into the database
                        cmd.ExecuteNonQuery();
                    }

                    // Notify the user that the product was successfully added
                    MessageBox.Show("Product successfully added!");
                }
                catch (Exception ex)
                {
                    // If an error occurs, display an error message
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
