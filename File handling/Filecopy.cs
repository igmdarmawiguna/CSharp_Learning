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
            Console.WriteLine("Source filename");
            string src = Console.ReadLine();
            if (File.Exists(src))
            {
                Console.WriteLine("Target filename");
                string target = Console.ReadLine();
                if (File.Exists(target))
                {
                    Console.WriteLine("Already exists [Q]uit   [O]verwrite");
                    string choice = Console.ReadLine();
                    if (choice.Equals("Q")) return;
                    else if (choice.Equals("O"))
                        File.Copy(src, target, true);
                }
                else
                    File.Copy(src, target);
            }
            else
                Console.WriteLine("Source file not found");
        }
    }
}
