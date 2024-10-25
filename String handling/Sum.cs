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
            Console.WriteLine("Enter numbers ");
            string s = Console.ReadLine();
            string [ ] v = s.Split(',');

            int sum = 0;
            for (int i = 0; i < v.Length; i++)
                sum += int.Parse(v[i]);

            Console.WriteLine("Sum of numbers = {0}", sum);
       }
    }
}
