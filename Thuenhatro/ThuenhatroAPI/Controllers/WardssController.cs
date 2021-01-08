using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroAPI.Service;
using ThuenhatroAPI.Model;
namespace ThuenhatroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WardssController : ControllerBase
    {
        private IWard db;
        public WardssController(IWard db)
        {
            this.db = db;
        }

        [HttpGet()]
        public Task<IEnumerable<Ward>> FindAll()
        {
            return db.FindAll();
        }
    }
}
