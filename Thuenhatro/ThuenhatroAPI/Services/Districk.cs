using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroAPI.Models;

namespace ThuenhatroAPI.Service
{
    public class Districk : IDistrick
    {
        private Context context;
        public Districk(Context context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Districks>> FindAll()
        {
            return await context.district.ToListAsync();
        }
    }
}
