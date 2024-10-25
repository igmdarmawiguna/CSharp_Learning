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
                 for (int i = 1; i <= 16; i++)
                {
                    int d = r.Next(9);
                    Console.Write(d);
                    if (i % 4 == 0 && i < 16) Console.Write("-");
                }
            
        }
    }
}
