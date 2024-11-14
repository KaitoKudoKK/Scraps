using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            btnAccount.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnAdd.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnChat.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnMyProduct.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnMyProduct.Font = new Font(btnMyProduct.Font.FontFamily, btnMyProduct.Font.Size, btnMyProduct.Font.Style | FontStyle.Bold);
            btnAdd.Font = new Font(btnAdd.Font.FontFamily, btnAdd.Font.Size, FontStyle.Regular);
            btnChat.Font = new Font(btnChat.Font.FontFamily, btnChat.Font.Size, FontStyle.Regular);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, FontStyle.Regular);
            addProductUserControl1.Hide();
            HomeSellerUserControl.Show();
            HomeSellerUserControl.BringToFront();
        }

        private void btnMyProduct_Click(object sender, EventArgs e)
        {
            btnMyProduct.Font = new Font(btnMyProduct.Font.FontFamily, btnMyProduct.Font.Size, btnMyProduct.Font.Style | FontStyle.Bold);
            btnAdd.Font = new Font(btnAdd.Font.FontFamily, btnAdd.Font.Size, FontStyle.Regular);
            btnChat.Font = new Font(btnChat.Font.FontFamily, btnChat.Font.Size, FontStyle.Regular);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, FontStyle.Regular);
            addProductUserControl1.Hide();
            //chatUserControl1.Hide();
            //accountUserControl1.Hide();
            HomeSellerUserControl.Show();
            HomeSellerUserControl.BringToFront();
        }

        private void homeSellerUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnMyProduct.Font = new Font(btnChat.Font.FontFamily, btnChat.Font.Size, FontStyle.Regular);
            btnAdd.Font = new Font(btnMyProduct.Font.FontFamily, btnMyProduct.Font.Size, btnMyProduct.Font.Style | FontStyle.Bold);
            btnChat.Font = new Font(btnChat.Font.FontFamily, btnChat.Font.Size, FontStyle.Regular);
            btnAccount.Font = new Font(btnAccount.Font.FontFamily, btnAccount.Font.Size, FontStyle.Regular);
            HomeSellerUserControl.Hide();
            //chatUserControl1.Hide();
            //accountUserControl1.Hide();
            addProductUserControl1.Show();
            addProductUserControl1.BringToFront();
        }
    }
}
