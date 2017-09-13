using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder qoute = new StringBuilder("Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.");
            Console.WriteLine(qoute.Insert(21, "always takes longer than "));
            Console.ReadLine();
        }
    }
}
