using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroAPI.Models;

namespace ThuenhatroAPI.Service
{
   public interface IWard
    {
        Task<IEnumerable<Ward>> FindAll();
    }
}
