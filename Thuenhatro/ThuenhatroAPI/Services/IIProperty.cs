using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroAPI.Model;
namespace ThuenhatroAPI.Service
{
   public interface IIProperty
    {
        Task<IEnumerable<Property>> GetAll();
        Task<Property> AddNew(Property property);
        Task<Property> Update(Property property);
        Task<Property> Delete(int Id);
        Task<IEnumerable<Catagory>> Getcta();
        Task<Catagory> catagory(Catagory catagory);
        Task<Picture> picture(Picture picture);
    }
}
