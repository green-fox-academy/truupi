using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            IEnumerable<int> evenNumsWithLambda = numberArray.Where(number => number % 2 == 0);
            IEnumerable<int> evenNumsQuery =
                from number in numberArray
                where number % 2 == 0
                select number;

            foreach (var number in evenNumsQuery)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
