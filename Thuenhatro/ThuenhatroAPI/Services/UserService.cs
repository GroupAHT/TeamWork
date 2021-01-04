using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroAPI.Models;

namespace ThuenhatroAPI.Services
{
    public class UserService : IUserService
    {
        private Context context;
        public UserService(Context context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<User>> GetUsers()
        {
            return context.Users.ToList();
        }
        public async Task<User> DeleteUser(string id)
        {
            User model = context.Users.SingleOrDefault(u => u.UserID.Equals(id));
            if (model != null)
            {
                context.Users.Remove(model);
                context.SaveChanges();
                return model;
            }
            else
            {
                return null;
            }
        }
        public async Task<User> GetUser(string id)
        {
            var user = context.Users.SingleOrDefault(u => u.UserID.Equals(id));
            if (user != null)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
        public async Task<User> PostUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }
        public async Task<User> PutUser(User user)
        {
            User model = context.Users.SingleOrDefault(u => u.UserID.Equals(user.UserID));
            if(model != null)
            {
                model.FirstName = user.FirstName;
                model.LastName = user.LastName;
                model.UserName = user.UserName;
                model.PassWord = user.PassWord;
                context.SaveChanges();
                return user;
            }
            else
            {
                return null;
            }
        }
        public async Task<User> CheckLogin(User user)
        {
            var userLogin = context.Users
             .Where(a => a.UserName.Equals(user.UserName) && a.PassWord.Equals(user.PassWord) && a.Status.Equals(1))
             .FirstOrDefault();
            return userLogin;
        }
    }
}
