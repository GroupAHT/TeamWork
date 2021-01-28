using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ThuenhatroClient.Models;

using Newtonsoft.Json;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using System.IO;
using X.PagedList;
using X.PagedList.Mvc.Core;

namespace ThuenhatroClient.Controllers
{
    public class HomeController : Controller
    {
        private string url = "http://localhost:65355/api/";
        private HttpClient httpClient = new HttpClient();

        public IActionResult Index(int? page,string city)
        {
            var ditrick = JsonConvert.DeserializeObject<IEnumerable<Districks>>(httpClient.GetStringAsync(url + "DT/").Result);
            var wars = JsonConvert.DeserializeObject<IEnumerable<Ward>>(httpClient.GetStringAsync(url + "Wardss/").Result);
            var property = JsonConvert.DeserializeObject<IEnumerable<Property>>(httpClient.GetStringAsync(url + "PT/").Result);
            var provin = JsonConvert.DeserializeObject<IEnumerable<Provider>>(httpClient.GetStringAsync(url + "PD/").Result);
            var ConnectTwoPoint = from i in ditrick
                                  join a in wars
                                  on i.id equals a._district_id
                                  select new NewsView
                                  {
                                      Districks = i,
                                      Ward = a
                                  };
            var newsInfor = from p in property
                            join i in ditrick on p.DistrictCode equals i.id
                            join a in wars on p.WardsCode equals a.id
                            select new NewsView
                            {
                                Districks = i,
                                Ward = a,
                                Property = p
                                  };

            int pageSize = 8;
            int pageNumber = (page ?? 1);
            if(city != null)
            {
                var checkItem = ditrick.Where(m => m._province_id.Equals(city)).ToList();
                ViewBag.Address = checkItem;

            }
            else
            {
                var checkItem = ConnectTwoPoint.OrderByDescending(m => m.Ward._name).ToList();
                ViewBag.Address = checkItem;
            }
            
            var newsInform = newsInfor.OrderByDescending(m => m.Property.CreateAT).ToList();
            var hotNews = newsInfor.OrderByDescending(m => m.Property.CreateAT).Take(4).ToList();
            var nows = newsInfor.OrderByDescending(m => m.Property.CreateAT).Take(10).ToList();
            //var htNews = newsInfor.OrderByDescending(m => m.Property.CreateAT).Take(6);
            //var hotNews = htNews.OrderByDescending(m=>m.Property.)
            ViewBag.City = provin;
            
            ViewBag.NewsInformation = newsInform.ToPagedList(pageNumber,pageSize);
            ViewBag.nows = nows;
            ViewBag.hotNews = hotNews;
            return View();
        }

        public IActionResult GetDicstricks()
        {
            return PartialView("_GetDicstricks");
        }
        public IActionResult GetWards()
        {
            return PartialView("_GetWards");
        }
        public IActionResult GetProperty()
        {
            var model = JsonConvert.DeserializeObject<IEnumerable<User>>(httpClient.GetStringAsync(url + "FindAll").Result);
            
            return PartialView("_Getproperty");
        }
    }
}
