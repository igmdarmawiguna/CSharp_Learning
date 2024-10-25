using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ConsoleApplication35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter filename");
            string filename = Console.ReadLine();
            File.Delete(filename);
        }
    }
}
