using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace ThuenhatroAPI.Service
{
    public class Properyty : IIProperty
    {
        private readonly Context classContext;
        public Properyty(Context classContext)
        { 
         this.classContext = classContext;
        }
        public async Task<Property> AddNew(Property property)
        {
            classContext.Property.Add(property);
            await classContext.SaveChangesAsync();
            return property;
        }

        public async Task<Catagory> catagory(Catagory catagory)
        {
            classContext.Catagory.Add(catagory);
            await classContext.SaveChangesAsync();
            return catagory;
        }

        public async Task<Property> Delete(int Id)
        {
            var Check = classContext.Property.Find(Id);
            if (Check != null)
            {
                classContext.Property.Remove(Check);
            }
            await classContext.SaveChangesAsync();
            return Check;
        }

        public async Task<IEnumerable<Property>> GetAll()
        {
            return await classContext.Property.ToListAsync();
        }

        public async Task<IEnumerable<Catagory>> Getcta()
        {
            return await classContext.Catagory.ToListAsync();
        }

    
        public async Task<Property> Update(Property property)
        {
            var model = await classContext.Property.SingleOrDefaultAsync(x => x.PropertyCode.Equals(property.PropertyCode));
            if (model != null)
            {    
                classContext.SaveChanges();
                return property;
            }
            else
            {
                return null;
            }
        }
    }
}
