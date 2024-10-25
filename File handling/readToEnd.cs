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
            string filename = Console.ReadLine();
            if (File.Exists(filename))
            {
                FileStream fp = new FileStream(filename, FileMode.Open);
                StreamReader reader = new StreamReader(fp);
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
                reader.Close();
                fp.Close();
            }
            else
                Console.WriteLine("Invalid filename/path");
        }
    }
}
