using Microsoft.AspNetCore.Mvc;
using ContactCardApp.Repositories;

namespace ContactCardApp.Controllers
{
    [Route("")]
    public class ContactController : Controller
    {
        ContactRepository contactRepository;

        public ContactController(ContactRepository contactRepository)
        {
            this.contactRepository = contactRepository;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/listcontacts")]
        public IActionResult ListContacts()
        {
            return View(contactRepository.ListCards());
        }

        [HttpGet]
        [Route("/listcontacts/{id}")]
        public IActionResult ListSpecificContact(int id)
        {
            return View(contactRepository.ShowSpecificCard(id));
        }
    }
}
