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
            string filename = "d:/prod.txt";
               if (File.Exists(filename))
            {
                FileStream fp = new FileStream(filename, FileMode.Open);
                StreamReader reader = new StreamReader(fp);
                string data;
                long cost = 0;
                while ((  data = reader.ReadLine() ) != null )
                {
                    string [ ] vals = data.Split(',');
                    cost = cost + long.Parse(vals[1]);
                    Console.WriteLine(data);
                }
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("Total cost = {0:N} Rs", cost);
                Console.WriteLine("-----------------------------------------------------------");
                reader.Close();
                fp.Close();
            }
            else
                Console.WriteLine("Invalid filename/path");
        }
    }
}
