using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Inheritence
{
    class Student : Person, ICloneable
    {
        protected string previousOrganization;
        protected int skippedDays;

        public Student()
        {
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }

        public Student(string name, int age, string gender, string previousOrganization) : base (name, age, gender)
        {
            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }

        public object Clone()
        {
            return new Student();
        }

        public new void GetGoal()
        {
            Console.WriteLine(string.Format("Be a junior software developer."));
        }

        public new void Introduce()
        {
            Console.WriteLine(string.Format(string.Format("Hi, I'm {0}, a {1} year old {2} from {3} who skipped {4} days of the course already.", name, age, gender, previousOrganization, skippedDays)));
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }
    }
}
