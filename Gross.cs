using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    internal interface Gross
    {
        void Gross_sal();
    }

    internal class Salary1 : Gross
    {
        public double HRA;
        public double TA;
        public double DA;
        public double Basic;

        public Salary1(double basic, double HRA, double TA, double DA)
        {
            this.Basic = basic;
            this.HRA = HRA;
            this.TA = TA;
            this.DA = DA;
        }
        public void Gross_sal() 
        {
            double grossSalary = Basic + HRA + TA + DA;
            Console.WriteLine($"Gross Salary: {grossSalary}");
        }

        public void Disp_sal()
        {
            Console.WriteLine($"Basic Salary: {Basic}");
            Console.WriteLine($"HRA: {HRA}");
            Console.WriteLine($"TA: {TA}");
            Console.WriteLine($"DA: {DA}");
        }
    }

    internal class Employee
    {
        public string Name;

        public Employee(string name)
        {
            this.Name = name;
        }

        public void Basic_sal(double basic)
        {
            Console.WriteLine($"Basic Salary for {Name}: {basic}");
        }
    }
}
