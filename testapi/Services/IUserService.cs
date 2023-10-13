using testapi.Models;

namespace testapi.Services
{
    public interface IUserService
    {
        Task<List<User>> GetUsers();
        Task<User> CreateUser(User user);
        Task<User> UpdateUser(int id,User user);
    }
}
