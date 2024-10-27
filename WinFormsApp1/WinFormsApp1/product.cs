using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public int SellerID { get; set; }

        // Constructor
        public Product(int productID, string name, string description, float price, string category, string status, int sellerID)
        {
            this.ProductID = productID;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Category = category;
            this.Status = status; // Gunakan parameter status atau tetapkan nilai default di sini
            this.SellerID = sellerID;
        }

        // Getter dan Setter (Encapsulation)
        public int GetProductID() => ProductID;
        public string GetName() => Name;
        public float GetPrice() => Price;
        public string GetStatus() => Status;

        // Method untuk menambah, mengupdate, menandai sebagai terjual, dan menghapus produk
        public void Addproduct() => Console.WriteLine($"{Name} added to the catalog.");
        
        public void UpdateProduct(string newName, string newDescription, float newPrice)
        {
            Name = newName;
            Description = newDescription;
            Price = newPrice;
            Console.WriteLine($"{Name} has been updated.");
        }

        public void MarkAsSold()
        {
            Status = "Sold";
            Console.WriteLine($"{Name} is now marked as sold.");
        }

        public void DeleteProduct()
        {
            Status = "Deleted"; // Tandai produk sebagai "Deleted"
            Console.WriteLine($"{Name} has been deleted from the catalog.");
        }
    }
}
