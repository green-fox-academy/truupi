using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Person someone = new Person("Tamas Deak", 24, "male");
            Person somebody = new Person();
            Student studentin = new Student();

            studentin.GetGoal();
            studentin.Introduce();

            someone.Introduce();
            somebody.Introduce();

            Console.ReadLine();
        }
    }
}
