using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Announcer();
            Response(IsAnagram(userInput(), userInput()));
            Console.ReadLine();
        }

        static void Announcer()
        {
            Console.WriteLine("Please type two words here two check whether they are anagrams or not:\n");
        }

        static string userInput()
        {
            string string1 = Console.ReadLine();
            return string1;
        }

        static bool IsAnagram(string input1, string input2)
        {
            bool isitanagram = true;
            char[] char1 = SortArray(ConvertString(input1));
            char[] char2 = SortArray(ConvertString(input2));

            for (int i = 0; i < char1.Length; i++)
            {
                if (char1[i] != char2[i])
                {
                    isitanagram = false;
                    break;
                }
            }
            return isitanagram;
        }

        static char[] ConvertString(string input1)
        {
            char[] char1 = input1.ToCharArray();
            return char1;
        }

        static char[] SortArray(char[] input1)
        {
            Array.Sort(input1);
            return input1;
        }

        static void Response (bool input1)
        {
            if (input1)
            {
                Console.WriteLine("It is an anagram!");
            }
            else Console.WriteLine("Not an anagram!");
        }
    }
}
