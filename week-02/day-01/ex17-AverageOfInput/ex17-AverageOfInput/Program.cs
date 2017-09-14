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
            int[] userInputsArray = CreateArray();
            Console.WriteLine("\nThe average of your numbers: " + Avg(userInputsArray) + "\nThe sum of your numbers: " + Sum(userInputsArray));
            Console.ReadLine();
        }

        static int[] CreateArray()
        {
            int[] userInputsArray = new int[5];
            for (int i = 0; i < userInputsArray.Length; i++)
            {   
                userInputsArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            return userInputsArray;
        }

        static int Avg(int[] input)
        {
            int sum = 0;
            foreach (int num in input)
            {
                sum += num;
            }
            int result = sum / input.Length;
            return result;
        }

        static int Sum(int[] input)
        {
            int sum = 0;
            foreach (int num in input)
            {
                sum += num;
            }
            int result = sum;
            return result;
        }
    }
}
