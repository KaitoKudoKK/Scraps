using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            int sellerID = LoginForm.currentSellerID; // Mengambil seller ID dari LoginForm

            if (sellerID != -1)
            {
                // Seller berhasil login, tampilkan produk yang terkait dengan sellerID
                MessageBox.Show("Seller ID: " + sellerID);
            }
            else
            {
                MessageBox.Show("Seller tidak terdaftar atau tidak login.");
                this.Close(); // Menutup form jika tidak ada seller yang login
            }

            // Set button colors to transparent
            btnAccount.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnAdd.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnChat.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnMyProduct.BackColor = Color.FromArgb(0, 0, 0, 0);

            // Set the initial font styles
            btnMyProduct.Font = new Font(btnMyProduct.Font.FontFamily, btnMyProduct.Font.Size, FontStyle.Bold);
            btnAdd.Font = new Font(btnAdd.Font.FontFamily, btnAdd.Font.Size, FontStyle.Regular);
            btnChat.Font = new Font(btnChat.Font.FontFamily, btnChat.Font.Size, FontStyle.Regular);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, FontStyle.Regular);

            // Initially hide Add Product user control and show Home screen
            addProductUserControl1.Hide();
            HomeSellerUserControl.Show();
            HomeSellerUserControl.BringToFront();
        }

        // Click event for "My Products" button
        private void btnMyProduct_Click(object sender, EventArgs e)
        {
            // Change font style for selected button
            btnMyProduct.Font = new Font(btnMyProduct.Font.FontFamily, btnMyProduct.Font.Size, FontStyle.Bold);
            btnAdd.Font = new Font(btnAdd.Font.FontFamily, btnAdd.Font.Size, FontStyle.Regular);
            btnChat.Font = new Font(btnChat.Font.FontFamily, btnChat.Font.Size, FontStyle.Regular);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, FontStyle.Regular);

            // Hide "Add Product" and other user controls, show home screen
            addProductUserControl1.Hide();
            HomeSellerUserControl.Show();
            HomeSellerUserControl.BringToFront();
        }

        // Click event for "Add Product" button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Change font style for selected button
            btnMyProduct.Font = new Font(btnMyProduct.Font.FontFamily, btnMyProduct.Font.Size, FontStyle.Regular);
            btnAdd.Font = new Font(btnAdd.Font.FontFamily, btnAdd.Font.Size, FontStyle.Bold);
            btnChat.Font = new Font(btnChat.Font.FontFamily, btnChat.Font.Size, FontStyle.Regular);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, FontStyle.Regular);

            // Hide home screen and other user controls, show "Add Product" user control
            HomeSellerUserControl.Hide();
            addProductUserControl1.Show();
            addProductUserControl1.BringToFront();
        }

        // Click event for "Chat" button (currently not implemented)
        private void btnChat_Click(object sender, EventArgs e)
        {
            // Change font style for selected button
            btnMyProduct.Font = new Font(btnMyProduct.Font.FontFamily, btnMyProduct.Font.Size, FontStyle.Regular);
            btnAdd.Font = new Font(btnAdd.Font.FontFamily, btnAdd.Font.Size, FontStyle.Regular);
            btnChat.Font = new Font(btnChat.Font.FontFamily, btnChat.Font.Size, FontStyle.Bold);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, FontStyle.Regular);

            // Hide "Add Product" and other user controls, show chat screen (you need to implement chatUserControl1)
            addProductUserControl1.Hide();
            HomeSellerUserControl.Hide();
            //chatUserControl1.Show();
            //chatUserControl1.BringToFront();
        }

        // Click event for "Account" button (currently not implemented)
        private void btnAccount_Click(object sender, EventArgs e)
        {
            // Change font style for selected button
            btnMyProduct.Font = new Font(btnMyProduct.Font.FontFamily, btnMyProduct.Font.Size, FontStyle.Regular);
            btnAdd.Font = new Font(btnAdd.Font.FontFamily, btnAdd.Font.Size, FontStyle.Regular);
            btnChat.Font = new Font(btnChat.Font.FontFamily, btnChat.Font.Size, FontStyle.Regular);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, FontStyle.Bold);

            // Hide other user controls, show account settings screen (you need to implement accountUserControl1)
            addProductUserControl1.Hide();
            HomeSellerUserControl.Hide();
            //accountUserControl1.Show();
            //accountUserControl1.BringToFront();
        }
    }
}
