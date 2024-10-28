using System;

namespace WinFormsApp1
{
    internal class Seller : User
    {
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Seller(int sellerID, string username, string email, string password, string address, string phoneNumber)
            : base(sellerID, username, email, password)
        {
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }

        // Override UpdateProfile to include Address and PhoneNumber for Seller
        public override void UpdateProfile()
        {
            base.UpdateProfile(); // Call base method to update common fields
            Console.WriteLine($"Seller's profile updated with address: {Address} and phone number: {PhoneNumber}");
        }

        // Sign up method specific to Seller
        public void SignUp()
        {
            Console.WriteLine("Seller signed up with the following details:");
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
        }
    }
}
