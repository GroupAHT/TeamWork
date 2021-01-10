using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroAPI.Models;
namespace ThuenhatroAPI.Service
{
   public interface IIProperty
    {
        Task<IEnumerable<Property>> FindAll();
        Task<Property> AddNew(Property property);
        Task<Property> Update(Property property);
        Task<Property> Delete(int Id);
        Task<IEnumerable<Catagory>> Getcta();
        Task<Catagory> catagory(Catagory catagory);
    }
}
