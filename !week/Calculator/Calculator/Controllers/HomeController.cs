using System;
using Microsoft.AspNetCore.Mvc;
using Calculator.Models;
using Microsoft.AspNetCore.Http;

namespace Calculator.Controllers
{
    public class HomeController : Controller
    {
        Calculation Calculate;

        public HomeController(Calculation calculate)
        {
            Calculate = calculate;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("")]
        public IActionResult Calculation(IFormCollection formCollection)
        {
            try
            {
                dynamic result = Calculate.NumberTypeChecker(
                    formCollection["inputNumber1"], 
                    formCollection["inputNumber2"], 
                    formCollection["arithmetictype"]);
                return View("Index", result);
            }
            catch (Exception)
            {
                return View("Index", "Please type in numbers!");
            }
        }
    }
}