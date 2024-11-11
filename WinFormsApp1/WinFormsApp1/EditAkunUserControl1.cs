using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class EditAkunUserControl : UserControl
    {
        public event EventHandler<UserDataEventArgs> UserDataUpdated;

        public EditAkunUserControl(string name, string email, string phone, string address)
        {
            InitializeComponent();
            txtName.Text = name;
            txtEmail.Text = email;
            txtNoHP.Text = phone;
            txtAlamat.Text = address;
        }

        private void AkunuserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnChat_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserDataUpdated?.Invoke(this, new UserDataEventArgs(
           txtName.Text,
           txtEmail.Text,
           txtNoHP.Text,
           txtAlamat.Text
             ));

            // Kembali ke AccountUserControl
            this.Parent.Controls.Remove(this);
        }
    }
}
