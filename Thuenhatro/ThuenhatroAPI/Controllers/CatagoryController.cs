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
    public class CatagoryController : ControllerBase
    {
        private readonly IIProperty db;

        public CatagoryController(IIProperty db)
        {
            this.db = db;
        }

        [HttpGet()]
        public Task<IEnumerable<Catagory>> Get()
        {
            return db.Getcta();
        }

        [HttpPost()]

        public Task<Catagory> Post(Catagory catagory)
        {
            return db.catagory(catagory);
        }
    }
}
