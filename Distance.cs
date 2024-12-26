using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    internal class Distance
    {
        public int dist1;
        public int dist2;
        public int dist3;

        public Distance(int dist1, int dist2)
        {
            this.dist1 = dist1;
            this.dist2 = dist2;
        }

        public void CalculateDistance()
        {
            dist3 = dist1 + dist2;

            Console.WriteLine("Sum : " + dist3);
        }
    }
}
