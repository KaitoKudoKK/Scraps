using System;

namespace scraps    
{
    // Kelas Product dengan Encapsulation
    public class Product
    {
        // Encapsulation dengan atribut private
        private int productID;
        private string name;
        private string description;
        private float price;
        private string category;
        private string condition;
        private string status;
        private int sellerID;

        // Konstruktor
        public Product(int productID, string name, string description, float price, string category, string condition, int sellerID)
        {
            this.productID = productID;
            this.name = name;
            this.description = description;
            this.price = price;
            this.category = category;
            this.condition = condition;
            this.status = "Available"; // Default status
            this.sellerID = sellerID;
        }

        // Getter dan Setter (Encapsulation)
        public int GetProductID() => productID;
        public string GetName() => name;
        public float GetPrice() => price;
        public string GetStatus() => status;

        // Method untuk menambah, mengupdate, dan menandai sebagai terjual
        public void AddProduct() => Console.WriteLine($"{name} added to the catalog.");
        public void UpdateProduct(string newName, string newDescription, float newPrice)
        {
            name = newName;
            description = newDescription;
            price = newPrice;
            Console.WriteLine($"{name} has been updated.");
        }

        public void MarkAsSold()
        {
            status = "Sold";
            Console.WriteLine($"{name} is now marked as sold.");
        }
         public void DeleteProduct()
        {
            status = "Deleted"; // Tandai produk sebagai "Deleted"
            Console.WriteLine($"{name} has been deleted from the catalog.");
        }
    }

    // Kelas dasar Review
    public class Review
    {
        protected int reviewID;
        protected int productID;
        protected int buyerID;
        protected int rating;
        protected string comment;
        protected DateTime reviewDate;

        // Konstruktor
        public Review(int reviewID, int productID, int buyerID, int rating, string comment)
        {
            this.reviewID = reviewID;
            this.productID = productID;
            this.buyerID = buyerID;
            this.rating = rating;
            this.comment = comment;
            this.reviewDate = DateTime.Now;
        }

        // Virtual method untuk di-override
        public virtual void WriteReview()
        {
            Console.WriteLine($"Review by Buyer {buyerID} for Product {productID}: {rating} stars - {comment}");
        }

        public void EditReview(int newRating, string newComment)
        {
            rating = newRating;
            comment = newComment;
            Console.WriteLine("Review updated.");
        }

        public void DeleteReview()
        {
            Console.WriteLine("Review deleted.");
        }
    }

    // Kelas turunan untuk review tipe teks
    public class TextReview : Review
    {
        public TextReview(int reviewID, int productID, int buyerID, int rating, string comment)
            : base(reviewID, productID, buyerID, rating, comment) { }

        public override void WriteReview()
        {
            Console.WriteLine($"[Text Review] Buyer {buyerID}: {rating} stars - {comment}");
        }
    }

    // Kelas turunan untuk review tipe gambar
    public class ImageReview : Review
    {
        private string imageURL;

        public ImageReview(int reviewID, int productID, int buyerID, int rating, string comment, string imageURL)
            : base(reviewID, productID, buyerID, rating, comment)
        {
            this.imageURL = imageURL;
        }

        public override void WriteReview()
        {
            Console.WriteLine($"[Image Review] Buyer {buyerID}: {rating} stars - {comment} [Image: {imageURL}]");
        }
    }

    // Kelas Order dengan Encapsulation dan Polymorphism
    public class Order
    {
        private int orderID;
        private int userID;
        private int productID;
        private float totalPrice;
        private DateTime orderDate;
        private string status;

        // Konstruktor
        public Order(int orderID, int userID, int productID, float totalPrice)
        {
            this.orderID = orderID;
            this.userID = userID;
            this.productID = productID;
            this.totalPrice = totalPrice;
            this.orderDate = DateTime.Now;
            this.status = "Pending";
        }

        // Getter dan Setter
        public int GetOrderID() => orderID;
        public string GetStatus() => status;

        // Virtual method untuk di-override di masa depan
        public virtual void CreateOrder()
        {
            Console.WriteLine($"Order {orderID} created for User {userID}, Product {productID}. Total: ${totalPrice}");
        }

        public virtual void UpdateStatus(string newStatus)
        {
            status = newStatus;
            Console.WriteLine($"Order {orderID} status updated to: {status}");
        }

        public virtual void CancelOrder()
        {
            status = "Cancelled";
            Console.WriteLine($"Order {orderID} has been cancelled.");
        }
    }

    