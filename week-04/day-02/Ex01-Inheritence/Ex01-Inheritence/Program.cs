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
            Student studentin = new Student("Janos", 22, "male", "Banki");

            Person studentin2 = (Student) studentin.Clone();
            studentin.SkipDays(10);
            studentin.Introduce();
            studentin2.Introduce();
            somebody.Introduce();

            Console.ReadLine();
        }
    }
}
