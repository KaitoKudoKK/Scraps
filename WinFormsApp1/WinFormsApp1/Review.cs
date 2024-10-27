using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public  class Review
    {
        public int ReviewID { get; set; }
        public int ProductID { get; set; }
        public int BuyerID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }

         public Review(int reviewID, int productID, int buyerID, int rating, string comment)
        {
            this.ReviewID = reviewID;
            this.ProductID = productID;
            this.BuyerID = buyerID;
            this.Rating = rating;
            this.Comment = comment;
            this.ReviewDate = DateTime.Now;
        }

        // Virtual method untuk di-override
        public virtual void WriteReview()
        {
            Console.WriteLine($"Review by Buyer {BuyerID} for Product {ProductID}: {Rating} stars - {Comment}");
        }

        public void EditReview(int newRating, string newComment)
        {
            Rating = newRating;
            Comment = newComment;
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
            Console.WriteLine($"[Text Review] Buyer {BuyerID}: {Rating} stars - {Comment}");
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
            Console.WriteLine($"[Image Review] Buyer {BuyerID}: {Rating} stars - {Comment} [Image: {imageURL}]");
        }
    }

    }

