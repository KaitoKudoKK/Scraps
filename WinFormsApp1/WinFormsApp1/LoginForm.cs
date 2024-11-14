using Npgsql;
using System;
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
        private string connstring = "Host=localhost;Port=5432;Username=postgres;Password=lisha;Database=scraps";

        private void LoginForm_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Mohon isi semua kolom login.");
                return;
            }

            bool isBuyer = CheckUserRole(username, email, password, "buyer");
            bool isSeller = CheckUserRole(username, email, password, "seller");

            if (isBuyer)
            {
                MessageBox.Show("Login Berhasil sebagai Buyer");
                BuyerForm buyerForm = new BuyerForm(); // Form untuk Buyer
                buyerForm.Show();
                this.Hide();
            }
            else if (isSeller)
            {
                MessageBox.Show("Login Berhasil sebagai Seller");
                SellerForm sellerForm = new SellerForm(); // Form untuk Seller
                sellerForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Gagal, periksa kembali username, email, dan password Anda.");
            }
        }

        private bool CheckUserRole(string username, string email, string password, string role)
        {
            bool userExists = false;

            try
            {
                conn.Open();
                string query = $"SELECT COUNT(*) FROM {role} WHERE {role}_username = @username AND {role}_email = @email AND {role}_password = @password";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("password", password);

                    userExists = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return userExists;
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
