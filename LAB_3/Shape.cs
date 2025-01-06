using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal interface Shape
    {
        double Circle(double radius);
        double Triangle(double baseLength, double height);
        double Square(double side);
    }

    public class ShapeCalculator : Shape
    {
        public double Circle(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double Triangle(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        public double Square(double side)
        {
            return side * side;
        }
    }
}
