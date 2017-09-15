using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isplaindrome = IsPalindrome(userInput());
            if (isplaindrome)
            {
                
            }
        }

        static string userInput()
        {
            string result = Console.ReadLine();
            return result;
        }

        //static list[] palindromesearcher(string input1)
        //{

        //}

        //static void listcreator()
        //{

        //}

        static bool IsPalindrome(string input1)
        {
            bool result = false;
            result = input1 == new string(input1.Reverse().ToArray()) && input1.Length >= 3;
            return result;
        }
    }
}
