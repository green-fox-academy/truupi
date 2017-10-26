using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreetingApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetingApp.Controllers
{
    public class HomeController : Controller
    {
        UserInfo UserInfo;

        public HomeController(UserInfo userinfo)
        {
            UserInfo = userinfo;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View(UserInfo);
        }

        [HttpPost]
        [Route("")]
        public IActionResult GetUserInfo(string userName)
        {
            UserInfo.Name = userName;
            return RedirectToAction("Greeting");
        }

        [HttpGet]
        [Route("Greeting")]
        public IActionResult Greeting()
        {
            return View(UserInfo);
        }
    }
}
