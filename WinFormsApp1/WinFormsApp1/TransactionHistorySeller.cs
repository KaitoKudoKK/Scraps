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
    public partial class TransactionHistorySeller : UserControl
    {
        public TransactionHistorySeller()
        {
            InitializeComponent();
        }

        private void pesananSelesai1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pesananSelesai1.Hide();
            pesananMasuk1.Show();
            pesananMasuk1.BringToFront();
            button1.BackColor = Color.Teal; // Ganti dengan warna yang sesuai
            button1.ForeColor = Color.White;

            // Mengembalikan warna tombol Completed ke default
            button2.BackColor = SystemColors.Control; // Warna default
            button2.ForeColor = Color.Black;


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pesananMasuk1.Hide();
            pesananSelesai1.Show();
            pesananSelesai1.BringToFront();
            button1.BackColor = Color.Teal; // Ganti dengan warna yang sesuai
            button1.ForeColor = Color.White;

            // Mengembalikan warna tombol Completed ke default
            button2.BackColor = SystemColors.Control; // Warna default
            button2.ForeColor = Color.Black;
        }
    }
}
