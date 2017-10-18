using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercises
{
    class Program
    {
        private static int[] numberArray = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

        static void Main(string[] args)
        {

        }

        private static double AvgOfOddNumbers(int[] numberArray)
        {
            return numberArray.Where(number => number % 2 != 0).Average();
        }

        private static IEnumerable<int> EvenNumbers(int[] numberArray)
        {
            IEnumerable<int> evenNumsWithLambda = numberArray.Where(number => number % 2 == 0);
            IEnumerable<int> evenNumsQuery = from number in numberArray
                                             where number % 2 == 0
                                             select number;

            return evenNumsQuery;
        }
    }
}
