using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    internal class Rectangle
    {
        public float width;
        public float height;

        public Rectangle(float width, float height)
        {
            this.width = width;
            this.height = height;

            Console.WriteLine("Rectangle Area : " + (width * height));
        }
    }
}
