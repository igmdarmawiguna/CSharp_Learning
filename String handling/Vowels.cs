using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence");
            string s = Console.ReadLine();
            int c = 0;

            string vowels = "aeiou";
            for (int i = 0; i < s.Length; i++)
            {
                string eChar = s.Substring(i, 1);
                if (vowels.IndexOf(eChar) != -1) c++;
            }


        }
    }
}
