using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Announcer();
            Console.WriteLine(Converter(userInput()));
            Console.ReadLine();
        }

        static void Announcer()
        {
            Console.WriteLine("Please type two words here two create a palindrome:\n");
        }

        static string userInput()
        {
            string string1 = Console.ReadLine();
            return string1;
        }

        static string Converter(string input1)
        {
            string palindrome = input1 + ArraySort(CharToArray(input1));
            return palindrome;
        }

        static char[] CharToArray(string input1)
        {
            char[] char1 = input1.ToCharArray();
            return char1;
        }

        static string ArraySort(char[] input1)
        {
            Array.Reverse(input1);
            string result = new string(input1);
            return result;
        }
    }
}
