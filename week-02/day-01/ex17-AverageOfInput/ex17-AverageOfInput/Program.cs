using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex17_AverageOfInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type here five different numbers in a row. Please separate them by pressing <Enter> between them:\n");
            Console.WriteLine(Avg(CreateArray()) + Sum(CreateArray()));
            Console.ReadLine();
        }

        static int[] CreateArray()
        {
            int[] userInputsArray = new int[5];
            for (int i = 0; i < userInputsArray.Length; i++)
            {
                userInputsArray[i] = int.Parse(Console.ReadLine());
            }
            return userInputsArray;
        }

        static int Avg(int[] input)
        {

            int result = ;
            return result;
        }

        static int Sum(int[] input)
        {
            int result = input.Average;
            return result;
        }
    }
}
