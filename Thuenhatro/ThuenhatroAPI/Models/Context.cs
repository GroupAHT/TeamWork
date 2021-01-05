using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace ThuenhatroAPI.Models
{
    public class Context:DbContext
    {
       public Context (DbContextOptions options) : base(options) { }
       public DbSet<User> User { get; set; }

    }
}
