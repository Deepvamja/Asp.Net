using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Student
    {
        public int Enrollment_no;
        public String Student_Name;
        public int Semester;
        public float CPI;
        public float SPI;


        public void GetStudentDetails()
        {
            Console.WriteLine("enter Enrollment no:");
            Enrollment_no = int.Parse(Console.ReadLine());

            Console.WriteLine("enter Student_Name:");
            Student_Name = Console.ReadLine();

            Console.WriteLine("enter Semester:");
            Semester = int.Parse(Console.ReadLine());

            Console.WriteLine("enter CPI");
            CPI = float.Parse(Console.ReadLine());

            Console.WriteLine("enter SPI");
            SPI = float.Parse(Console.ReadLine());
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("student:"+Enrollment_no);
            Console.WriteLine("student:" + Student_Name);
            Console.WriteLine("student:"+Semester); 
            Console.WriteLine("student:"+CPI);
            Console.WriteLine("student:"+SPI);
        }
    }
}
