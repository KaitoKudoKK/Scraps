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
            using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=qwerty123;Database=scraps"))
            {
                conn.Open();
                string query = "INSERT INTO products (product_name, ukuran, durasi_pakai, kondisi, harga, image_data) " +
                               "VALUES (@product_name, @ukuran, @durasi_pakai, @kondisi, @harga, @image_data)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    // Menambahkan parameter untuk mencegah SQL Injection
                    cmd.Parameters.AddWithValue("product_name", namaProduk);
                    cmd.Parameters.AddWithValue("ukuran", ukuran);
                    cmd.Parameters.AddWithValue("durasi_pakai", durasiPakai);
                    cmd.Parameters.AddWithValue("kondisi", kondisi);
                    cmd.Parameters.AddWithValue("harga", harga);
                    cmd.Parameters.AddWithValue("image_data", imageBytes ?? (object)DBNull.Value); // Jika gambar tidak ada, simpan NULL

                    cmd.ExecuteNonQuery(); // Eksekusi perintah SQL untuk memasukkan data
                }
                MessageBox.Show("Product successfully added!");
            }
        }
    }
}
