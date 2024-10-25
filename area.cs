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
            Console.WriteLine("Enter radius");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            Console.WriteLine("Area = {0}", area);
        }
    }
}
