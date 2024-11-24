using System;
using System.Data;
using Npgsql;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

namespace WinFormsApp1
{
    public partial class AccountSellerUserControl : UserControl
    {
        public AccountSellerUserControl()
        {
            InitializeComponent();
        }

        private void AccountSellerUserControl_Load(object sender, EventArgs e)
        {
            // Gunakan currentSellerID dari LoginForm untuk memuat data pengguna
            if (!string.IsNullOrEmpty(LoginForm.currentSellerID))
            {
                LoadUserData(LoginForm.currentSellerID);
            }
            else
            {
                MessageBox.Show("Seller ID tidak ditemukan. Pastikan Anda login dengan benar.");
            }
        }

        public void LoadUserData(string sellerId)
        {
            // Koneksi ke database dan memuat data pengguna
            string connectionString = ConfigurationManager.ConnectionStrings["AivenScrapsDB"].ConnectionString;
            string query = "SELECT seller_username, seller_email, seller_phone, seller_address, seller_photo FROM seller WHERE sellerid = @SellerId";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SellerId", sellerId);

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblNama.Text = reader["seller_username"].ToString();
                                lblEmail.Text = reader["seller_email"].ToString();
                                lblNoHP.Text = reader["seller_phone"].ToString();
                                lblAlamat.Text = reader["seller_address"].ToString();

                                byte[] photo = reader["seller_photo"] as byte[];
                                if (photo != null && photo.Length > 0)
                                {
                                    using (MemoryStream ms = new MemoryStream(photo))
                                    {
                                        pictureBox1.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    pictureBox1.Image = null;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Data pengguna tidak ditemukan.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan saat memuat data pengguna: {ex.Message}");
                }
            }
        }

        private void OnUserDataUpdated(object sender, UserDataEventArgs e)
        {
            // Update data pada AccountUserControl
            LoadUserData(e.Name, e.Email, e.Phone, e.Address, e.ImageLocation);

            // Tampilkan kembali AccountUserControl setelah pembaruan
            this.Show();
        }

        public void LoadUserData(string name, string email, string phone, string address, string imageLocation = "")
        {
            lblNama.Text = name;
            lblEmail.Text = email;
            lblNoHP.Text = phone;
            lblAlamat.Text = address;

            if (!string.IsNullOrEmpty(imageLocation) && System.IO.File.Exists(imageLocation))
            {
                pictureBox1.ImageLocation = imageLocation;
                pictureBox1.Load(); // Muat ulang gambar secara eksplisit
            }
            else
            {
                pictureBox1.Image = null; // Kosongkan jika tidak ada jalur yang valid
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            EditAkunSellerUserControl editForm = new EditAkunSellerUserControl(lblNama.Text, lblEmail.Text, lblNoHP.Text, lblAlamat.Text, pictureBox1.ImageLocation);

            // Subscribe ke event untuk mendapatkan data terbaru
            editForm.UserDataUpdated += OnUserDataUpdated;

            // Tambahkan EditAkunUserControl ke container
            if (this.Parent != null)
            {
                this.Parent.Controls.Add(editForm);
                editForm.Dock = DockStyle.Fill;  // Memastikan editForm mengisi area container
                editForm.BringToFront();         // Pastikan editForm terlihat di depan
                this.Hide();                     // Menyembunyikan AccountUserControl
            }
            else
            {
                MessageBox.Show("Parent container tidak ditemukan.");
            }
        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            // Buka LoginForm dan tutup BuyerForm
            LoginForm loginForm = new();
            loginForm.Show();
            if (ParentForm != null)
            {
                this.ParentForm.Hide();
            }
        }

        private void lblNama_Click(object sender, EventArgs e)
        {

        }
    }
}
