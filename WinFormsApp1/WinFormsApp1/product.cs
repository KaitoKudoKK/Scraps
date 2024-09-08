using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public int SellerID { get; set; }

        public void AddProduct() { }
        public void UpdateProduct() { }
        public void DeleteProduct() { }
        public void MarkAsSold() { }
    }
}
