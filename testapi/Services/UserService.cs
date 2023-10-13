using testapi.Data;
using testapi.Models;

namespace testapi.Services
{
    public class UserService : IUserService
    {


        private readonly WareHouseDbContext _dbContext;
        public UserService(WareHouseDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public  Task<List<User>> GetUsers()
        {
            return Task.FromResult(_dbContext.Users.ToList());
        }

        public  Task<User> CreateUser(User user)
        {
            var newUser = _dbContext.Users.Add(user).Entity;
            return Task.FromResult(newUser);
        }

        public Task<User> UpdateUser(int id,User user)
        {

            var updateUser = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            updateUser.UserName = user.UserName;  //login
            updateUser.PassWord = user.PassWord;
            updateUser.Name = user.Name;
            updateUser.SurName = user.SurName;
            updateUser.clients = user.clients;
            updateUser.orders = user.orders;
            return Task.FromResult(updateUser);


        }

      
    }
}
