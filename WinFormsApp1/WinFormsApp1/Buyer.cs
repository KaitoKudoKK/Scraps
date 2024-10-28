using System;

namespace WinFormsApp1
{
    internal class Buyer : User
    {
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Buyer(int buyerID, string username, string email, string password, string address, string phoneNumber)
            : base(buyerID, username, email, password)
        {
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }

        // Override UpdateProfile without parameters
        public override void UpdateProfile()
        {
            // Call base UpdateProfile
            base.UpdateProfile();

            // Additional updates for Buyer
            Console.WriteLine($"Buyer's profile updated: Address - {Address}, Phone Number - {PhoneNumber}");
        }

        public void SignUp()
        {
            Console.WriteLine("Buyer signed up with the following details:");
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
        }
    }
}
