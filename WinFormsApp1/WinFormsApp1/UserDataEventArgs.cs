public class UserDataEventArgs : EventArgs
{
    public string Name { get; }
    public string Email { get; }
    public string Phone { get; }
    public string Address { get; }
    public string ImageLocation { get; } // Add this property

    public UserDataEventArgs(string name, string email, string phone, string address, string imageLocation)
    {
        Name = name;
        Email = email;
        Phone = phone;
        Address = address;
        ImageLocation = imageLocation;
    }
}
