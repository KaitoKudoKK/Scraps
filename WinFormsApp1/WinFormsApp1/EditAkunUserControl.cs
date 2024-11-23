using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Npgsql;

namespace WinFormsApp1
{
    public partial class EditAkunUserControl : UserControl
    {
        public string imageLocation;
        public event EventHandler<UserDataEventArgs> UserDataUpdated;

        public EditAkunUserControl(string name, string email, string phone, string address, string imageLocation = "")
        {
            InitializeComponent();
            txtName.Text = name;
            txtEmail.Text = email;
            txtNoHP.Text = phone;
            txtAlamat.Text = address;
            this.imageLocation = imageLocation;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Simpan data ke database
            SaveUserData();

            // Buat event untuk memperbarui kontrol lain
            var updatedEventArgs = new UserDataEventArgs(
                txtName.Text,
                txtEmail.Text,
                txtNoHP.Text,
                txtAlamat.Text,
                image1.ImageLocation
            );

            UserDataUpdated?.Invoke(this, updatedEventArgs);

            // Kembali ke AccountUserControl
            var accountUserControl = this.Parent.Controls.OfType<AccountUserControl>().FirstOrDefault();
            if (accountUserControl != null)
            {
                accountUserControl.Show();
            }

            this.Hide();
        }

        private void SaveUserData()
        {
            // Periksa apakah ID pengguna yang sedang login tersedia
            if (string.IsNullOrEmpty(LoginForm.currentBuyerID))
            {
                MessageBox.Show("Buyer ID tidak ditemukan. Login ulang untuk melanjutkan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Koneksi ke database
            string connectionString = ConfigurationManager.ConnectionStrings["AivenScrapsDB"].ConnectionString;
            string query = "UPDATE buyer SET buyer_username = @Name, buyer_email = @Email, buyer_phone = @Phone, buyer_address = @Address, buyer_photo = @Photo WHERE buyerid = @BuyerId";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", txtName.Text);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@Phone", txtNoHP.Text);
                        command.Parameters.AddWithValue("@Address", txtAlamat.Text);

                        // Konversi gambar menjadi byte array
                        byte[] photo = null;
                        if (!string.IsNullOrEmpty(image1.ImageLocation))
                        {
                            photo = File.ReadAllBytes(image1.ImageLocation);
                        }
                        else
                        {
                            photo = new byte[0]; // Jika tidak ada gambar
                        }

                        command.Parameters.AddWithValue("@Photo", photo);
                        command.Parameters.AddWithValue("@BuyerId", LoginForm.currentBuyerID);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil diperbarui.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnChat_Click_3(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*",
                    Title = "Select an Image File"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    image1.ImageLocation = imageLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
