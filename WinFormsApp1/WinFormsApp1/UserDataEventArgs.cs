using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class UserDataEventArgs : EventArgs
    {
        public string Name { get; }
        public string Email { get; }
        public string Phone { get; }
        public string Address { get; }

        public UserDataEventArgs(string name, string email, string phone, string address)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Address = address;
        }
    }
}
