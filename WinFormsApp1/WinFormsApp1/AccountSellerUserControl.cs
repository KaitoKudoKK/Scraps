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
    public partial class AccountSellerUserControl : UserControl
    {
        public AccountSellerUserControl()
        {
            InitializeComponent();
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

        private void OnUserDataUpdated(object sender, UserDataEventArgs e)
        {
            // Update data pada AccountUserControl
            LoadUserData(e.Name, e.Email, e.Phone, e.Address, e.ImageLocation);

            // Tampilkan kembali AccountUserControl setelah pembaruan
            this.Show();
        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            // Buka LoginForm dan tutup BuyerForm
            LoginForm loginForm = new();
            loginForm.Show();
            this.ParentForm.Hide();
        }

        private void AccountSellerUserControl_Load(object sender, EventArgs e)
        {

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
    }
}
