using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Fhandle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter filename");
            string filename = Console.ReadLine();
            if (File.Exists(filename))
            {
                Console.WriteLine("Enter word to find and word to replace");
                string wfind = Console.ReadLine();
                string wreplace = Console.ReadLine();

                FileStream fp = new FileStream(filename, FileMode.Open);
                StreamReader reader = new StreamReader(fp);
                string content = reader.ReadToEnd();

                int p;
                while ((p = content.IndexOf(wfind)) != -1)
                {
                    Console.WriteLine("[R]eplace  [Q]uit");
                    string choice =  Console.ReadLine();
                    if (choice.Equals("R"))
                        content = content.Substring(0, p) + wreplace + content.Substring(p + wfind.Length);
                    else if (choice.Equals("Q")) break;
                }
                reader.Close();
                fp.Close();
                fp = new FileStream(filename, FileMode.Create);
                StreamWriter writer = new StreamWriter(fp);
                writer.WriteLine(content);
                writer.Close();
                fp.Close();
            }
            else
                Console.WriteLine("File not found");
        }
    }
}
