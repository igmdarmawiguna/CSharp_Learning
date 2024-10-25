using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication32
{
    class Util
    {
        public static int cube(int n)
        {
            return n * n * n;
        }
        public static int lar(int a, int b)
        {
            return a > b ? a : b;
        }
        public static void showDateTime()
        {
            Console.WriteLine(DateTime.Now.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Util.cube(5));
            Console.WriteLine(Util.lar(10, 20));
            Util.showDateTime();
        }
    }
}
