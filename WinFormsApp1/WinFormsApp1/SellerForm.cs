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
            AccountSellerUserControl accountSellerUserControl = new AccountSellerUserControl();
            this.Controls.Add(accountSellerUserControl);
            accountSellerUserControl.Dock = DockStyle.Fill;

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
            btnTransaction.Font = new Font(btnTransaction.Font.FontFamily, btnTransaction.Font.Size, FontStyle.Regular);

            // Pastikan seller ID tidak null
            if (LoginForm.currentSellerID == null)
            {
                MessageBox.Show("Error: ID penjual belum diinisialisasi. Pastikan Anda sudah login dengan benar.");
                return; // Keluar jika ID tidak valid
            }

            // Inisialisasi AddProductUserControl dengan validasi ID
            addProductUserControl1 = new AddProductUserControl(LoginForm.currentSellerID);
            if (addProductUserControl1 == null)
            {
                MessageBox.Show("Error: Kontrol AddProductUserControl tidak berhasil diinisialisasi.");
                return; // Keluar jika kontrol tidak diinisialisasi dengan benar
            }

            addProductUserControl1.Hide();
            chatSellerUserControl1.Hide();
            accountSellerUserControl1.Hide();
            transactionHistorySeller1.Hide();
            homeSellerUserControl1.Show();
            homeSellerUserControl1.BringToFront();
        }

        private void btnMyProduct_Click(object sender, EventArgs e)
        {
            // Change font style for selected button
            btnMyProduct.Font = new Font(btnMyProduct.Font.FontFamily, btnMyProduct.Font.Size, FontStyle.Bold);
            btnAdd.Font = new Font(btnAdd.Font.FontFamily, btnAdd.Font.Size, FontStyle.Regular);
            btnChat.Font = new Font(btnChat.Font.FontFamily, btnChat.Font.Size, FontStyle.Regular);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, FontStyle.Regular);
            btnTransaction.Font = new Font(btnTransaction.Font.FontFamily, btnTransaction.Font.Size, FontStyle.Regular);

            // Hide "Add Product" and other user controls, show home screen
            addProductUserControl1.Hide();
            chatSellerUserControl1.Hide();
            accountSellerUserControl1.Hide();
            transactionHistorySeller1.Hide();
            homeSellerUserControl1.Show();
            homeSellerUserControl1.BringToFront();
            homeSellerUserControl1.LoadProductsFromDatabase();
        }

        // Click event for "Add Product" button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Change font style for selected button
            btnMyProduct.Font = new Font(btnMyProduct.Font.FontFamily, btnMyProduct.Font.Size, FontStyle.Regular);
            btnAdd.Font = new Font(btnAdd.Font.FontFamily, btnAdd.Font.Size, FontStyle.Bold);
            btnChat.Font = new Font(btnChat.Font.FontFamily, btnChat.Font.Size, FontStyle.Regular);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, FontStyle.Regular);
            btnTransaction.Font = new Font(btnTransaction.Font.FontFamily, btnTransaction.Font.Size, FontStyle.Regular);

            // Hide home screen and other user controls, show "Add Product" user control
            homeSellerUserControl1.Hide();
            chatSellerUserControl1.Hide();
            accountSellerUserControl1.Hide();
            transactionHistorySeller1.Hide();
            addProductUserControl1.Show();
            addProductUserControl1.BringToFront();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            // Change font style for selected button
            btnMyProduct.Font = new Font(btnMyProduct.Font.FontFamily, btnMyProduct.Font.Size, FontStyle.Regular);
            btnAdd.Font = new Font(btnAdd.Font.FontFamily, btnAdd.Font.Size, FontStyle.Regular);
            btnChat.Font = new Font(btnChat.Font.FontFamily, btnChat.Font.Size, FontStyle.Regular);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, FontStyle.Bold);
            btnTransaction.Font = new Font(btnTransaction.Font.FontFamily, btnTransaction.Font.Size, FontStyle.Regular);

            // Hide home screen and other user controls, show "Add Product" user control
            homeSellerUserControl1.Hide();
            chatSellerUserControl1.Hide();
            addProductUserControl1.Hide();
            transactionHistorySeller1.Hide();
            accountSellerUserControl1.Show();
            accountSellerUserControl1.BringToFront();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            // Change font style for selected button
            btnMyProduct.Font = new Font(btnMyProduct.Font.FontFamily, btnMyProduct.Font.Size, FontStyle.Regular);
            btnAdd.Font = new Font(btnAdd.Font.FontFamily, btnAdd.Font.Size, FontStyle.Regular);
            btnChat.Font = new Font(btnChat.Font.FontFamily, btnChat.Font.Size, FontStyle.Bold);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, FontStyle.Regular);
            btnTransaction.Font = new Font(btnTransaction.Font.FontFamily, btnTransaction.Font.Size, FontStyle.Regular);

            // Hide home screen and other user controls, show "Add Product" user control
            homeSellerUserControl1.Hide();
            accountSellerUserControl1.Hide();
            addProductUserControl1.Hide();
            transactionHistorySeller1.Hide();
            chatSellerUserControl1.Show();
            chatSellerUserControl1.BringToFront();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            // Change font style for selected button
            btnMyProduct.Font = new Font(btnMyProduct.Font.FontFamily, btnMyProduct.Font.Size, FontStyle.Regular);
            btnAdd.Font = new Font(btnAdd.Font.FontFamily, btnAdd.Font.Size, FontStyle.Regular);
            btnChat.Font = new Font(btnChat.Font.FontFamily, btnChat.Font.Size, FontStyle.Regular);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, FontStyle.Regular);
            btnTransaction.Font = new Font(btnTransaction.Font.FontFamily, btnTransaction.Font.Size, FontStyle.Bold);

            // Hide home screen and other user controls, show "Add Product" user control
            homeSellerUserControl1.Hide();
            accountSellerUserControl1.Hide();
            addProductUserControl1.Hide();
            chatSellerUserControl1.Hide();
            transactionHistorySeller1.Show();
            transactionHistorySeller1.BringToFront();
        }

        private void SellerForm_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}