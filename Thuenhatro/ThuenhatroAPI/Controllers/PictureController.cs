using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ThuenhatroAPI.Models;
using ThuenhatroAPI.Service;

namespace ThuenhatroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PictureController : ControllerBase
    {
        private IPic db;
        private Context _db;
        public PictureController(IPic db, Context _db)
        {
            this._db = _db;
            this.db = db;
        }

        [HttpPost()]
        public async Task<Picture> Upload(Picture picture)
        {
            return await db.Add(picture);
        }
    }
}