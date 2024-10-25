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
            Console.WriteLine("Enter hour , min and secs");
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            ++s;
            if (s == 60)
            {
                s = 0;
                m++;
            }
            if (m == 60)
            {
                s = m = 0;
                ++h;
            }
            if (h == 24)
            {
                h = m = s = 0;
            }
            Console.WriteLine("{0}:{1}:{2}", h, m, s);


        }
    }
}
