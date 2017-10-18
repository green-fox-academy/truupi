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
        private static int[] numberArray2 = new[] { 3, 9, 2, 8, 6, 5 };


        static void Main(string[] args)
        {
            foreach (var n in SquaredIsMore(numberArray2))
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }

        private static double AvgOfOddNumbers(int[] numberArray)
        {
            var AvgOddNumbers = from number in numberArray
                                where number % 2 != 0
                                select number;
            AvgOddNumbers.Average();

            return numberArray.Where(number => number % 2 != 0).Average();
        }

        private static IEnumerable<int> EvenNumbers(int[] numberArray)
        {
            IEnumerable<int> evenNumsWithLambda = numberArray.Where(number => number % 2 == 0);
            IEnumerable<int> evenNumsWithQuery = 
                from number in numberArray
                where number % 2 == 0
                select number;

            return evenNumsWithQuery;
        }

        private static IEnumerable<int> SquareOfEvenNumbers(int[] numberArray)
        {
            IEnumerable<int> squareOfEvenNumsWithLambda = numberArray.Where(number => number > 0).Select(number => number * number);
            IEnumerable<int> squareOfEvenNumsWithQuery = 
                from number in numberArray
                where number > 0
                select number * number;

            return squareOfEvenNumsWithLambda;
        }

        private static IEnumerable<double> SquaredIsMore(int[] numberArray2)
        {
            return numberArray2.Select(number => number * number).Where(number => number > 20).Select(number => Math.Sqrt(number));
        }
    }
}
