using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroAPI.Service;
using ThuenhatroAPI.Model;
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
            if (files == null || files.Count == 0)
                return Content("file not selected");
            long size = files.Sum(f => f.Length);
            var filePaths = new List<string>();
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    // full path to file in temp location
                    var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "userimages");

                    filePaths.Add(filePath);

                    var fileNameWithPath = string.Concat(filePath, "\\", formFile.FileName);

                    using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }
            // process uploaded files
            // Don't rely on or trust the FileName property without validation.
            return Ok(new { count = files.Count, size, filePaths });
            return db.AddNew(property);
        }
        [HttpDelete("{id}")]

        public Task<Property> Delete(int id)
        {
            return db.Delete(id);
        }
    }
}
