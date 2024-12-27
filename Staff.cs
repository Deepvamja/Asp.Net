using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    internal class Staff
    {
        public string Name;
        public string Department;
        public string Designation;
        public int Experience;
        public int Salary;

        public void GetDetails()
        {
            Console.Write("\nEnter Name : ");
            Name = Console.ReadLine();

            Console.Write("Enter Department : ");
            Department = Console.ReadLine();

            Console.Write("Enter Designation : ");
            Designation = Console.ReadLine();

            Console.Write("Enter Experience : ");
            Experience = int.Parse(Console.ReadLine());

            Console.Write("Enter Salary : ");
            Salary = int.Parse(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\nStaff Name : " + Name);
            Console.WriteLine("Staff Salary : " + Salary + " \n");
        }
    }
}
