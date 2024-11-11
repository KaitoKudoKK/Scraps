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
    public partial class AccountUserControl : UserControl
    {
        public AccountUserControl()
        {
            InitializeComponent();
        }
        public void LoadUserData(string name, string email, string phone, string address)
        {
            lblNama.Text = name;
            lblEmail.Text = email;
            lblNoHP.Text = phone;
            lblAlamat.Text = address;
        }
        private void AccountUserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnPlus2_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new();
            // Membuat button berbentuk lingkaran
            buttonPath.AddEllipse(0, 0, btnPlus2.Width, btnPlus2.Height);
            btnPlus2.Region = new Region(buttonPath);
        }

        

        private void btnPlus1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            // Buka LoginForm dan tutup BuyerForm
            LoginForm loginForm = new();
            loginForm.Show();
            this.Hide(); // Menyembunyikan form login setelah berhasil login
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditAkunUserControl editForm = new EditAkunUserControl(lblNama.Text, lblEmail.Text, lblNoHP.Text, lblAlamat.Text);
            editForm.UserDataUpdated += OnUserDataUpdated; // Subscribe event
            this.Parent.Controls.Add(editForm);
            this.Hide();
        }

        // Event handler untuk update data
        private void OnUserDataUpdated(object sender, UserDataEventArgs e)
        {
            LoadUserData(e.Name, e.Email, e.Phone, e.Address);
            this.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
