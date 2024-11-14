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
    public partial class ChatSellerUserControl : UserControl
    {
        public ChatSellerUserControl()
        {
            InitializeComponent();
        }

        private void ChatSellerUserControl_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(128, 7, 79, 84);
            panel4.BackColor = Color.FromArgb(128, 7, 79, 84);
            panel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox2.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label6.BackColor = Color.FromArgb(0, 0, 0, 0);
            label7.BackColor = Color.FromArgb(0, 0, 0, 0);
            label11.BackColor = Color.FromArgb(0, 0, 0, 0);
            label12.BackColor = Color.FromArgb(0, 0, 0, 0);
            label13.BackColor = Color.FromArgb(0, 0, 0, 0);
        }
    }
}
