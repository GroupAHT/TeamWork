using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroAPI.Model;
using Microsoft.EntityFrameworkCore;
namespace ThuenhatroAPI.Service
{
    public class Warssds : IWard
    {
        private ClassContext context;
        public Warssds(ClassContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Ward>> FindAll()
        {
            return await context.ward.ToListAsync();
        }
    }
}
