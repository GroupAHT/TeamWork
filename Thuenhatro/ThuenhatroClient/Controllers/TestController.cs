using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using System.Net.Http;
using Newtonsoft.Json;
using ThuenhatroClient.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using ThuenhatroClient.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ThuenhatroClient.Controllers
{
    public class TestController : Controller
    {
        private string url = "http://localhost:65355/api/";
        private HttpClient httpClient = new HttpClient();
        public IActionResult Index()
        {
            var model = JsonConvert.DeserializeObject<IEnumerable<Ward>>(httpClient.GetStringAsync(url + "Wardss/").Result);
            var search = from i in model
                         select i;
            return View(search);
        }
        private string Ctagory = "http://localhost:65355/api/Catagory";

        public IActionResult Districk(int id)
        {
            var model = JsonConvert.DeserializeObject<IEnumerable<Districks>>(httpClient.GetStringAsync(url + "DT/").Result);
            var checkItem = model.Where(m => m._province_id.Equals(id)).ToList();
            return Json(checkItem.Select(x => new
            {
                id = x.id,
                name = x._name
            }).ToList());
        }
        public IActionResult Ward(int id)
        {
            var ditrick = JsonConvert.DeserializeObject<IEnumerable<Districks>>(httpClient.GetStringAsync(url + "DT/").Result);
            var wars = JsonConvert.DeserializeObject<IEnumerable<Ward>>(httpClient.GetStringAsync(url + "Wardss/").Result);
            var ConnectTwoPoint = from i in ditrick
                                  join a in wars
                                  on i.id equals a._district_id
                                  select new CatagoryvsProperty
                                  {
                                      districks = i,
                                      ward = a
                                  };
            var checkItem = ConnectTwoPoint.Where(m => m.ward._district_id.Equals(id)).ToList();
            return Json(checkItem.Select(x => new
            {
                id = x.ward.id,
                name = x.ward._name
            }).ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            var modessl = JsonConvert.DeserializeObject<IEnumerable<Catagory>>(httpClient.GetStringAsync(Ctagory).Result);
            var cata = from i in modessl
                       select i;
            ViewBag.Cata = cata;

            var model = JsonConvert.DeserializeObject<IEnumerable<Ward>>(httpClient.GetStringAsync(url + "Wardss/").Result);
            var wards = from i in model
                        select i;

            // Set vào ViewBag
            ViewBag.wards = wards;
            //


            var models = JsonConvert.DeserializeObject<IEnumerable<Districks>>(httpClient.GetStringAsync(url + "DT/").Result);
            var Districk = from i in models
                           select i;

            // Set vào ViewBag
            ViewBag.Districk = Districk;

            var modelss = JsonConvert.DeserializeObject<IEnumerable<Provider>>(httpClient.GetStringAsync(url + "PD/").Result);
            var provider = from i in modelss
                           select i;

            // Set vào ViewBag
            ViewBag.provider = provider;
            return View();
        }

        [Obsolete]
        private readonly IHostingEnvironment hostingEnvironment;

        [Obsolete]
        public TestController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }
        [HttpPost]
        [Obsolete]
        public IActionResult Create(CreateViewMode create, string check)
        {
            try
            {
                string uniqueFileName = null;

                // If the Photos property on the incoming model object is not null and if count > 0,
                // then the user has selected at least one file to upload
                if (create.Photos != null && create.Photos.Count > 0)
                {
                    // Loop thru each selected file
                    foreach (IFormFile photo in create.Photos)
                    {
                        // The file must be uploaded to the images folder in wwwroot
                        // To get the path of the wwwroot folder we are using the injected
                        // IHostingEnvironment service provided by ASP.NET Core
                        string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                        // To make sure the file name is unique we are appending a new
                        // GUID value and and an underscore to the file name
                        uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        // Use CopyTo() method provided by IFormFile interface to
                        // copy the file to wwwroot/images folder
                        photo.CopyTo(new FileStream(filePath, FileMode.Create));
                    }
                }
                Property newss = new Property
                {
                    CategoryCode = Convert.ToInt32(check),
                    ProvinceCode = create.ProvinceCode,
                    DistrictCode = create.DistrictCode,
                    WardsCode = create.WardsCode,
                    Title = create.Title,
                    Description = create.Description,
                    Price = create.Price,
                    Acreage = create.Acreage,
                    PictureCode = uniqueFileName,
                    CreateAT = DateTime.Now
                };
                var model = httpClient.PostAsJsonAsync<Property>(url + "PT/", newss).Result;
                if (model.IsSuccessStatusCode)//kiem tra trang thai post du lieu len web API
                {
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }
            return View();
        }

    }
}
