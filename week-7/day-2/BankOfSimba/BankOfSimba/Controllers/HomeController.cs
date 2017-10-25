using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    [Route("Simba")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("Simple")]
        public IActionResult Index()
        {
            return View(new BankAccount ("Simba", 2000, Animal.Lion));
        }

        [HttpGet]
        [Route("Complicated")]
        public IActionResult ListOfAnimals()
        {
            return View(new List<BankAccount> {
                new BankAccount("Mufasa", 14000, Animal.Lion),
                new BankAccount("Rafiki", 8000, Animal.Monkey),
                new BankAccount("Moose", 400, Animal.Hyena),
                new BankAccount("Scar", 6000, Animal.Lion),
                new BankAccount("Zazu", 10000, Animal.Vulture) });
        }
    }
}
