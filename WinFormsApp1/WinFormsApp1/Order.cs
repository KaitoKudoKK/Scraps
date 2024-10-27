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

    
    public Order(int orderID, int buyerID, int productID, float totalPrice)
      
        {
            this.OrderID = orderID;
            this.BuyerID = BuyerID;
            this.ProductID = productID;
            this.TotalPrice = totalPrice;
            this.OrderDate = DateTime.Now;
            this.Status = "Pending";
        }

        // Getter dan Setter
        public int GetOrderID() => OrderID;
        public string GetStatus() => Status;

        // Virtual method untuk di-override di masa depan
        public virtual void CreateOrder()
        {
            Console.WriteLine($"Order {OrderID} created for User {BuyerID}, Product {ProductID}. Total: ${TotalPrice}");
        }

        public virtual void UpdateStatus(string newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"Order {OrderID} status updated to: {Status}");
        }

        public virtual void CancelOrder()
        {
            Status = "Cancelled";
            Console.WriteLine($"Order {OrderID} has been cancelled.");
        }
      }
}
