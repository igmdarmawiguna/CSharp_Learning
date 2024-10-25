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
                string content = reader.ReadToEnd().Replace(wfind, wreplace);

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
