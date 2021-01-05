using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroAPI.Models;
using ThuenhatroAPI.Services;
using Microsoft.EntityFrameworkCore;


namespace ThuenhatroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet()]
        public async Task<IEnumerable<User>> Get()
        {
            return await userService.GetUsers();
        }
        [HttpGet("{id}")]
        public async Task<User>Get(string id)
        {
            return await userService.GetUser(id);
        }
        [HttpPost()]
        public async Task<User>Post(User user)
        {
            return await userService.PostUser(user);
        }
        [HttpPut()]
        public async Task<User>Put(User user)
        {
            return await userService.PutUser(user);
        }
        [HttpDelete("{id}")]
        public async Task<User> Detele(string id)
        {
            return await userService.DeleteUser(id);
        }
    }
}
