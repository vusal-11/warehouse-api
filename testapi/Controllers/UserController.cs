using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using testapi.Models;
using testapi.Services;

namespace testapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]

        public async Task<List<User>> Get()
        {
            return await _userService.GetUsers();
        }

        [HttpPost]
        public async Task<User> Post([FromBody] User user)
        {
            return await _userService.CreateUser(user);
        }

        [HttpPut("{id}")]
        public async Task<User> Put(int id, [FromBody] User user)
        {

           return await  _userService.UpdateUser(id,user);

        }





    }
}
