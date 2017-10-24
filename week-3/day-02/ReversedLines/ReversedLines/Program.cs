using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReversedLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Lenovo\Documents\Greenie\greenfox\truupi\week-03\day-02\reversed-lines.txt";
            string pathto = @"C:\Users\Lenovo\Documents\Greenie\greenfox\truupi\week-03\day-02\ReversedLines\ReversedLines\reversed-lines-decoded.txt";
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
                string decryptedLine = Reverse(line);
                decryptedText.Add(decryptedLine);
            }
            return decryptedText.ToArray<string>();
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
