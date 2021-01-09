using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace ThuenhatroAPI.Service
{
    public class Warssds : IWard
    {
        private Context context;
        public Warssds(Context context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Ward>> FindAll()
        {
            return await context.ward.ToListAsync();
        }
    }
}
