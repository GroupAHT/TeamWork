using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroAPI.Models;
using ThuenhatroAPI.Service;
namespace ThuenhatroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DTController : ControllerBase
    {
        private IDistrick db;
        public DTController(IDistrick db)
        {
            this.db = db;
        }

        [HttpGet()]
        public Task<IEnumerable<Districks>> FindAll()
        {
            return db.FindAll();
        }
    }
}
