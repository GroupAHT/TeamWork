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

    }
}
