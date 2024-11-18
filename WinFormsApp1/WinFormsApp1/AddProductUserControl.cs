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
            this.sellerID = sellerID;  // Store the sellerID as a string
        }

        private void pbProductImage_Click(object sender, EventArgs e)
        {
            // Open the file dialog to select an image
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|.jpg;.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Display the selected image in the PictureBox
                string filePath = openFileDialog.FileName;
                pbProductImage.Image = Image.FromFile(filePath);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string namaProduk = tbNamaProduk.Text;
            string ukuran = tbUkuranProduk.Text;
            string durasiPakai = tbDurasiPakaiProduk.Text;
            string kondisi = tbKondisiProduk.Text;
            decimal harga;

            // Validate if all required fields are filled and price is valid
            if (string.IsNullOrWhiteSpace(namaProduk) || string.IsNullOrWhiteSpace(ukuran) ||
                string.IsNullOrWhiteSpace(durasiPakai) || string.IsNullOrWhiteSpace(kondisi) ||
                !decimal.TryParse(tbHargaProduk.Text, out harga))
            {
                MessageBox.Show("Please fill in all fields and enter a valid price.");
                return;
            }

            byte[] imageBytes = null;
            if (pbProductImage.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pbProductImage.Image.Save(ms, pbProductImage.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }
            }

            using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=qwerty123;Database=scraps"))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO product (product_name, product_size, product_duration, product_condition, product_price, product_image, sellerid) " +
                                   "VALUES (@namaProduk, @ukuran, @durasiPakai, @kondisi, @harga, @imageBytes, @sellerID)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("namaProduk", namaProduk);
                        cmd.Parameters.AddWithValue("ukuran", ukuran);
                        cmd.Parameters.AddWithValue("durasiPakai", durasiPakai);
                        cmd.Parameters.AddWithValue("kondisi", kondisi);
                        cmd.Parameters.AddWithValue("harga", harga);
                        cmd.Parameters.AddWithValue("imageBytes", imageBytes ?? (object)DBNull.Value); // If no image, save NULL
                        cmd.Parameters.AddWithValue("sellerID", sellerID);  // Use the sellerID from the logged-in user

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Product successfully added!");
                    ClearForm();  // Optional: Clear form after successful addition
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void AddProductUserControl_Load(object sender, EventArgs e)
        {
            // Set custom background color for textboxes
            tbNamaProduk.BackColor = Color.FromArgb(128, 7, 79, 84);
            tbUkuranProduk.BackColor = Color.FromArgb(128, 7, 79, 84);
            tbDurasiPakaiProduk.BackColor = Color.FromArgb(128, 7, 79, 84);
            tbKondisiProduk.BackColor = Color.FromArgb(128, 7, 79, 84);
            tbHargaProduk.BackColor = Color.FromArgb(128, 7, 79, 84);
        }

        private void ClearForm()
        {
            tbNamaProduk.Clear();
            tbUkuranProduk.Clear();
            tbDurasiPakaiProduk.Clear();
            tbKondisiProduk.Clear();
            tbHargaProduk.Clear();
            pbProductImage.Image = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Any custom painting logic can be added here if necessary
        }
    }
}
