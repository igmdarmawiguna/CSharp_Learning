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
            Console.WriteLine("Enter date of birth ( dd/mm/yyyy )");
            string dob = Console.ReadLine();
            string [ ]  v = dob.Split('/');

            int age = DateTime.Now.Year - int.Parse(v[2]);
            Console.WriteLine("Age = {0}", age);
        }
    }
}
