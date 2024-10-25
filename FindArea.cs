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
            Console.WriteLine("Enter r1 and r2");
            double r1 = double.Parse(Console.ReadLine());
            double r2 = double.Parse(Console.ReadLine());
            if (r2 < r1)
            {
                double temp = r1;
                r1 = r2;
                r2 = temp;
            }

            for (double r = r1; r <= r2; r += 0.5)
            {
                double area = Math.PI * r * r;
                Console.WriteLine("Area of a circle {0:f2} for radius value {1}", area, r);
            }

        }
    }
}
