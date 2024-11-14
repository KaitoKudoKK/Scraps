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
        public static int currentSellerID = -1; // Global variable to store the current seller ID, -1 means no seller is logged in.

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

            // Check if the user is a buyer or a seller
            int sellerID = CheckUserRoleAndGetID(username, email, password, "seller");
            int buyerID = CheckUserRoleAndGetID(username, email, password, "buyer");

            if (sellerID > 0)  // Login as seller
            {
                currentSellerID = sellerID; // Store the seller ID globally
                MessageBox.Show("Login Berhasil sebagai Seller");
                SellerForm sellerForm = new SellerForm(); // Form untuk Seller
                sellerForm.Show();
                this.Hide();
            }
            else if (buyerID > 0)  // Login as buyer
            {
                MessageBox.Show("Login Berhasil sebagai Buyer");
                BuyerForm buyerForm = new BuyerForm(); // Form untuk Buyer
                buyerForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Gagal, periksa kembali username, email, dan password Anda.");
            }
        }

        // Modify this function to return the ID (either seller_id or buyer_id)
        private int CheckUserRoleAndGetID(string username, string email, string password, string role)
        {
            int userID = -1;

            try
            {
                conn.Open();
                string query = $"SELECT {role}_id FROM {role} WHERE {role}_username = @username AND {role}_email = @email AND {role}_password = @password";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("password", password);

                    // Execute the query and retrieve the ID
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        userID = Convert.ToInt32(result);
                    }
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

            return userID; // Return the userID (seller_id or buyer_id)
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
