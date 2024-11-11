using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WinFormsApp1
{
    public partial class register : Form
    {


        private NpgsqlConnection conn;
        private string connstring = "Host=localhost;Port=5432;Username=postgres;Password=lisha;Database=scraps";
        private NpgsqlCommand cmd;
        private string sql = null;

        public register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Ambil data dari TextBox
            string username = tbUsername.Text;
            string email = tbEmail.Text;
            string password = tbPassword.Text;
            string address = tbAddress.Text;
            string phone = tbPhone.Text;

            // Validasi sederhana untuk memastikan semua kolom diisi
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Semua kolom harus diisi");
                return;
            }

            // Simpan data ke database
            try
            {
                using (conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    sql = "INSERT INTO buyer (buyer_username, buyer_email, buyer_password, buyer_address, buyer_phone) " +
                          "VALUES (@username, @email, @password, @address, @phone)";
                    using (cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("password", password); // sebaiknya terenkripsi di sistem produksi
                        cmd.Parameters.AddWithValue("address", address);
                        cmd.Parameters.AddWithValue("phone", phone);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Registrasi berhasil!");
                LoginForm loginForm = new();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat registrasi: " + ex.Message);
            }
        }
    }
}
