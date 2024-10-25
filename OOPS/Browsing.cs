using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Browsing
{
    class InternetBrowsing
    {
        private int id, hrs, used;
        private static int autoid , thrs=500 , tused;

        public InternetBrowsing(int hrs)
        {
            this.hrs = hrs;
            id = ++autoid;
        }
        public void Browse(int h )
        {
            int remaining = hrs- used;
            if( (remaining - h) < 0 )
                Console.WriteLine("Insufficient hrs remaining, can't allot");
            else
            {
            used = used + h;
            tused = tused + h;
            }
        }
        public void MyReport( )
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Your ID         : EBROWSE{0}", id);
            Console.WriteLine("Total hrs      : {0}", hrs );
            Console.WriteLine("Used hrs      : {0}", used);
            Console.WriteLine("Remaining   : {0}", hrs - used );
            Console.WriteLine("-----------------------------------------------");
        }
        public static void Report( )
        {
            Console.WriteLine("Total customers count {0}", autoid);
            Console.WriteLine("Total hours from ISP {0}", thrs);
            Console.WriteLine("Total consumed   {0}", tused);
            Console.WriteLine("Remaining {0}", thrs - tused);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          
            InternetBrowsing c1 = new InternetBrowsing(40);
            InternetBrowsing c2 = new InternetBrowsing(20);
            c1.Browse(4);
            c2.Browse(6);

            c1.MyReport();
            c2.MyReport();

            InternetBrowsing.Report();
        }
    }
}
