using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class RBI
    {
        public virtual double CalculateInterest(double p,  double n) {

            return (p * 2.2 * n) / 100;
                  
        }
    }
    class HDFC : RBI
    {
        public override double CalculateInterest(double p,  double n)
        {
            return (p*5.2*n)/100;
        }
    }
    class SBI : RBI
    {
        public override double CalculateInterest(double p, double n)
        {
            return (p * 8.2 * n) / 100;
        }
    }
    class ICIC : RBI
    {
        public override double CalculateInterest(double p, double n)
        {
            return (p * 7.2 * n) / 100;
        }
    }


}
