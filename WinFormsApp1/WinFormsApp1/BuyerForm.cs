using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class BuyerForm : Form
    {
        public BuyerForm()
        {
            InitializeComponent();
        }

        private void BuyerForm_Load(object sender, EventArgs e)
        {
            btnAccount.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnCart.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnChat.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnHome.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnHome.Font = new Font(btnHome.Font.FontFamily, btnHome.Font.Size, btnHome.Font.Style | FontStyle.Bold);
            btnCart.Font = new Font(btnCart.Font.FontFamily, btnCart.Font.Size, FontStyle.Regular);
            btnChat.Font = new Font(btnChat.Font.FontFamily, btnChat.Font.Size, FontStyle.Regular);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, FontStyle.Regular);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnHome.Font = new Font(btnHome.Font.FontFamily, btnHome.Font.Size, btnHome.Font.Style | FontStyle.Bold);
            btnCart.Font = new Font(btnCart.Font.FontFamily, btnCart.Font.Size, FontStyle.Regular);
            btnChat.Font = new Font(btnChat.Font.FontFamily, btnChat.Font.Size, FontStyle.Regular);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, FontStyle.Regular);
            cartUserControl1.Hide();
            chatUserControl1.Hide();
            accountUserControl1.Hide();
            homeUserControl1.Show();
            homeUserControl1.BringToFront();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            btnHome.Font = new Font(btnHome.Font.FontFamily, btnHome.Font.Size, FontStyle.Regular);
            btnCart.Font = new Font(btnCart.Font.FontFamily, btnCart.Font.Size, btnCart.Font.Style | FontStyle.Bold);
            btnChat.Font = new Font(btnChat.Font.FontFamily, btnChat.Font.Size, FontStyle.Regular);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, FontStyle.Regular);
            homeUserControl1.Hide();
            chatUserControl1.Hide();
            accountUserControl1.Hide();
            cartUserControl1.Show();
            cartUserControl1.BringToFront();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            btnHome.Font = new Font(btnHome.Font.FontFamily, btnHome.Font.Size, FontStyle.Regular);
            btnCart.Font = new Font(btnCart.Font.FontFamily, btnCart.Font.Size, FontStyle.Regular);
            btnChat.Font = new Font(btnChat.Font.FontFamily, btnChat.Font.Size, btnChat.Font.Style | FontStyle.Bold);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, FontStyle.Regular);
            homeUserControl1.Hide();
            cartUserControl1.Hide();
            accountUserControl1.Hide();
            chatUserControl1.Show();
            chatUserControl1.BringToFront();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            btnHome.Font = new Font(btnHome.Font.FontFamily, btnHome.Font.Size, FontStyle.Regular);
            btnCart.Font = new Font(btnCart.Font.FontFamily, btnCart.Font.Size, FontStyle.Regular);
            btnChat.Font = new Font(btnChat.Font.FontFamily, btnChat.Font.Size, FontStyle.Regular);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, btnAccount.Font.Style | FontStyle.Bold);
            homeUserControl1.Hide();
            cartUserControl1.Hide();
            chatUserControl1.Hide();
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

        private void BuyerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void homeUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnHome.Font = new Font(btnHome.Font.FontFamily, btnHome.Font.Size, FontStyle.Regular);
            btnCart.Font = new Font(btnCart.Font.FontFamily, btnCart.Font.Size, FontStyle.Regular);
            btnChat.Font = new Font(btnChat.Font.FontFamily, btnChat.Font.Size, FontStyle.Regular);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, btnAccount.Font.Style | FontStyle.Bold);
            btnTransaction.Font= new Font(btnTransaction.Font.FontFamily, btnTransaction.Font.Size, btnTransaction.Font.Style | FontStyle.Bold);
            homeUserControl1.Hide();
            cartUserControl1.Hide();
            chatUserControl1.Hide();
            accountUserControl1.Hide();

            TransactionHistoryBuyer1.BringToFront();
        }
    }
}
