using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.Rendering;
using ThuenhatroClient.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.Extensions.FileProviders;

namespace ThuenhatroClient.Controllers
{
    public class TestController : Controller
    {
        private string url = "http://localhost:65355/api/";
        private HttpClient httpClient = new HttpClient();
        private IHostingEnvironment Environment;
        private readonly Random _random = new Random();
        public TestController(IHostingEnvironment _environment)
        {
            Environment = _environment;
        }


        public IActionResult Index()
        {
            var model = JsonConvert.DeserializeObject<IEnumerable<Ward>>(httpClient.GetStringAsync(url + "Wardss/").Result);
            var search = from i in model
                         select i;
            return View(search);
        }
        private string Ctagory = "http://localhost:65355/api/Catagory";
        private readonly HttpContent byteArrayContent;

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
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
        // Generates a random string with a given size.    
        public string RandomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);

            // Unicode/ASCII Letters are divided into two blocks
            // (Letters 65–90 / 97–122):
            // The first group containing the uppercase letters and
            // the second group containing the lowercase.  

            // char is a single Unicode character  
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length=26  

            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }
        public string RandomPassword()
        {
            var passwordBuilder = new StringBuilder();

            // 4-Letters lower case   
            passwordBuilder.Append(RandomString(4, true));

            // 4-Digits between 1000 and 9999  
            passwordBuilder.Append(RandomNumber(1000, 9999));

            // 2-Letters upper case  
            passwordBuilder.Append(RandomString(2));
            return passwordBuilder.ToString();
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

        [HttpPost]
        public async Task<IActionResult> Create(Property property, string check, List<IFormFile> postedFiles)
        {
            try
            {
                property.CategoryCode = Convert.ToInt32(check);
                property.CreateAT = DateTime.Now;
                var model = httpClient.PostAsJsonAsync<Property>(url + "PT/", property).Result;
                if (model.IsSuccessStatusCode)//kiem tra trang thai post du lieu len web API
                {
                    var properties = JsonConvert.DeserializeObject<IEnumerable<Property>>(httpClient.GetStringAsync(url + "PT/").Result);
                    var properties1 = (from i in properties
                                       orderby i.PropertyCode descending
                                       select i).First();
                    var ADDDING = new Picture();
                    string wwwPath = this.Environment.WebRootPath;
                    string contentPath = this.Environment.ContentRootPath;

                    string path = Path.Combine(this.Environment.WebRootPath, "images/");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    List<string> uploadedFiles = new List<string>();
                    foreach (IFormFile postedFile in postedFiles)
                    {
                        string fileName = Path.GetFileName(postedFile.FileName);
                        using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                        {
                            postedFile.CopyTo(stream);
                            uploadedFiles.Add(fileName);
                            ADDDING.Name = fileName;
                            ADDDING.PropertyCode = properties1.PropertyCode;
                            var PostPic = httpClient.PostAsJsonAsync<Picture>(url + "Picture/", ADDDING).Result;
                            if (PostPic.IsSuccessStatusCode)//kiem tra trang thai post du lieu len web API
                            {
                                ViewBag.Message += string.Format("<b>{0}</b> Update DB SUCCESS.<br />", fileName);
                            }
                            else
                            {
                                ViewBag.Message += string.Format("<b>{0}</b> uploaded.<br />", fileName);
                            }
                        }
                    }
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }
            return View();
        }
        public IActionResult Uploadss()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Uploadss(List<IFormFile> postedFiles,string id)
        {
            try
            {
                var ADDDING = new Picture();
                string wwwPath = this.Environment.WebRootPath;
                string contentPath = this.Environment.ContentRootPath;

                string path = Path.Combine(this.Environment.WebRootPath, "images/");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                List<string> uploadedFiles = new List<string>();
                foreach (IFormFile postedFile in postedFiles)
                {
                    string fileName = Path.GetFileName(postedFile.FileName);
                    using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                    {
                        postedFile.CopyTo(stream);
                        uploadedFiles.Add(fileName);
                        ADDDING.Name = fileName;
                        ADDDING.PropertyCode = Convert.ToInt32(id);
                        var model = httpClient.PostAsJsonAsync<Picture>(url + "Picture/", ADDDING).Result;
                        if (model.IsSuccessStatusCode)//kiem tra trang thai post du lieu len web API
                        {
                            ViewBag.Message += string.Format("<b>{0}</b> Update DB SUCCESS.<br />", fileName);
                        }
                        else
                        {
                            ViewBag.Message += string.Format("<b>{0}</b> uploaded.<br />", fileName);
                        }    
                    }
                }
                return View();
            }
            catch
            {
                return null;
            }
        }
    }
}