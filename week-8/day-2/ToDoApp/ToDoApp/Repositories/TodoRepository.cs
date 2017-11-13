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
        TodoContext todoContext;

        public TodoRepository(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }

        internal void AddTask(Todo todo)
        {
            todoContext.Todo.Add(new Todo
            {
                Title = todo.Title,
                IsUrgent = todo.IsUrgent,
                IsDone = todo.IsDone
            });
            todoContext.SaveChanges();
        }

        internal void DeleteTask(int id)
        {
            todoContext.Todo.Remove(todoContext.Todo.FirstOrDefault(t => t.Id == id));
            todoContext.SaveChanges();
        }

        public List<Todo> ListAllTasks()
        {
            return todoContext.Todo.ToList();
        }

        internal List<Todo> CheckTaskStatus(string isDone)
        {
            var resultList = ListAllTasks();
            if (isDone == "Done")
            {
                resultList = resultList.Where(todo => todo.IsDone == true).Select(todo => todo).ToList();
            }
            else if (isDone == "NotDone")
            {
                resultList = resultList.Where(todo => todo.IsDone == false).Select(todo => todo).ToList();
            }
            return resultList;
        }

    }
}
