using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    internal class Candidate
    {
        public int ID;
        public string Name;
        public int Age;
        public float Weight;
        public float Height;

        public void GetCandidateDetails()
        {
            Console.Write("Enter Candidate ID : ");
            ID = int.Parse(Console.ReadLine());

            Console.Write("Enter Candidate Name : ");
            Name = Console.ReadLine();

            Console.Write("Enter Candidate Age : ");
            Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Candidate Weight : ");
            Weight = float.Parse(Console.ReadLine());

            Console.Write("Enter Candidate Height : ");
            Height = float.Parse(Console.ReadLine());
        }

        public void DisplayCandidateDetails()
        {
            Console.WriteLine("\n\nCandidate Details :->\n");

            Console.WriteLine("ID : " + ID);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Weight : " + Weight + "kg");
            Console.WriteLine("Height : " + Height + "cm");
        }
    }
}
