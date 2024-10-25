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
            Console.WriteLine("Directory name");
            string dirname = Console.ReadLine();
            if (Directory.Exists(dirname))
            {
                DirectoryInfo d = new DirectoryInfo(dirname);
                FileInfo [ ] files = d.GetFiles();
                foreach (FileInfo f in files)
                {
                    Console.WriteLine("{0} {1} {2} {3}", f.Name, f.Length, f.LastAccessTime.ToString(), f.Extension);
                }
            }
            else
                Console.WriteLine("Invalid directory path");
        }
    }
}
