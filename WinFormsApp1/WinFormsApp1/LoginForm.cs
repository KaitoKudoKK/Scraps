using Npgsql;
using System;
using System.Configuration;
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
        private string connstring = ConfigurationManager.ConnectionStrings["AivenScrapsDB"].ConnectionString;
        public static string currentSellerID = ""; // Store the seller ID as a string, empty means no seller logged in.
        public static string currentBuyerID = ""; // Store the buyer ID as a string, empty means no buyer logged in.

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
            string sellerID = CheckUserRoleAndGetID(username, email, password, "seller");
            string buyerID = CheckUserRoleAndGetID(username, email, password, "buyer");

            if (!string.IsNullOrEmpty(sellerID))  // Login as seller
            {
                currentSellerID = sellerID; // Store the seller ID globally as a string
                MessageBox.Show("Login Berhasil sebagai Seller");
                SellerForm sellerForm = new SellerForm(); // Form untuk Seller
                sellerForm.Show();
                this.Hide();
            }
            else if (!string.IsNullOrEmpty(buyerID))  // Login as buyer
            {
                currentBuyerID = buyerID; // Store the buyer ID globally as a string
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

        // Modify this function to return the ID (either seller_id or buyer_id) as string
        private string CheckUserRoleAndGetID(string username, string email, string password, string role)
        {
            string userID = "";

            try
            {
                conn.Open();
                // Select either seller_id or buyer_id based on role
                string query = $"SELECT {role}id FROM {role} WHERE {role}_username = @username AND {role}_email = @email AND {role}_password = @password";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("password", password);

                    // Execute the query and retrieve the ID
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        userID = result.ToString();
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

            return userID; // Return the userID (seller_id or buyer_id) as a string
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
