using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CopyFIle
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Lenovo\Documents\Greenie\greenfox\truupi\week-03\day-02\encoded-lines.txt";
            string pathto = @"C:\Users\Lenovo\Documents\Greenie\greenfox\truupi\week-03\day-02\CopyFIle\CopyFIle\encoded-lines.txt";
            try
            {
                if (ReaderWriter(path, pathto))
                {
                    Console.WriteLine("Successful copy!");
                }
            }
            catch
            {
                Console.WriteLine("Cannot create new file!");
            }
            finally
            {
                Console.ReadLine();
            }
        }

        static bool ReaderWriter(string path, string pathto)
        {
            bool complete = true;
            string result = File.ReadAllText(path);
            File.WriteAllText(pathto, result);
            return complete;
        }
    }
}
