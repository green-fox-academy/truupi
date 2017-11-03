using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoApp.Controllers
{
    [Route("todo")]
    public class TodoController : Controller
    {
        TodoRepository todoRepository;
        static string IsDone = "";

        public TodoController(TodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        [HttpGet]
        [Route("")]
        [Route("list")]
        public IActionResult List()
        {
            string isDone = IsDone;
            IsDone = "";
            return View(todoRepository.CheckTaskStatus(isDone));
        }

        [HttpPost]
        [Route("")]
        [Route("list")]
        public IActionResult ListIsDone(string isDone)
        {
            IsDone = isDone;
            return RedirectToAction("List");
        }
    }
}
