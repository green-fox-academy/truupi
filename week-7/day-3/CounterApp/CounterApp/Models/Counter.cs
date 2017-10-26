using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CounterApp.Models
{
    public class Counter
    {
        public int Counted { get; set; } = 1;

        public void Increase()
        {
            Counted++;
        }
    }
}
