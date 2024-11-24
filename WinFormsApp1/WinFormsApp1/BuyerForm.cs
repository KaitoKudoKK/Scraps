using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class BuyerForm : Form
    {
        // Define CartUserControl for managing the cart UI
        public CartUserControl cartControl;

        public BuyerForm()
        {
            InitializeComponent();
            cartControl = cartUserControl1 as CartUserControl;

            cartControl.Hide();  // Awalnya sembunyikan kontrol cart
        }

        private void BuyerForm_Load(object sender, EventArgs e)
        {
            btnAccount.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnCart.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnHome.BackColor = Color.FromArgb(0, 0, 0, 0);


            // Initial font styling
            btnHome.Font = new Font(btnHome.Font.FontFamily, btnHome.Font.Size, btnHome.Font.Style | FontStyle.Bold);
            btnCart.Font = new Font(btnCart.Font.FontFamily, btnCart.Font.Size, FontStyle.Regular);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, FontStyle.Regular);

            cartControl.Hide();
            accountUserControl1.Hide();
            homeUserControl1.Show();
            homeUserControl1.BringToFront();
        }

        // Handle Home button click
        private void btnHome_Click(object sender, EventArgs e)
        {
            btnHome.Font = new Font(btnHome.Font.FontFamily, btnHome.Font.Size, btnHome.Font.Style | FontStyle.Bold);
            btnCart.Font = new Font(btnCart.Font.FontFamily, btnCart.Font.Size, FontStyle.Regular);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, FontStyle.Regular);

            cartControl.Hide();
            accountUserControl1.Hide();
            homeUserControl1.Show();
            homeUserControl1.BringToFront();
        }

        // Handle Cart button click (display CartUserControl)
        private void btnCart_Click(object sender, EventArgs e)
        {
            btnHome.Font = new Font(btnHome.Font.FontFamily, btnHome.Font.Size, FontStyle.Regular);
            btnCart.Font = new Font(btnCart.Font.FontFamily, btnCart.Font.Size, btnCart.Font.Style | FontStyle.Bold);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, FontStyle.Regular);

            homeUserControl1.Hide();
            accountUserControl1.Hide();
            cartControl.Show(); // Show the Cart User Control
            cartControl.BringToFront();
        }

        // Handle Account button click
        private void btnAccount_Click(object sender, EventArgs e)
        {
            btnHome.Font = new Font(btnHome.Font.FontFamily, btnHome.Font.Size, FontStyle.Regular);
            btnCart.Font = new Font(btnCart.Font.FontFamily, btnCart.Font.Size, FontStyle.Regular);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, btnAccount.Font.Style | FontStyle.Bold);

            homeUserControl1.Hide();
            cartUserControl1.Hide();
            accountUserControl1.Show();
            accountUserControl1.BringToFront();
        }

        private void BuyerForm_KeyDown(object sender, KeyEventArgs e)
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

        // Ensure the application closes when the form is closed
        private void BuyerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
