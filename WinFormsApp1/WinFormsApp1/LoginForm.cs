using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        private string connstring = "Host=localhost;Port=5432;Username=postgres;Password=qwerty123;Database=scraps";
        private static NpgsqlCommand cmd;


        public class Buyer
        {
            public int BuyerID { get; set; }
            public string LoginUsername { get; set; }
            public string LoginEmail { get; set; }
            public string Password { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }

            public Buyer() { }

            public Buyer(string loginUsername, string loginEmail, string password)
            {
                LoginUsername = loginUsername;
                LoginEmail = loginEmail;
                Password = password;
            }

            public bool Login(string loginUsername, string loginEmail, string password, NpgsqlConnection connection)
            {
                try
                {
                    connection.Open();

                    // Query untuk memverifikasi pengguna di database
                    string query = "SELECT * FROM buyer WHERE buyer_username = @username AND buyer_email = @email AND buyer_password = @password";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        // Tambahkan parameter
                        cmd.Parameters.AddWithValue("username", loginUsername);
                        cmd.Parameters.AddWithValue("email", loginEmail);
                        cmd.Parameters.AddWithValue("password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Jika data ditemukan, ambil informasi tambahan pengguna dari database
                                BuyerID = reader.GetInt32(reader.GetOrdinal("buyerid"));
                                Address = reader.GetString(reader.GetOrdinal("address"));
                                PhoneNumber = reader.GetString(reader.GetOrdinal("phonenumber"));
                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return false;
            }

            public void InsertBuyerToDatabase(NpgsqlConnection connection)
            {
                try
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO buyer (buyer_username, buyer_email, buyer_password, buyer_address, buyer_phone) VALUES (@username, @email, @password, @address, @phone)";
                    using (var cmd = new NpgsqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("username", LoginUsername);
                        cmd.Parameters.AddWithValue("email", LoginEmail);
                        cmd.Parameters.AddWithValue("password", Password);
                        cmd.Parameters.AddWithValue("address", Address);
                        cmd.Parameters.AddWithValue("phone", PhoneNumber);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Buyer buyer = new(tbUsername.Text, tbEmail.Text, tbPassword.Text);

            if (buyer.Login(buyer.LoginUsername, buyer.LoginEmail, buyer.Password, conn))
            {
                MessageBox.Show("Login Berhasil");
                BuyerForm buyerForm = new();
                buyerForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Gagal, data akan disimpan ke database");

                // Set properti lainnya jika dibutuhkan
                buyer.Address = "Alamat Default";
                buyer.PhoneNumber = "08123456789";

                buyer.InsertBuyerToDatabase(conn); // Simpan data ke database
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
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
    }
}