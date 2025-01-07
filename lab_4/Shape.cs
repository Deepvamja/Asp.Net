using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Shape
    {
        public int area(int x)
        {
            return (x * x);
        }
        public int area(int x,int y)
        {
            return (x * y);
        }
        public double area(double a)
        {
            return Math.PI *a *a;
        }
    }
}
