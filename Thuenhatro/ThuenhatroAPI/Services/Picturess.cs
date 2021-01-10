using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroAPI.Models;

namespace ThuenhatroAPI.Service
{
    public class Picturess : IPic
    {
        private readonly Context classContext;
        public Picturess(Context classContext)
        {
            this.classContext = classContext;
        }
        public async Task<Picture> Add(Picture picture)
        {
            classContext.Picture.Add(picture);
            classContext.SaveChanges();
            return picture;
        }
    }
}
