using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {



        static void Main(string[] args)
        {

            double miles;
            double kilogram;
            double gallons;
            // program 1

            Console.WriteLine("enter 1 for kilometer to miles \n  enter 2 for pounds to kilogram \n  enter 3 for liters to gallons");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {

                case 1:
                    Console.WriteLine("enter the kilometer");
                    double kilometer = double.Parse(Console.ReadLine());
                    Console.WriteLine(miles = kilometer * 0.621371);
                    break;

                case 2:
                    Console.WriteLine("enter the pounds");
                    double pounds = double.Parse(Console.ReadLine());
                    Console.WriteLine(kilogram = pounds * 0.453592);
                    break;

                case 3:
                    Console.WriteLine("enters the liters");
                    double liters = double.Parse(Console.ReadLine());
                    Console.WriteLine(gallons = liters * 0.264172);
                    break;

            }

            // program 4
            employee ee = new employee();
            ee.GetemployeeDetails();
            ee.DisplayemployeeDetails();

            // program 3

            calculator aa = new calculator();
            Console.WriteLine(aa.Multiply(1, 2));
            Console.WriteLine(aa.Multiply(1.2, 2.2));
            Console.WriteLine(aa.Multiply(1.3f, 2.4f));


            // program 2 

            Console.WriteLine("enter the string 1");
            string str1 = Console.ReadLine();

            Console.WriteLine("enter the string 2");
            string str2 = Console.ReadLine();


            try
            {
                Console.WriteLine("compare  : " + (str1).Equals(str2));
                Console.WriteLine("concat : " + (str1).Concat(str2));
                Console.WriteLine("upper case : " + str1.ToUpper());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
          


        }


    }
}
