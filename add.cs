using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Eg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for A and B");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("Sum of {0} and {1} is {2} i.e a = {0} , b = {1} ", a, b, c);
        }
    }
}
