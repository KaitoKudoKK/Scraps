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
        public List<int> ProductIDs { get; private set; } = new List<int>();
        private static List<Cart> cartHistory = new List<Cart>();

        // Konstruktor
        public Cart(int cartID, int buyerID)
        {
            CartID = cartID;
            BuyerID = buyerID;
        }

        // Method untuk menambah produk ke Cart
        public void AddToCart(int productID)
        {
            if (!ProductIDs.Contains(productID))
            {
                ProductIDs.Add(productID);
                Console.WriteLine($"Product {productID} added to cart {CartID}.");
            }
            else
            {
                Console.WriteLine($"Product {productID} is already in the cart.");
            }
        }

        // Method untuk menghapus produk dari Cart
        public void RemoveFromCart(int productID)
        {
            if (ProductIDs.Contains(productID))
            {
                ProductIDs.Remove(productID);
                Console.WriteLine($"Product {productID} removed from cart {CartID}.");
            }
            else
            {
                Console.WriteLine($"Product {productID} is not in the cart.");
            }
        }

        // Method untuk memproses payment item yg ada di Cart
        public void Pay(float totalAmount, string paymentMethod)
        {
            if (ProductIDs.Count > 0)
            {
                var payment = new Payment(cartHistory.Count + 1, CartID, totalAmount, paymentMethod);
                payment.ProcessPayment();
                cartHistory.Add(this);
                
                // Mengosongkan Cart setelah dibayar
                ProductIDs.Clear();
                Console.WriteLine($"Cart {CartID} has been paid for by Buyer {BuyerID}.");
            }
            else
            {
                Console.WriteLine("Cart is empty. Add products before paying.");
            }
        }

        // Static method untuk retrieve riwayat Cart
        public static List<Cart> GetCartHistory()
        {
            return new List<Cart>(cartHistory);
        }
    }
}
