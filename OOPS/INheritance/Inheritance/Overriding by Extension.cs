using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication33
{
    class Nokia1
    {
        public void Ringtone()
        {
            Console.WriteLine("25 ringtones");
        }
        public void Camera( )
        {
            Console.WriteLine("2 mega pixel");
        }
    }

    class Nokia2 : Nokia1
    {

        public new void Ringtone()
        {
            base.Ringtone();
            Console.WriteLine("20 more 3d sound effect ringtones");
        }
        public new void Camera()
        {
            Console.WriteLine("5 mega pixel");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Nokia2 n = new Nokia2();
            n.Camera();
            n.Ringtone();
        }
    }
}
