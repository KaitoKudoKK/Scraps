using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WinFormsApp1
{
    public partial class HomeUserControl : UserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();
        }

        private void HomeUserControl_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(128, 7, 79, 84);
            panel2.BackColor = Color.FromArgb(128, 7, 79, 84);
            panel3.BackColor = Color.FromArgb(128, 7, 79, 84);
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label6.BackColor = Color.FromArgb(0, 0, 0, 0);
            label7.BackColor = Color.FromArgb(0, 0, 0, 0);
            pbStar1.BackColor = Color.FromArgb(0, 0, 0, 0);
            pbStar2.BackColor = Color.FromArgb(0, 0, 0, 0);
            pbStar3.BackColor = Color.FromArgb(0, 0, 0, 0);
            pbStar4.BackColor = Color.FromArgb(0, 0, 0, 0);
            pbStar5.BackColor = Color.FromArgb(0, 0, 0, 0);
            pbStar6.BackColor = Color.FromArgb(0, 0, 0, 0);
            pbStar7.BackColor = Color.FromArgb(0, 0, 0, 0);
            pbStar8.BackColor = Color.FromArgb(0, 0, 0, 0);
            pbStar9.BackColor = Color.FromArgb(0, 0, 0, 0);
            pbStar10.BackColor = Color.FromArgb(0, 0, 0, 0);
            pbStar11.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void btnPlus1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            // Membuat button berbentuk lingkaran
            buttonPath.AddEllipse(0, 0, btnPlus1.Width, btnPlus1.Height);
            btnPlus1.Region = new Region(buttonPath);
        }

        private void btnPlus2_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            // Membuat button berbentuk lingkaran
            buttonPath.AddEllipse(0, 0, btnPlus2.Width, btnPlus2.Height);
            btnPlus2.Region = new Region(buttonPath);
        }

        private void btnPlus3_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            // Membuat button berbentuk lingkaran
            buttonPath.AddEllipse(0, 0, btnPlus3.Width, btnPlus3.Height);
            btnPlus3.Region = new Region(buttonPath);
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Barang ditambahkan ke cart!");
        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Barang ditambahkan ke cart!");
        }

        private void btnPlus3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Barang ditambahkan ke cart!");
        }
    }
}
