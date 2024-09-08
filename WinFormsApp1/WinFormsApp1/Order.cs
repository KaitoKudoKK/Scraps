using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Order
    {
        public int OrderID { get; set; }
        public int BuyerID { get; set; }
        public int ProductID { get; set; }
        public float TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }

        public void CreateOrder() { }
        public void UpdateStatus() { }
        public void CancelOrder() { }
    }
}
