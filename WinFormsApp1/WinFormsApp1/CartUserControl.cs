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
    public partial class CartUserControl : UserControl
    {
        // Contoh data harga produk
        private decimal[] productPrices = { 170000m, 750000m }; // Harga produk
        private NumericUpDown[] quantityControls; // Array untuk menyimpan kontrol kuantitas

        public CartUserControl()
        {
            InitializeComponent();

            // Menginisialisasi kontrol kuantitas untuk menghitung subtotal secara dinamis
            quantityControls = new NumericUpDown[] { numericUpDown1, numericUpDown2 };
            foreach (var control in quantityControls)
            {
                control.ValueChanged += numericUpDown1_ValueChanged; // Menambahkan event handler
            }

            UpdateTotals(); // Mengupdate total pada awalnya
        }


        private void CartUserControl_Load(object sender, EventArgs e)
        {

        }
        private void UpdateTotals()
        {
            decimal subtotal = 0;

            // Menghitung subtotal berdasarkan kuantitas dan harga produk
            for (int i = 0; i < productPrices.Length; i++)
            {
                subtotal += productPrices[i] * quantityControls[i].Value;
            }

            // Menampilkan subtotal
            lblSubtotal.Text = "Rp" + subtotal.ToString("N0");

            // Menampilkan total (misalnya, termasuk biaya pengiriman jika ada)
            decimal biayaPengiriman = 0; // Ubah sesuai kebutuhan jika ada biaya
            lblTotal.Text = "Rp" + (subtotal + biayaPengiriman).ToString("N0");
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotals(); // Mengupdate total setiap kali nilai kuantitas diubah
        }

        private void lblSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
