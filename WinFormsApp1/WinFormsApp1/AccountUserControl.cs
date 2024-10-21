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

        private void AccountUserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnPlus2_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            // Membuat button berbentuk lingkaran
            buttonPath.AddEllipse(0, 0, btnPlus2.Width, btnPlus2.Height);
            btnPlus2.Region = new Region(buttonPath);
        }

        private void btnPlus1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            // Membuat button berbentuk lingkaran
            buttonPath.AddEllipse(0, 0, btnPlus1.Width, btnPlus1.Height);
            btnPlus1.Region = new Region(buttonPath);
        }
    }
}
