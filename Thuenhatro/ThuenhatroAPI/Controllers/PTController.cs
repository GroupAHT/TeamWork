using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroAPI.Service;
using ThuenhatroAPI.Models;
using Microsoft.AspNetCore.Hosting;

namespace ThuenhatroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PTController : ControllerBase
    {
        [Obsolete]
        private readonly IHostingEnvironment _hostingEnvironment;
        private IIProperty db;

        [Obsolete]
        public PTController(IIProperty db, IHostingEnvironment hostingEnvironment)
        {
            this.db = db;
            _hostingEnvironment = hostingEnvironment; ;
        }

        [HttpGet()]
        public Task<IEnumerable<Property>> Get()
        {
            return db.GetAll();
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
