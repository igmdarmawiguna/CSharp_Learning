using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpeechLib;
namespace ConsoleApplication30
{
    class Contact
    {
        string name, mobile;
        public Contact(string name, string mobile)
        {
            this.name = name;
            this.mobile = mobile;
        }
        public override string ToString()
        {
            return string.Format("Name  : {0}\nMobile : {1}", name, mobile);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Contact c = new Contact("Sam", "9844411121");
            Console.WriteLine(c);
        }
    }
}
