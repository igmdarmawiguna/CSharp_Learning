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
            int a = 23456;
            Console.WriteLine("{0}", a);
            Console.WriteLine("{0:N}", a);
            Console.WriteLine("{0:X}", a);
            Console.WriteLine("{0:C}", a);
            double v = 89.439918473;
            Console.WriteLine("{0:f2}", v);
        }
    }
}
