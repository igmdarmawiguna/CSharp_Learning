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
                FileInfo [ ] files = d.GetFiles(".bak");
                foreach (FileInfo f in files)
                {
                    f.Delete();
                }
            }
            else
                Console.WriteLine("Invalid directory path");
        }
    }
}
