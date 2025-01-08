using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class employee
    {

        // program 2



        public int ID;
        public string Name;
        public string position;

        public void GetemployeeDetails()
        {
            Console.Write("Enter employee ID : ");
            ID = int.Parse(Console.ReadLine());

            Console.Write("Enter employee Name : ");
            Name = Console.ReadLine();

            Console.Write("Enter employee position : ");
            position =(Console.ReadLine());

            
        }

        public void DisplayemployeeDetails()
        {
            Console.WriteLine("\n\nemployee Details :->\n");

            Console.WriteLine("ID : " + ID);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("position:" + position);
           
        }
    }
}
