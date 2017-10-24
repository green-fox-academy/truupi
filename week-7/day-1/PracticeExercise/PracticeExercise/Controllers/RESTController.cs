using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticeExercise.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracticeExercise.Controllers
{
    [Route("api")]  
    public class RESTController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting")]
        public IActionResult Greetings(string name)
        {
            Greeting.Counter++;
            return new JsonResult(new Greeting { Id = Greeting.Counter, Content = $"Hello {name}!" });
        }
    }
}
