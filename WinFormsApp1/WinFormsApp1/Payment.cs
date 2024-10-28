using System;
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
        public DateTime PaymentDate { get; private set; }
        public string PaymentMethod { get; set; }
        public bool IsProcessed { get; private set; } = false;
        public bool IsRefunded { get; private set; } = false;

        private static List<Payment> paymentHistory = new List<Payment>();

        // Konstruktor
        public Payment(int paymentID, int orderID, float amount, string paymentMethod)
        {
            PaymentID = paymentID;
            OrderID = orderID;
            Amount = amount;
            PaymentMethod = paymentMethod;
        }

        // Method untuk memproses pembayaran
        public void ProcessPayment()
        {
            if (!IsProcessed)
            {
                PaymentDate = DateTime.Now;
                IsProcessed = true;
                paymentHistory.Add(this);
                Console.WriteLine($"Payment of {Amount:C} for Order {OrderID} processed on {PaymentDate} via {PaymentMethod}.");
            }
            else
            {
                Console.WriteLine("Payment has already been processed.");
            }
        }

        // Method untuk pengembalian dana
        public void RefundPayment()
        {
            if (IsProcessed && !IsRefunded)
            {
                IsRefunded = true;
                Console.WriteLine($"Payment of {Amount:C} for Order {OrderID} has been refunded.");
            }
            else if (IsRefunded)
            {
                Console.WriteLine("Payment has already been refunded.");
            }
            else
            {
                Console.WriteLine("Payment has not been processed, so it cannot be refunded.");
            }
        }

        // Static method untuk semua payment
        public static List<Payment> GetPaymentHistory()
        {
            return new List<Payment>(paymentHistory);
        }

        // Static method untuk menemukan payment berdasar paymentID
        public static Payment FindPayment(int paymentID)
        {
            return paymentHistory.Find(payment => payment.PaymentID == paymentID);
        }
    }
}
