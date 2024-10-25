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
            Console.WriteLine("Enter array size");
            int max = int.Parse(Console.ReadLine());
            int[ ] a = new int[max];
            Console.WriteLine("Enter values into array");
            for (int i = 0; i < a.Length; i++)
                a[i] = int.Parse(Console.ReadLine());

            Array.Sort(a);     // arrange elements into ascending order
                                        //  For descending order  :  Array.Reverse(a);
            Console.WriteLine("Resultant array");
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i]);

            Console.WriteLine("Enter element to search = ");
            int x = int.Parse(Console.ReadLine());

            int p = Array.BinarySearch(a, x);
            if (p < 0)
                Console.WriteLine("Element not found");
            else
                Console.WriteLine("Found at the position = {0}", p);
        }
    }
}
