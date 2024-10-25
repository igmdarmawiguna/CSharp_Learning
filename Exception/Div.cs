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
            try
            {
                Console.WriteLine("Enter 2 numbers");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                double c = a / b;
                Console.WriteLine("Result = {0}", c);
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("Please input data b/w {0} to {1}", int.MinValue, int.MaxValue);
            }
            catch (System.DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero , try diff numbers");
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Only numbers are allowed");
            }
            Console.WriteLine("Further part of the code.....");

        }
    }
}
