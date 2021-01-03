using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace ThuenhatroAPI.Models
{
    public class Context:DbContext
    {
        public User(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }

    }
}
