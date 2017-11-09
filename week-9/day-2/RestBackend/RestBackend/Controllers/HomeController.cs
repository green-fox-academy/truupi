using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestBackend.Repositories;
using RestBackend.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestBackend.Controllers
{

    public class HomeController : Controller
    {
        HomeRepository HomeRepository;

        public HomeController(HomeRepository homeRepository)
        {
            HomeRepository = homeRepository;
        }


        [Route("")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet]
        [Route("doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input != null)
            {
                return Json(new { received = input, result = input * 2 });
            }
            return Json(new { error = "Please provide an input!" });
        }

        [HttpGet]
        [Route("greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (String.IsNullOrEmpty(name))
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (String.IsNullOrEmpty(title))
            {
                return Json(new { error = "Please provide a title!" });
            }
            return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
        }

        [HttpGet]
        [Route("appenda/{appendable}")]
        [Route("appenda")]
        public IActionResult AppendA(string appendable)
        {
            if (String.IsNullOrEmpty(appendable))
            {
                return NotFound();
            }
            return Json(new { appended = $"{appendable}a" });
        }

        [HttpPost]
        [Route("dountil/{what}")]
        [Route("dountil")]
        public IActionResult DoUntil(string what, [FromBody]ObjectData objectData)
        {
            int? result = 0;

            if (objectData == null)
            {
                return Json(new { error = "Please provide a number!" });
            }
            else
            {
                if (what == "sum")
                {
                    for (int? i = 0; i <= objectData.Until; i++)
                    {
                        result += i;
                    }
                }
                else if (what == "factor")
                {
                    result = 1;
                    for (int? i = 1; i <= objectData.Until; i++)
                    {
                        result *= i;
                    }
                }
                return Json(new { result = result });
            }
        }

        [HttpPost]
        [Route("arrays")]
        public IActionResult ArrayHandler([FromBody]ComplexData complexData)
        {
            dynamic result = 0;

            if (complexData != null)
            {
                if (complexData.Numbers == null || complexData.Numbers.Length == 0)
                {
                    return Json(new { error = "Please provide an array of numbers!" });
                }
                else if (complexData.What == null)
                {
                    return Json(new { error = "Please provide what to do with the numbers!" });
                }
                else
                {
                    return Json(new { result = HomeRepository.ArithmeticTypeCheck(complexData) });
                }
            }
            else
            {
                return Json(new { error = "Please provide proper inputs!" });
            }
        }
    }
}
