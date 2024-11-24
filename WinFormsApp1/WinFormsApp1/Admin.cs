using System;

namespace WinFormsApp1
{
    internal class Admin : User
    {
        public Admin(int adminID, string username, string email, string password)
            : base(adminID, username, email, password)
        {
        }

        // Override UpdateProfile from User class
        public override void UpdateProfile()
        {
            base.UpdateProfile(); // Call the base method to handle common profile updates
            Console.WriteLine("Admin's profile updated.");
        }

        public void ConfirmOrder()
        {
            Console.WriteLine("Order has been confirmed by admin.");
        }

        public void ConfirmPayment()
        {
            Console.WriteLine("Payment has been confirmed by admin.");
        }

        public void SellingReport()
        {
            Console.WriteLine("Admin generated a selling report.");
        }

        // Optionally, you can add a method to log in as well
        override public void Login(string inputPassword)
        {
            if (CheckPassword(inputPassword))
            {
                Console.WriteLine($"{Username} (Admin) logged in successfully.");
            }
            else
            {
                Console.WriteLine("Login failed: Incorrect password.");
            }
        }

        // Logout method inherited from User
    }
}
