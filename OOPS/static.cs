using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication31
{
    class Bank
    {
        private int amount;
        private static int count;
        private static int tcash;
        public Bank()
        {
            count++;    // increment customers count 
        }
        public void Deposit(int amt)
        {
            tcash += amt;
            amount += amt;
        }
        public void Withdraw(int amt)
        {
            if (amount - amt < 0)
                Console.WriteLine("Not enough cash");
            else
            {
                amount -= amt;
                tcash = tcash - amt;
            }
        }
        public override string ToString()
        {
            return string.Format("Your balance amount = {0}", amount);
        }
        public static void Report()
        {
            Console.WriteLine("Count of customers = {0}", count);
            Console.WriteLine("Total cash balance = {0}", tcash);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bank c1 = new Bank();
            Bank c2 = new Bank();
            c1.Deposit(2000);
            c2.Deposit(3000);

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Bank.Report();
        }
    }
}
