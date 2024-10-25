using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication33
{

    class Program
    {
        static int sum(params int[  ] args)
        {
            int s = 0;
            for (int i = 0; i < args.Length; i++)
                s = s + args[i];

            return s;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sum of 2 numbers = {0}", sum(10, 20));
            Console.WriteLine("Sum of 3 numbers = {0}", sum(10, 20, 30));
            Console.WriteLine("Sum of 4 numbers = {0}", sum(10, 20, 30 , 40));
        }
    }
}
