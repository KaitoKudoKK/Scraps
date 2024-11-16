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
    public partial class BeingProcessedUserControl : UserControl
    {
        public BeingProcessedUserControl()
        {
            InitializeComponent();
        }

        private void BeingProcessedUserControl_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(128, 7, 79, 84);
            panel3.BackColor = Color.FromArgb(128, 7, 79, 84);
            panel5.BackColor = Color.FromArgb(128, 7, 79, 84);
        }
    }
}
