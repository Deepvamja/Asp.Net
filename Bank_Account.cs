using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    internal class Bank_Account
    {
        public int Account_No;
        public string Email;
        public string User_Name;
        public string Account_Type;
        public int Account_Balance;

        public void GetAccountDetails()
        {
            Console.Write("Enter Account No. : ");
            Account_No = int.Parse(Console.ReadLine());

            Console.Write("Enter Email : ");
            Email = Console.ReadLine();

            Console.Write("Enter Account Holder Name : ");
            User_Name = Console.ReadLine();

            Console.Write("Enter Account Type : ");
            Account_Type = Console.ReadLine();

            Console.Write("Enter Balance : ");
            Account_Balance = int.Parse(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("\nAccount Details :-> ");
            
            Console.WriteLine("\nAccount No. : " + Account_No);
            Console.WriteLine("Account Holder Name : " + User_Name);
            Console.WriteLine("Account Type : " + Account_Type);
            Console.WriteLine("User Email : " + Email);
            Console.WriteLine("Account Balance : " + Account_Balance);
        }
    }
}
