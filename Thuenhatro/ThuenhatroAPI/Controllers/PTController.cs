using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroAPI.Service;
using ThuenhatroAPI.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
namespace ThuenhatroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PTController : ControllerBase
    {
        private IIProperty db;

        public PTController(IIProperty db)
        {
            this.db = db;
        }

        [HttpGet()]
        public Task<IEnumerable<Property>> FindAll()
        {
            return db.FindAll();
        }

        [HttpPut("{id}")]
        public Task<Property> Update(Property property)
        {
            return db.Update(property);
        }

        [HttpPost()]

        public Task<Property> Post(Property property)
        {  
            return db.AddNew(property);
        }
        [HttpDelete("{id}")]

        public Task<Property> Delete(int id)
        {
            return db.Delete(id);
        }
    }
}
