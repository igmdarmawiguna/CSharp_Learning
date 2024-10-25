using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication29
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 56, 89, 12, 6, 23, 2, 65, 2, 199, 2 };
            Array.Sort(a);

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != a[0])
                {
                    Console.WriteLine("Second smallest = {0}", a[i]);
                    break;
                }
            }

        }
    }
}
