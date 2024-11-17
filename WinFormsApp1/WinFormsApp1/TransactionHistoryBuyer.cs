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
    public partial class TransactionHistoryBuyer : UserControl
    {
        public TransactionHistoryBuyer()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void completedBuyercs1_Load(object sender, EventArgs e)
        {

        }

        private void beingProcessedUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tampilkan UserControl terkait dan bawa ke depan
            completedBuyercs3.Hide();
            beingProcessedUserControl2.Show();
            beingProcessedUserControl2.BringToFront();

            // Ubah warna dan teks button1 (tombol aktif)
            button1.BackColor = Color.FromArgb(7, 79, 84); // Warna aktif
            button1.ForeColor = Color.White; // Teks tombol aktif

            // Kembalikan warna default button2 (tombol tidak aktif)
            button2.BackColor = SystemColors.Control; // Warna default
            button2.ForeColor = SystemColors.ControlText; // Teks default
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Tampilkan UserControl terkait dan bawa ke depan
            beingProcessedUserControl2.Hide();
            completedBuyercs3.Show();
            completedBuyercs3.BringToFront();

            // Ubah warna dan teks button2 (tombol aktif)
            button2.BackColor = Color.FromArgb(7, 79, 84); // Warna aktif
            button2.ForeColor = Color.White; // Teks tombol aktif

            // Kembalikan warna default button1 (tombol tidak aktif)
            button1.BackColor = SystemColors.Control; // Warna default
            button1.ForeColor = SystemColors.ControlText; // Teks default
        }


        private void TransactionHistoryBuyer_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }
    }
}
