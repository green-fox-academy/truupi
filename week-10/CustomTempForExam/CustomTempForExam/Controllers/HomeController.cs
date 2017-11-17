using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomTempForExam.Services;

namespace CustomTempForExam.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        HomeService HomeService;

        public HomeController(HomeService homeService)
        {
            HomeService = homeService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
