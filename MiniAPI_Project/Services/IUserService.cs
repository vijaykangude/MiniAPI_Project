using MiniAPI_Project.Models;

namespace MiniAPI_Project.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
