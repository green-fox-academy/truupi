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

        public Student(string name ="Juli", int age = 5, string gender = "male", string previousOrganization = "GFA") : base (name, age, gender)
        {
            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }

        public object Clone()
        {
            return new Student(name, age, gender, previousOrganization);
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
