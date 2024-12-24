using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Candidate c = new Candidate();

            //c.GetCandidateDetails();
            //c.DisplayCandidateDetails();



            //Staff[] s = new Staff[5];

            //for (int i = 0; i < s.Length; i++)
            //{
            //    s[i] = new Staff();
            //    s[i].GetDetails();
            //}

            //Console.WriteLine("\nName & Salary Of HOD's :-> ");

            //for (int i = 0; i < s.Length; i++) 
            //{ 
            //    if (s[i].Designation == "HOD")
            //    {
            //        s[i].DisplayDetails();
            //    }
            //}


            //Bank_Account account = new Bank_Account();

            //account.GetAccountDetails();
            //account.DisplayAccountDetails();



            //Student student = new Student();

            //student.DisplayStudentDetails();



            //Rectangle r = new Rectangle(2, 5);




            //Interest account = new Interest();

            //account.GetAccountDetails();

            //account.GetInterest();



            //Console.Write("Enter Basic Salary : ");
            //float Basic = float.Parse(Console.ReadLine());

            //Console.Write("Enter TA Salary : ");
            //float TA = float.Parse(Console.ReadLine());

            //Salary employeeSalary = new Salary(Basic, TA);

            //employeeSalary.DisplaySalaryDetails();




            //Distance d = new Distance(2,5);

            //d.CalculateDistance();



            //Table t = new Table("Wood",299.99,1.2,2.5);

            //t.DisplayTableDetails();




            Employee e = new Employee("Nikunj Rathod");

            e.Basic_sal(30000);


            Salary1 s = new Salary1(30000,5000,2000,3000);

            s.Disp_sal();
            s.Gross_sal();
        }
    }
}
