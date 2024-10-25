using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication36
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = readProperInteger();
            int b = readProperInteger();
            Console.WriteLine("{0} , {1}", a, b);
        }

        static int readProperInteger()
        {
            int a = 0;
            bool flag = true;
            while ( flag )
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    flag = false;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Only numbers");
                    flag = true;
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Out of range");
                    flag = true;
                }
            }
            return a;
        }
    }
}
