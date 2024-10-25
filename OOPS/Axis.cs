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
        public void setPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void getPosition()
        {
            Console.WriteLine("{0} , {1}", x, y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Axis p = new Axis();
            p.setPosition(10, 20);
            p.getPosition();
        }
    }
}
