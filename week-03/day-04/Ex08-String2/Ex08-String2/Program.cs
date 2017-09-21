using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_String2
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
            string result = "";
            if (word.Length == 0)
            {
                return "";
            }
            if (word.Substring(word.Length - 1, 1) == "x")
            {
                result = "";
                return SwapXtoZero(word.Substring(0, word.Length - 1)) + result;
            }
            return SwapXtoZero(word.Substring(0, word.Length - 1)) + word.Substring(word.Length - 1, 1);
        }
    }
}
