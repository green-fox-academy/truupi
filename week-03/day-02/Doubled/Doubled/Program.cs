using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Lenovo\Documents\Greenie\greenfox\truupi\week-03\day-02\duplicated-chars.txt";
            string pathto = @"C:\Users\Lenovo\Documents\Greenie\greenfox\truupi\week-03\day-02\Doubled\Doubled\duplicated-chars-decoded.txt";
            string income = File.ReadAllText(path);
            
            foreach (var line in RemoveDuplicateChars(path))
            {
                File.WriteAllText(pathto, line);
            }

        }

        static string[] RemoveDuplicateChars(string path)
        {
            string[] fileContent = { };
            List<string> decryptedText = new List<string>();

            foreach (string line in fileContent)
            {
                string decryptedLine = "";
                for (int i = 0; i < line.Length; i += 2)
                {
                    decryptedLine += line[i];
                }
                decryptedText.Add(decryptedLine);
            }
            return decryptedText.ToArray<string>();
        }

        //static string RemoveDuplicateChars(string[] input)
        //{
        //    string[] result;
        //    for (int i = 0; i < input.Length; i += 2)
        //    {
        //        for (int j = 1; j < input[i].Length; j += 2)
        //        {
        //            result += input[i][j];
        //        }
        //    }

        //    result   = String.Join(" ");
        //    return result;
        //}
    }
}
