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
            completedBuyercs1.Hide();
            beingProcessedUserControl1.Show();
            beingProcessedUserControl1.BringToFront();
            button1.BackColor = Color.Teal; // Ganti dengan warna yang sesuai
            button1.ForeColor = Color.White;

            // Mengembalikan warna tombol Completed ke default
            button2.BackColor = SystemColors.Control; // Warna default
            button2.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            beingProcessedUserControl1.Hide();
            completedBuyercs1.Show();
            completedBuyercs1.BringToFront();
            button1.BackColor = Color.Teal; // Ganti dengan warna yang sesuai
            button1.ForeColor = Color.White;

            // Mengembalikan warna tombol Completed ke default
            button2.BackColor = SystemColors.Control; // Warna default
            button2.ForeColor = Color.Black;
        }

        private void TransactionHistoryBuyer_Load(object sender, EventArgs e)
        {

        }
    }
}
