using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ThuenhatroClient.Models;
using Newtonsoft.Json;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace ThuenhatroClient.Controllers
    
{
    public class UserController : Controller
    {
        private string url = "http://localhost:65355/api/User/";
        private HttpClient httpClient = new HttpClient();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();

        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Login(string uid, string upass)
        {

            try
            {
                var model = JsonConvert.DeserializeObject<IEnumerable<User>>(httpClient.GetStringAsync(url).Result);
                var user = model.Where(e => e.UserID.Equals(uid) && e.Status.Equals(true)).SingleOrDefault();
                if (user != null)
                {
                
                    if (user.PassWord.Equals(upass))
                    {
                        if (user.IsAdmin == true)
                        {
                            return RedirectToAction("Admin");
                        }
                        else
                        {
                            return RedirectToAction("index");
                        }
                        
                    }
                    else
                    {
                        ViewBag.Msg = "Mật khẩu không đúng...!!!";
                    }

                }
                else
                {
                    ViewBag.Msg = "Tài khoản này không tồn tại !!!";
                }
            }
            catch (Exception ex)
            {

                ViewBag.Msg = ex.Message;
            }
            return View();
        }
        public IActionResult Register()
        {
            return View();

        }
        public IActionResult ConfirmEmail()
        {
            return View();
        }
        public IActionResult ConfirmCodeEmail()
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        public IActionResult ConfirmCodePassword()
        {
            return View();
        }
        public IActionResult NewPassword()
        {
            return View();
        }
        public IActionResult UpdateInfoUser()
        {
            return View();
        }


    }
}
