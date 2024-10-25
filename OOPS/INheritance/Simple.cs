using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication33
{
    class A
    {
        private void f1() { }
        public void f2() { }
    }

    class B : A                  // Simple inheritance
    {
        public void f3() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            obj.f2();
            obj.f3();
        }
    }
}
