﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Payment
    {
        public int PaymentID { get; set; }
        public int OrderID { get; set; }
        public float Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }

        public void ProcessPayment() { }
        public void RefundPayment() { }
    }
