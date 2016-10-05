using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance10
{
    class Program
    {
        static void Main(string[] args)
        {
            Person brad = new Person();


            Console.WriteLine("How old are you?");
            brad.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("What color are your eyes?");
            brad.EyeColor  = Console.ReadLine();

            brad.PrintDetails();

            

       
        }
    }
}
