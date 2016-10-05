using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance10
{
    class Person
    {
        private string eyeColor;
        private int age;

        public string EyeColor {
            get { return this.eyeColor; }
            set { this.eyeColor = value; }
        }
        public int Age
        {
            get { return age; }
            set { this.age = value; }
        }

        public Person()
        {

        }

        public void PrintDetails()
        {
            Console.WriteLine("This person's age is " + age + " " + " and their eye color is " + eyeColor);
        }
    }
}
