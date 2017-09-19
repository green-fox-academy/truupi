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
            string[] result = DecryptFile(path);
            foreach (var item in result)
            {
                File.WriteAllLines(pathto, result);
            }
        }

        private static string[] DecryptFile(string path)
        {
            string[] fileContent = { };
            List<string> decryptedText = new List<string>();
            try
            {
                fileContent = File.ReadAllLines(path);
            }
            catch (IOException)
            {
                Console.WriteLine("Read error");
            }

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

    }
}
