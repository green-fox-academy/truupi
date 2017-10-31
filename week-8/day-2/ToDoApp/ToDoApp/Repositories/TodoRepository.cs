using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Entities;
using ToDoApp.Models;

namespace ToDoApp.Repositories
{
    public class TodoRepository
    {
        TodoContext TodoContext;

        public TodoRepository(TodoContext todoContext)
        {
            TodoContext = todoContext;
        }

        public void AddTask()
        {

        }

        public List<Todo> ListTasks()
        {
            return TodoContext.Todo.ToList();
        }
    }
}
