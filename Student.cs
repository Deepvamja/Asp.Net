using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    internal class Student
    {
        public long Enrollment_No;
        public string Student_Name;
        public int Semester;
        public float CPI;
        public float SPI;

        public Student()
        {
            Console.Write("Enter Enrollment No. : ");
            Enrollment_No = long.Parse(Console.ReadLine());

            Console.Write("Enter Student Name : ");
            Student_Name = Console.ReadLine();

            Console.Write("Enter Semester : ");
            Semester = int.Parse(Console.ReadLine());

            Console.Write("Enter CPI : ");
            CPI = float.Parse(Console.ReadLine());

            Console.Write("Enter SPI : ");
            SPI = float.Parse(Console.ReadLine());
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("\n\nStudent Details :-> ");

            Console.WriteLine("\nEnrollment No. : " + Enrollment_No);
            Console.WriteLine("Name : " + Student_Name);
            Console.WriteLine("Semester : " + Semester);
            Console.WriteLine("CPI : " + CPI);
            Console.WriteLine("SPI : " + SPI);
        }
    }
}
