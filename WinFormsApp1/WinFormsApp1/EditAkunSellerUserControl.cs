using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class EditAkunSellerUserControl : UserControl
    {

        public string imageLocation;
        public event EventHandler<UserDataEventArgs> UserDataUpdated;

        public EditAkunSellerUserControl()
        {
            InitializeComponent();
        }

        public EditAkunSellerUserControl(string name, string email, string phone, string address, string imageLocation = "")
        {
            InitializeComponent();
            txtName.Text = name;
            txtEmail.Text = email;
            txtNoHP.Text = phone;
            txtAlamat.Text = address;
            this.imageLocation = imageLocation;
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            try
            {
                // Membuat dan mengatur OpenFileDialog
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
                dialog.Title = "Select an Image File";

                // Menampilkan dialog dan memeriksa apakah pengguna memilih file
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Mengambil lokasi file yang dipilih
                    String imageLocation = dialog.FileName;

                    // Menampilkan gambar pada PictureBox
                    image1.ImageLocation = imageLocation;
                }
            }
            catch (Exception ex)
            {
                // Menampilkan pesan error jika ada kesalahan
                MessageBox.Show("An Error Occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditAkunSellerUserControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pastikan image1 berisi jalur gambar yang valid
            var updatedEventArgs = new UserDataEventArgs(
                txtName.Text,
                txtEmail.Text,
                txtNoHP.Text,
                txtAlamat.Text,
                image1.ImageLocation // Pastikan ini memuat jalur terbaru
            );

            // Panggil event dengan data terbaru
            UserDataUpdated?.Invoke(this, updatedEventArgs);

            // Kembali ke AccountUserControl dan sembunyikan EditAkunUserControl
            var accountSellerUserControl = this.Parent.Controls["AccountUserControl"] as AccountUserControl;
            if (accountSellerUserControl != null)
            {
                accountSellerUserControl.Show();  // Menampilkan AccountUserControl lagi
            }

            this.Hide(); // Menyembunyikan EditAkunUserControl
        }
    }
}
