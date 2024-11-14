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

            // Pass the seller ID to AddProductUserControl
            addProductUserControl1 = new AddProductUserControl(LoginForm.currentSellerID);
            addProductUserControl1.Hide();
            HomeSellerUserControl.Show();
            HomeSellerUserControl.BringToFront();
        }

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

        private void btnAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
