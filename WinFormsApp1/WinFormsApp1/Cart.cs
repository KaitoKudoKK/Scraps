using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Cart
    {
        public int CartID { get; set; }
        public int BuyerID { get; set; }
        public int ProductID { get; set; }

        public void AddToCart() { }
        public void RemoveFromCart() { }
        public void Pay() { }
    }
}
