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
            Random r = new Random();
            int x = r.Next(100);
            int y = r.Next(100);

            Console.WriteLine(" ( {0} , {1} )", x, y);
        }
    }
}
