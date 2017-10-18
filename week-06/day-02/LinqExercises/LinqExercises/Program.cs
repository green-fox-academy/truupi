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
        private static int[] numberArray2 = { 3, 9, 2, 8, 6, 5 };
        private static int[] input = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
        private static string[] cities = { "ROME", "LONDON", "AKI", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
        private static char[] exampleArray = { 'm', 'a', 'l', 'a', 'c', 'k', 'a' };

        static void Main(string[] args)
        {
            foreach (var n in ConverterToString(exampleArray))
            {
                Console.Write(n);
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

        private static IEnumerable<int> SquaredIsMore(int[] numberArray2)
        {
            var squaredIs20 = from number in numberArray2
                              where number * number > 20
                              select number;

            return numberArray2.Where(number => number * number > 20);
        }

        private static Dictionary<int, int> FrequencyOfNumbers(int[] numberArray3)
        {
            var freqNums = from number in numberArray3
                           group number by number into uniqueNumbers
                           select new
                           {
                               uniqueNumbers.Key,
                               Count = (from number in uniqueNumbers select number).Count()
                           };

            return numberArray3.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
        }

        public static Dictionary<char, int> FreqOfChars(string input)
        {
            var freqNums = from character in input.ToLower().Replace(" ", "")
                           group character by character into uniqueChars
                           select new
                           {
                               uniqueChars.Key,
                               Count = (from number in uniqueChars select number).Count()
                           };

            return input.ToLower().Replace(" ", "").GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
        }

        public static IEnumerable<string> CitySelection(string[] cityArray)
        {
            var selectedCities = from city in cityArray
                                 where city.StartsWith("A") && city.EndsWith("I")
                                 orderby city ascending
                                 select city;

            return cityArray.Where(city => city.First() == 'A' && city.Last() == 'I').OrderBy(city => city);
        }

        public static IEnumerable<char> UpperCaseSelector(string input)
        {
            var selectedChars = from character in input
                                where char.IsUpper(character)
                                select character;

            return input.Where(character => char.IsUpper(character));
        }

        public static string ConverterToString(char[] inputArray)
        {
            return String.Join("", inputArray.Select(x => x));
        }
    }
}
