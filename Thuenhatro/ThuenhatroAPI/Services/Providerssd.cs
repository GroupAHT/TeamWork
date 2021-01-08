using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroAPI.Model;
using Microsoft.EntityFrameworkCore;
namespace ThuenhatroAPI.Service
{
    public class Providerssd : IProvider
    {
        private ClassContext context;
        public Providerssd(ClassContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Provider>> FindAll()
        {
            return await context.province.ToListAsync();
        }
    }
}
