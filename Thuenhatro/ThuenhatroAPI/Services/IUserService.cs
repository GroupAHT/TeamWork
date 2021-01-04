using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroAPI.Models;

namespace ThuenhatroAPI.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(string id);
        Task<User> PostUser(User user);
        Task<User> PutUser(User user);
        Task<User> DeleteUser(string id);
        Task<User> CheckLogin(User user);

    }
}
