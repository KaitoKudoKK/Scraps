using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Category
    {
           
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        // List static untuk memantau tiap kategori
        private static List<Category> categories = new List<Category>();

        // Konstruktor
        public Category(int categoryID, string categoryName)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
        }

        // Method untuk menambah kategori baru
        public void AddCategory()
        {
            if (!categories.Exists(c => c.CategoryID == this.CategoryID))
            {
                categories.Add(this);
                Console.WriteLine($"Category '{CategoryName}' added successfully.");
            }
            else
            {
                Console.WriteLine("A category with this ID already exists.");
            }
        }

        // Method untuk update nama kategori yang ada
        public void UpdateCategory(string newCategoryName)
        {
            var category = categories.Find(c => c.CategoryID == this.CategoryID);
            if (category != null)
            {
                category.CategoryName = newCategoryName;
                Console.WriteLine($"Category ID {CategoryID} updated to '{newCategoryName}'.");
            }
            else
            {
                Console.WriteLine("Category not found for update.");
            }
        }

        // Method untuk menghapus kategori
        public void DeleteCategory()
        {
            var category = categories.Find(c => c.CategoryID == this.CategoryID);
            if (category != null)
            {
                categories.Remove(category);
                Console.WriteLine($"Category '{CategoryName}' deleted successfully.");
            }
            else
            {
                Console.WriteLine("Category not found for deletion.");
            }
        }

        // Static method untuk retrieve semua kategori
        public static List<Category> GetAllCategories()
        {
            return new List<Category>(categories);
        }
    }
}
