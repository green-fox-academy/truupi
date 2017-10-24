using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03_appenda
{
    class Program
    {
        static void Main(string[] args)
        {
            string am = "kuty";
            string result = appendA(am);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static string appendA(string in1)
        {
            string result = in1 + "a";
            return result;
        }
    }

}
