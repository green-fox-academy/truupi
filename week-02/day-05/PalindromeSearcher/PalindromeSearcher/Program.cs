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
            string result = userInput();
            bool isplaindrome = IsPalindrome(result);
            if (isplaindrome)
            {
                Listcreator(result);
            }
            else Console.WriteLine("Not an palindrome!");
            Console.ReadLine();
        }

        static string userInput()
        {
            string result = Console.ReadLine();
            return result;
        }
        
        static List<string> Listcreator(string input1)
        {
            var PalindromeList = new List<string>();
            for (int i = 0; i < 1; i++)
            {
                PalindromeList.Add(input1);
            }
            return PalindromeList;
        }

        static bool IsPalindrome(string input1)
        {
            bool result = input1 == new string(input1.Reverse().ToArray()) && input1.Length >= 3;
            return result;
            
        }
    }
}
