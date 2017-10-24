using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_String3
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "xXoxoXoOXoxoXOXXoxxx";
            Console.WriteLine(SwapXtoZero(word));
            Console.ReadLine();
        }

        private static string SwapXtoZero(string word)
        {
            if (word.Length == 0)
            {
                return "";
            }
            return SwapXtoZero(word.Substring(0, word.Length - 1)) + (word.Substring(word.Length - 1, 1)) + "*";
        }
    }
}
