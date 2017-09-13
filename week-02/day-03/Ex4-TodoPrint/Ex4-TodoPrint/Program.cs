using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_TodoPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Adder());
            Console.ReadLine();
        }

        static string Adder()
        {
            var todoText = new StringBuilder(" - Buy milk\n");
            todoText.Insert(0, "My todo:\n");
            int k = todoText.Length;
            todoText.Insert(k, " - Download games\n");
            string j = "".PadLeft(4);
            int l = todoText.Length;
            todoText.Insert(l, j + "-Diablo");
            return todoText.ToString();
        }
    }
}
