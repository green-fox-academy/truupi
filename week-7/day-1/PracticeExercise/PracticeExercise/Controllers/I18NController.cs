using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticeExercise.Models;

namespace PracticeExercise.Controllers
{   
    [Route("i18n")]
    public class I18NController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(Greetings.hellos);
        }
    }
}
