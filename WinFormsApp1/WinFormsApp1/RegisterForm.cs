using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class RegisterForm : Form
    {
        private NpgsqlConnection conn;
        private string connstring = ConfigurationManager.ConnectionStrings["AivenScrapsDB"].ConnectionString;
        private NpgsqlCommand cmd;
        private string sql = null;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new();
            loginForm.Show();
            this.Hide();
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

            // Cek apakah user mendaftar sebagai Buyer atau Seller
            if (rbBuyer.Checked)
            {
                // Simpan data sebagai Buyer ke database
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
                    MessageBox.Show("Registrasi sebagai Buyer berhasil!");
                    LoginForm loginForm = new();
                    loginForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat registrasi: " + ex.Message);
                }
            }
            else if (rbSeller.Checked)
            {
                // Simpan data sebagai Seller ke database
                try
                {
                    using (conn = new NpgsqlConnection(connstring))
                    {
                        conn.Open();
                        sql = "INSERT INTO seller (seller_username, seller_email, seller_password, seller_address, seller_phone) " +
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
                    MessageBox.Show("Registrasi sebagai Seller berhasil!");
                    LoginForm loginForm = new();
                    loginForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat registrasi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Pilih jenis pendaftaran: Buyer atau Seller");
            }
        }

        private void lblLogin_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl != null)
            {
                // Mengatur Font dengan underline saat kursor berada di atas label
                lbl.Font = new Font(lbl.Font, FontStyle.Bold);
            }
        }

        private void RegisterForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F11)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                    this.FormBorderStyle = FormBorderStyle.None;
                }
            }
        }

        private void lblLogin_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl != null)
            {
                // Mengatur Font dengan underline saat kursor berada di atas label
                lbl.Font = new Font(lbl.Font, FontStyle.Underline | FontStyle.Bold);
            }
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
               
        }
    }
}
