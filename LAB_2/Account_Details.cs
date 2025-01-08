using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    internal class Account_Details
    {
        public string AccountHolderName;
        public int AccountNumber;
        public float Balance;

        public void GetAccountDetails()
        {
            Console.Write("Enter Account Number: ");
            AccountNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Account Holder Name: ");
            AccountHolderName = Console.ReadLine();

            Console.Write("Enter Balance: ");
            Balance = float.Parse(Console.ReadLine());
        }
    }


    internal class Interest : Account_Details
    {
        public float InterestRate;

        public void GetInterest()
        {
            Console.Write("\nEnter Interest Rate (in %): ");
            InterestRate = float.Parse(Console.ReadLine());

            double interest = (Balance * InterestRate) / 100;
            double totalAmount = Balance + interest;

            Console.WriteLine("\nInterest Amount: " + interest);
            Console.WriteLine("Total Balance: " + totalAmount);
        }
    }
}
