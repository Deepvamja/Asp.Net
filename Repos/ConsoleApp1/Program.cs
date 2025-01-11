using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PROGRAM 1

            //Console.WriteLine("name:deep vamja");
            //Console.WriteLine("Address: gurudev-park-2 street no:7");
            //Console.WriteLine("contact no : 6351656335");
            //Console.WriteLine("city: rajkot");

            //Console.WriteLine("HELLO WORLD");

            // program 2

            //Console.WriteLine("enter first number");
            //int number = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("enter second number");
            //int numbers = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(number);
            //Console.WriteLine(numbers);


            // program 3

            //Console.WriteLine("ENTER YOUR NAME");
            //String name = Console.ReadLine();

            //Console.WriteLine("enter your country");
            //String Country = Console.ReadLine();

            //Console.WriteLine(" Hello " + name + " from country " + Country);

            // PROGRAM 4
            //Console.WriteLine("ENTER LENGTH IN FEET");
            //int LENGTH = int.Parse(Console.ReadLine());

            //Console.WriteLine("ENTER WIDTH IN FEET");
            //int WIDTH = int.Parse(Console.ReadLine());

            //Console.WriteLine("area is : " +((LENGTH*LENGTH) + (WIDTH*WIDTH))  + " SQ.FEETS ");


            // PROGRAM 5
            //Console.WriteLine("enter 1 for square \n enter 2 for rectangle \n enter 3 for circle");
            //int n = int.Parse(Console.ReadLine());

            //switch (n)
            //{
            //    case 1:
            //        Console.WriteLine("Enter Length");
            //        int length = int.Parse(Console.ReadLine());
            //        Console.WriteLine("area of square is :" + (length * length));
            //        break;

            //    case 2:
            //        Console.WriteLine("enter height");
            //        int height = int.Parse(Console.ReadLine());
            //        Console.WriteLine("enter width");
            //        int width = int.Parse(Console.ReadLine());


            //        Console.WriteLine("area of rectangle is :" + ((height * width)));
            //        break;
            //    case 3:
            //        Console.WriteLine("enter radius");
            //        int radius = int.Parse(Console.ReadLine());

            //        Console.WriteLine("area of circle is :" + (3.14 * radius * radius));
            //        break;


            //    default:
            //        Console.WriteLine("ENTER VALID INPUT");
            //        break;


            //}

            // PROGRAM 6

            //Console.WriteLine("enter celsius");
            //double celsius = double.Parse(Console.ReadLine());
            //Console.WriteLine(fahrenheit(celsius));

            //Console.WriteLine("enter Fahrenheit");
            //double Fahrenheit = double.Parse(Console.ReadLine());
            //Console.WriteLine(Celsius(Fahrenheit));

            // program 7

            //Console.WriteLine("ENTER Principal");
            //int p = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter rate");
            //int r = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter time");
            //int t = int.Parse(Console.ReadLine());

            //Console.WriteLine("simple interest is :" + (p * r * t) / 100);

            // program 8

            //int a = 5;
            //int b = 10;

            //Console.WriteLine(a + b);
            //Console.WriteLine(a * b);       
            //Console.WriteLine(a - b);
            //Console.WriteLine(a/b);

            // program 9

            Console.WriteLine("enter first number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            int b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a is: " + a);
            Console.WriteLine("b is: " + b);

            // program 10





        }
        public static double fahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double Celsius(double Fahrenheit)
        {
            return (Fahrenheit - 32) * 5/9;
        }

        // PROGRAM 7

      




    }
}
