using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    internal class Salary
    {
        public float Basic;
        public float TA;
        public float DA;
        public float HRA;

        public Salary(float Basic, float TA, float DA = 10.0f, float HRA = 15.0f)
        {
            this.Basic = Basic;
            this.TA = TA;
            this.DA = DA;
            this.HRA = HRA;
        }

        public float CalculateSalary()
        {
            float daAmount = (Basic * DA) / 100;
            float hraAmount = (Basic * HRA) / 100;
            return Basic + TA + daAmount + hraAmount;
        }

        public void DisplaySalaryDetails()
        {
            Console.WriteLine("\nSalary Details:");
            Console.WriteLine("Basic: " + Basic);
            Console.WriteLine("TA: " + TA);
            Console.WriteLine("DA (10% of Basic): " + (Basic * DA) / 100);
            Console.WriteLine("HRA (15% of Basic): " + (Basic * HRA) / 100);
            Console.WriteLine("Total Salary: " + CalculateSalary());
        }
    }
}
