using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program 1

            //int n1 = 0;
            //int n2 = 0;
            //int ans = 0;

            //try
            //{
            //    ans = n1 / n2;
            //    Console.WriteLine(ans);
            //}
            //catch (Exception ex) 
            //{ 
            //    Console.WriteLine(ex.Message);
            //}



            //Program 2


            //int[] arr = new int[5];

            //try
            //{
            //    for (int i = 0; i <= arr.Length; i++)
            //    {
            //        Console.Write("Enter Number At Arr[" + i + "] : ");
            //        arr[i] = int.Parse(Console.ReadLine());
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}



            //Program 3

            //Calculate1 c = new Calculate1();

            //Console.Write("Ans Of Three : " + c.SumOfThree(2, 5, 4));
            //Console.Write("\nAns Of Two : " + c.SumOfTwo(2,5));



            //Program 4

            //Result r = new Result();

            //Console.Write("Addition : " + r.Addition(2, 3));
            //Console.Write("\nSubtraction : " + r.Subtraction(4,1));



            //Program 5

            //String str = "  Hello World From You!!!  ";

            //Console.WriteLine("Lower Case : " + str.ToLower());
            //Console.WriteLine("Upper Case : " + str.ToUpper());
            //Console.WriteLine("SubString : " + str.Substring(2,8));
            //Console.WriteLine("Trim : " + str.Trim());



            //Program 6

            //Console.Write("Enter String : ");
            //String str = Console.ReadLine();

            //char[] ch = str.ToCharArray();

            //for (int i = 0; i < ch.Length; i++)
            //{
            //    char temp = ch[i];

            //    if (temp >= 'A' && temp <= 'Z')
            //    {
            //        ch[i] = (char)((int)temp + 32);
            //    }
            //    else if(temp >= 'a' && temp <='z')
            //    {
            //        ch[i] = (char)((int)temp - 32);
            //    }
            //}

            //for (int i = 0; i < ch.Length; i++)
            //{
            //    Console.Write(ch[i]);
            //}




            //Program 7


            public interface IShape
        {
            double Circle(double radius);
            double Triangle(double baseLength, double height);
            double Square(double side);
        }

        // Implement the Shape interface
        public class ShapeImplementation : IShape
        {
            // Calculate the area of a circle
            public double Circle(double radius)
            {
                return Math.PI * radius * radius;
            }

            // Calculate the area of a triangle
            public double Triangle(double baseLength, double height)
            {
                return 0.5 * baseLength * height;
            }

            // Calculate the area of a square
            public double Square(double side)
            {
                return side * side;
            }
        }

            IShape shape = new ShapeImplementation();

            // Example usage
            Console.WriteLine("Area of Circle (radius = 5): " + shape.Circle(5));
            Console.WriteLine("Area of Triangle (base = 10, height = 8): " + shape.Triangle(10, 8));
            Console.WriteLine("Area of Square (side = 4): " + shape.Square(4));

            //ShapeCalculator calculator = new ShapeCalculator();

            //Console.Write("Enter Radius Of Circle: ");
            //double radius = double.Parse(Console.ReadLine());
            //Console.WriteLine("\nArea of Circle: " + calculator.Circle(radius));


            //Console.Write("\nEnter Base Of Triangle: ");
            //double baseLength = double.Parse(Console.ReadLine());

            //Console.Write("Enter Height Of Triangle: ");
            //double height = double.Parse(Console.ReadLine());
            //Console.WriteLine("\nArea of Triangle: " + calculator.Triangle(baseLength, height));


            //Console.Write("\nEnter Side Of Square: ");
            //double side = double.Parse(Console.ReadLine());
            //Console.WriteLine("\nArea of Square: " + calculator.Square(side));




            //Program 8

            //Console.Write("Enter Number : ");
            //int n = int.Parse(Console.ReadLine());

            //try
            //{
            //    if (n % 2 != 0)
            //    {
            //        throw new Exception("Number Is Not Even");
            //    }
            //    Console.WriteLine("Number Is Even.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Exception: {ex.Message}");
            //}



            //Program 9

            //Console.Write("Enter String : ");
            //string str = Console.ReadLine();

            //string longestWord = FindLongestWord(str);
            //Console.WriteLine("Input String : " + str);
            //Console.WriteLine("Longest Word : " + longestWord);

            static string FindLongestWord(String str)
            {
                if (string.IsNullOrEmpty(str))
                    return string.Empty;

                string[] words = str.Split(' ');
                string longest = "";

                foreach (string word in words)
                {
                    if (word.Length > longest.Length)
                    {
                        longest = word;
                    }
                }

                return longest;
            }




            //Program 10

            Console.Write("Enter Character : ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.IsLetter(ch))
            {
                char changedCaseChar = char.IsUpper(ch) ? char.ToLower(ch) : char.ToUpper(ch);
                Console.WriteLine($"The changed case character is: {changedCaseChar}");
            }
            else
            {
                Console.WriteLine("The entered character is not a letter.");
            }
        }

        
    }
}
