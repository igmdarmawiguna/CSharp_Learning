using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication39
{
    interface GC
    {
        void showClock();
    }
    class India : GC  
    {
        #region GC Members
        public void showClock()
        {
            Console.WriteLine(DateTime.Now.ToString());
        }
        #endregion
    }
    class Europe : GC
    {
        #region GC Members
        public void showClock()
        {
            Console.WriteLine(DateTime.Now.AddHours(4));
        }
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            GC g;
            Console.WriteLine("1. India");
            Console.WriteLine("2. Europe");
            int ch = int.Parse(Console.ReadLine());
            if (ch == 1)
                g = new India();
            else
                g = new Europe();
            g.showClock();
        }
    }
}
