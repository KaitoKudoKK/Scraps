using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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

        private void AkunuserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnChat_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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
            var accountUserControl = this.Parent.Controls["AccountUserControl"] as AccountUserControl;
            if (accountUserControl != null)
            {
                accountUserControl.Show();  // Menampilkan AccountUserControl lagi
            }

            this.Hide(); // Menyembunyikan EditAkunUserControl
        }


        private void btnChat_Click_3(object sender, EventArgs e)
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

