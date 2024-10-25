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
            string s = "google search engine is fast,google is best,google is simple and google can be integrated";
            Console.WriteLine("Enter word to delete");
            string w = Console.ReadLine();

            int p;
            while( ( p = s.IndexOf(w) )!=-1 )
            {
               s =  s.Remove( p , w.Length );
            }
            Console.WriteLine(s);
       }
    }
}
