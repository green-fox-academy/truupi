using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        
        [MinLength (2)]
        [MaxLength (50)]
        [Display (Name ="Task name")]
        public string Title { get; set; }

        [Display (Name ="Make it priority?")]
        public bool IsUrgent { get; set; } = false;


        public bool IsDone { get; set; } = false;
    }
}
