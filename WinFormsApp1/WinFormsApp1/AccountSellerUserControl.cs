﻿using System;
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
    public partial class AccountSellerUserControl : UserControl
    {
        public AccountSellerUserControl()
        {
            InitializeComponent();
        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new();
            loginForm.Show();
            this.ParentForm.Hide();
        }
    }
}
