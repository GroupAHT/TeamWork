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
            return context.User.ToList();
        }
        public async Task<User> DeleteUser(string id)
        {
            User model = context.User.SingleOrDefault(u => u.UserID.Equals(id));
            if (model != null)
            {
                context.User.Remove(model);
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
            var user = context.User.SingleOrDefault(u => u.UserID.Equals(id));
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
            context.User.Add(user);
            context.SaveChanges();
            return user;
        }
        public async Task<User> PutUser(User user)
        {
            User model = context.User.SingleOrDefault(u => u.UserID.Equals(user.UserID));
            if(model != null)
            {
                model.FirstName = user.FirstName;
                model.LastName = user.LastName;
                model.UserName = user.UserName;
                model.PassWord = user.PassWord;
                model.MembershipCode = user.MembershipCode;
                model.Phone = user.Phone;
                model.Email = user.Email;
                context.SaveChanges();
                return user;
            }
            else
            {
                return null;
            }
        }

    }
}
