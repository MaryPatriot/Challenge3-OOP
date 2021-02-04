using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3_OOP
{
    class BMI
    {
        public string FullName;
        public double Mass;
        public double Height;
        


        public BMI(string FullName, double Mass, double Height)
        {
            this.FullName = FullName;
            this.Mass = Mass;
            this.Height = Height;

        }

        public double CalculateBMI()
        {
            double BMICal = Mass / (Math.Pow(Height, 2));
            return BMICal;
        }

        public  static void  BMICom(double A, double B)
        {
            if (A > B)
            {
                Console.WriteLine("John BMI is higher than Mark BMI");
            }
            else if (A < B)
            {
                Console.WriteLine("Mark BMI is higher than John BMI");
            }
            else if (A == B)
            {
                Console.WriteLine("Mark BMI is the same as John BMI");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }






















    }


 }

