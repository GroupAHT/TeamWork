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
        private Context context;
        public Properyty(Context context)
        {
            this.context = context;
        }
        public async Task<Property> AddNew(Property property)
        {
            context.Property.Add(property);
            await context.SaveChangesAsync();
            return property;
        }

        //public async Task<Picture> AddPicture(Picture picture)
        //{
        //    classContext.Picture.Add(picture);
        //    await classContext.SaveChangesAsync();
        //    return picture;
        //}

        public async Task<Catagory> catagory(Catagory catagory)
        {
            context.Catagory.Add(catagory);
            await context.SaveChangesAsync();
            return catagory;
        }

        public async Task<Property> Delete(int Id)
        {
            var Check = context.Property.Find(Id);
            if (Check != null)
            {
                context.Property.Remove(Check);
            }
            await context.SaveChangesAsync();
            return Check;
        }

        public async Task<IEnumerable<Catagory>> Getcta()
        {
            return await context.Catagory.ToListAsync();
        }

        public async Task<Property> Update(Property property)
        {
            var model = await context.Property.SingleOrDefaultAsync(x => x.PropertyCode.Equals(property.PropertyCode));
            if (model != null)
            {
                context.SaveChanges();
                return property;
            }
            else
            {
                return null;
            }
        }

        public async Task<IEnumerable<Property>> FindAll()
        {
            return await context.Property.ToListAsync();
        }
    }
}
