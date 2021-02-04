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
        public double BMIJohn;
        public double BMIMark;


        public BMI(string FullName, double Mass, double Height)
        {
            this.FullName = FullName;
            this.Mass = Mass;
            this.Height = Height;

        }

        public string CalculateBMIJohn()
        {
            double BMIJohn = Mass / (Math.Pow(Height, 2));
            return $"John :Your BMI is: {BMIJohn}";
        }

        public string CalculateBMIMark()
        {
            double BMIMark = Mass / (Math.Pow(Height, 2));
            return $"Mark :Your BMI is: {BMIMark}";
        }

        public string BMICom()
        {
            if (BMIMark > BMIJohn)
            {

                return $"Mark has higher BMI than John";

            }
            else if (BMIMark < BMIJohn)
            {
                return $"John has higher BMI than Mark";
            }

            else if (BMIMark == BMIJohn)
            {
                return $"John and Mark have the same BMI";
            }

            else
            {
                return "Error";
            }



        }
    }


 }

