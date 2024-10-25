using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter mobile number");
            string mobile = Console.ReadLine();
            if (mobile.Length == 10)
            {
                string provider = mobile.Substring(0, 4);
                if (provider.Equals("9845"))
                    Console.WriteLine("Airtel");
                else if (provider.Equals("9342"))
                    Console.WriteLine("Reliance");
                else
                    Console.WriteLine("Some other provider");

            }
            else
                Console.WriteLine("Invalid mobile number");
        }
    }
}
