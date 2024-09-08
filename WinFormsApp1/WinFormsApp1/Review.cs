using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Review
    {
        public int ReviewID { get; set; }
        public int ProductID { get; set; }
        public int BuyerID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }

        public void WriteReview() { }
        public void EditReview() { }
        public void DeleteReview() { }
    }
}
