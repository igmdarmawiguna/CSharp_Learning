using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpeechLib;
namespace ConsoleApplication30
{
    class Bank
    {
        private int amount;
        public void Deposit(int amt)
        {
            amount += amt;
        }
        public void Withdraw(int amt)
        {
            if (amount - amt < 0)
                Console.WriteLine("Not enough cash");
            else
                amount -= amt;
        }
        public override string  ToString()
        {
            return string.Format("Your balance amount = {0}", amount);
        }
    }
     
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter customer count ");
            int N = int.Parse(Console.ReadLine());
            Bank[ ] c = new Bank[N];
            for (int i = 0; i < N; i++)
                c[i] = new Bank();
            while (true)
            {
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Balance");
                Console.WriteLine("4. Exit");
                int choice = int.Parse(Console.ReadLine());
                int accno, amount;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter account and amount");
                        accno = int.Parse(Console.ReadLine());
                        amount = int.Parse(Console.ReadLine());
                        c[accno].Deposit(amount);
                        break;
                    case 2:
                        Console.WriteLine("Enter account and amount");
                        accno = int.Parse(Console.ReadLine());
                        amount = int.Parse(Console.ReadLine());
                        c[accno].Withdraw(amount);
                        break;
                    case 3:
                        Console.WriteLine("Enter account");
                        accno = int.Parse(Console.ReadLine());
                        Console.WriteLine(c[accno]);
                        break;
                    case 4:
                        return;
                }
            }
        }
    }
}
