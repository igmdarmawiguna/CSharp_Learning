using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication33
{
    class Nokia1
    {
        public void Camera( )
        {
            Console.WriteLine("2 mega pixel");
        }
    }

    class Nokia2 : Nokia1
    {
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
        }
    }
}
