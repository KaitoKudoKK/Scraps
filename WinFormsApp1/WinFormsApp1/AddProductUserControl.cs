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

namespace WinFormsApp1
{
    public partial class AddProductUserControl : UserControl
    {
        public AddProductUserControl()
        {
            InitializeComponent();
        }

        private void pbProductImage_Click(object sender, EventArgs e)
        {
            // Membuka dialog untuk memilih gambar
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Menampilkan gambar yang dipilih di PictureBox
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
            decimal harga = Convert.ToDecimal(tbHargaProduk.Text);
            string sellerID = 

            // Convert image in PictureBox to byte array
            byte[] imageBytes = null;
            if (pbProductImage.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pbProductImage.Image.Save(ms, pbProductImage.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }
            }

            // Save data to the database
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

                    cmd.ExecuteNonQuery(); // Eksekusi perintah SQL untuk memasukkan data
                }
                MessageBox.Show("Product successfully added!");
            }
        }
    }
}
