using Microsoft.AspNetCore.Mvc;
using ContactCardApp.Repositories;
using ContactCardApp.Models;
using ContactCardApp.ViewModels;
using ContactCardApp.Services;

namespace ContactCardApp.Controllers
{
    [Route("")]
    public class ContactController : Controller
    {
        ContactService ContactService;

        public ContactController(ContactService contactService)
        {
            ContactService = contactService;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/addcard")]
        public IActionResult Addcard()
        {
            return View(new ContactCardViewModel());
        }

        [HttpPost]
        [Route("/addcard")]
        public IActionResult AddcardPost(ContactCardViewModel inputContactCardViewModel)
        {
            ContactService.CreateContactCard(inputContactCardViewModel);
            return RedirectToAction("ListContacts");
        }

        [HttpGet]
        [Route("/listcontacts")]
        public IActionResult ListContacts()
        {
            return View(ContactService.ListCards());
        }

        [HttpGet]
        [Route("/listcontacts/{id}")]
        public IActionResult ListSpecificContact(int id)
        {
            return View(ContactService.ShowSpecificCard(id));
        }
    }
}
