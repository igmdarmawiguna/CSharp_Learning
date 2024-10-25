using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpeechLib;
namespace ConsoleApplication30
{
    class Axis
    {
        private int x, y;
       public Axis(int x , int y)
        {
            this.x = x;
            this.y = y;
        }
         public override string  ToString()
        {
            return string.Format("{0} , {1}", x, y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Axis p = new Axis(10, 20);
            System.Console.WriteLine(p);
        }
    }
}
