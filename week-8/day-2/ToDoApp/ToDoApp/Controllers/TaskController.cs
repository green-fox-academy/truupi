using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;
using ToDoApp.Repositories;

namespace ToDoApp.Controllers
{
    public class TaskController : Controller
    {
        TodoRepository todoRepository;

        public TaskController(TodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        [HttpGet]
        [Route("addtask")]
        public IActionResult AddTaskRead ()
        {
            return View();
        }

        [HttpPost]
        [Route ("addtask")]
        public IActionResult AddTaskWrite (Todo todo)
        {
            todoRepository.AddTask(todo);
            return RedirectToAction("list", "todo");
        }

        [HttpGet]
        [Route("deletetask/{id}")]
        public IActionResult DeleteTask(int id)
        {
            todoRepository.DeleteTask(id);
            return RedirectToAction("list", "todo");
        }
    }
}
