using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Npgsql;

namespace WinFormsApp1
{
    public partial class AccountUserControl : UserControl
    {
        public AccountUserControl()
        {
            InitializeComponent();
        }

        private void AccountUserControl_Load(object sender, EventArgs e)
        {
            // Load data pengguna dari database
            if (!string.IsNullOrEmpty(LoginForm.currentBuyerID))
            {
                LoadUserDataFromDatabase(LoginForm.currentBuyerID);
            }
            else
            {
                MessageBox.Show("Buyer ID tidak ditemukan. Pastikan Anda login dengan benar.");
            }
        }

        private void LoadUserDataFromDatabase(string buyerId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AivenScrapsDB"].ConnectionString;
            string query = "SELECT buyer_username, buyer_email, buyer_phone, buyer_address, buyer_photo FROM buyer WHERE buyerid = @BuyerId";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BuyerId", buyerId);

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblNama.Text = reader["buyer_username"].ToString();
                                lblEmail.Text = reader["buyer_email"].ToString();
                                lblNoHP.Text = reader["buyer_phone"].ToString();
                                lblAlamat.Text = reader["buyer_address"].ToString();

                                byte[] photo = reader["buyer_photo"] as byte[];
                                if (photo != null && photo.Length > 0)
                                {
                                    using (MemoryStream ms = new MemoryStream(photo))
                                    {
                                        pictureBox1.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    pictureBox1.Image = null; // Kosongkan jika tidak ada gambar
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
                    MessageBox.Show("Terjadi kesalahan saat memuat data pengguna: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void LoadUserData(string name, string email, string phone, string address, string imageLocation = "")
        {
            lblNama.Text = name;
            lblEmail.Text = email;
            lblNoHP.Text = phone;
            lblAlamat.Text = address;

            if (!string.IsNullOrEmpty(imageLocation) && File.Exists(imageLocation))
            {
                pictureBox1.ImageLocation = imageLocation;
                pictureBox1.Load();
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            // Buka LoginForm dan tutup BuyerForm
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.ParentForm?.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Buka EditAkunUserControl
            EditAkunUserControl editForm = new EditAkunUserControl(lblNama.Text, lblEmail.Text, lblNoHP.Text, lblAlamat.Text, pictureBox1.ImageLocation);

            // Subscribe ke event untuk update data
            editForm.UserDataUpdated += OnUserDataUpdated;

            if (this.Parent != null)
            {
                this.Parent.Controls.Add(editForm);
                editForm.Dock = DockStyle.Fill;
                editForm.BringToFront();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Parent container tidak ditemukan.");
            }
        }

        private void OnUserDataUpdated(object sender, UserDataEventArgs e)
        {
            // Update data di AccountUserControl
            LoadUserData(e.Name, e.Email, e.Phone, e.Address, e.ImageLocation);

            // Tampilkan kembali AccountUserControl
            this.Show();
        }
    }
}
