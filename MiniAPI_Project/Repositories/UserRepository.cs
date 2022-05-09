using MiniAPI_Project.Models;

namespace MiniAPI_Project.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new() { Username = "vijay_admin", EmailAddress = "k_vijay@gmail.com", Password = "Vijay@123", GivenName = "Vijay", Surname = "Kangude", Role = "Administrator" },
            new() { Username = "Shivam", EmailAddress = "k_shivam@gmail.com", Password = "Shivam@123", GivenName = "Shivam", Surname = "Kale", Role = "Standard" },
        };
    }
}
