using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroAPI.Model;

namespace ThuenhatroAPI.Service
{
    public class Districk : IDistrick
    {
        private ClassContext context;
        public Districk(ClassContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Districks>> FindAll()
        {
            return await context.district.ToListAsync();
        }
    }
}
