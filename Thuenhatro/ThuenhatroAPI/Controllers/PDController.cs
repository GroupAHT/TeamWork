using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroAPI.Service;
using ThuenhatroAPI.Models;
namespace ThuenhatroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PDController : ControllerBase
    {
        private IProvider db;
        public PDController(IProvider db)
        {
            this.db = db;
        }

        [HttpGet()]
        public Task<IEnumerable<Provider>> FindAll()
        {
            return db.FindAll();
        }
    }
}
