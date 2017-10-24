using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "xXXxXxxXoXoXXxxx";
            Console.WriteLine(SwapXtoY(word));
            Console.ReadLine();
        }

        static string SwapXtoY(string word)
        {
            string result = "";
            if (word.Length == 0)
            {
                return "";
            }
            if (word.Substring(word.Length - 1, 1) == "x")
            {
                result = "y";
                return SwapXtoY(word.Substring(0, word.Length - 1)) + result;
            }
            return SwapXtoY(word.Substring(0, word.Length - 1)) + word.Substring(word.Length - 1, 1);
        }
    }
}
