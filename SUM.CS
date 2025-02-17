using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal abstract class SUM
    {

        public abstract int SumofTwo(int a, int b);

        public abstract int SumofThree(int a, int b,int c);
   
    }
    internal  class Calculate : SUM
    {
        public override int SumofTwo(int a, int b)
        {
            return (a + b);
        }
        public override int SumofThree(int a, int b,int c)
        {
            return (a + b + c);
        }
    }
}
