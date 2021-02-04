using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            BMI  Mark = new BMI("Mark Kristofer", 152, 95);
            BMI  John = new BMI("John Robert", 192, 50);

            Console.WriteLine(John.FullName);
            Console.WriteLine(John.Mass);
            Console.WriteLine(John.Height);

            Console.WriteLine("****************************************************");
            Console.WriteLine(Mark.FullName);
            Console.WriteLine(Mark.Mass);
            Console.WriteLine(Mark.Height);

            Console.WriteLine("****************************************************");


            Console.WriteLine(John.CalculateBMIJohn());
            Console.WriteLine(Mark.CalculateBMIMark());
            Console.WriteLine(John.BMICom());
            Console.WriteLine(Mark.BMICom());


            
        }
    }
}
