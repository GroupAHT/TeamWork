using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroAPI.Model;
namespace ThuenhatroAPI.Service
{

   public interface IProvider
    {
        Task<IEnumerable<Provider>> FindAll();
    }
}
