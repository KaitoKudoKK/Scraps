using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Seller
    {
        public int SellerID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public void SignUp() { }
        public void Login() { }
        public void UpdateProfile() { }
        public void Logout() { }
    }
}
