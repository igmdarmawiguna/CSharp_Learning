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
            string  [ ] drives = System.Environment.GetLogicalDrives();
            for (int i = 0; i < drives.Length; i++)
                Console.WriteLine(drives[i]);
        }
    }
}
