using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace ThuenhatroAPI.Service
{
    public class Providerssd : IProvider
    {
        private Context context;
        public Providerssd(Context context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Provider>> FindAll()
        {
            return await context.province.ToListAsync();
        }
    }
}
