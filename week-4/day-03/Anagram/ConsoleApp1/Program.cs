using Anagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static AnagramClass anie = new AnagramClass();

        static void Main(string[] args)
        {
            anie.AnagramCheck("farok", "kutya");
        }
    }
}
