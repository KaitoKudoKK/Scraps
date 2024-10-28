using System;

namespace WinFormsApp1
{
    internal class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        private string password; // Encapsulated

        public User(int userID, string username, string email, string password)
        {
            this.UserID = userID;
            this.Username = username;
            this.Email = email;
            SetPassword(password);
        }

        // Encapsulated method to set password
        public void SetPassword(string password)
        {
            this.password = password;
        }

        // Check password method for login
        public bool CheckPassword(string inputPassword)
        {
            return this.password == inputPassword;
        }

        // Simulated login method
        public virtual void Login(string inputPassword)
        {
            if (CheckPassword(inputPassword))
            {
                Console.WriteLine($"{Username} logged in successfully.");
            }
            else
            {
                Console.WriteLine("Login failed: Incorrect password.");
            }
        }

        // Update profile method without parameters
        public virtual void UpdateProfile()
        {
            Console.WriteLine("Profile updated.");
        }

        // Logout method
        public void Logout()
        {
            Console.WriteLine($"{Username} logged out.");
        }
    }
}
