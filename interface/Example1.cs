using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication39
{
    interface SIMCARD
    {
        void sms();
        void call();
    }

    class XL : SIMCARD
    {
        #region USIM Members

        public void sms()
        {
            Console.WriteLine("Send sms using XL");
        }

        public void call()
        {
            Console.WriteLine("Call / Recieve using XL");
        }

        #endregion
    }
    class Telkomsel : SIMCARD
    {

        #region USIM Members

        public void sms()
        {
            Console.WriteLine("sms using reliance Telkomsel");
        }

        public void call()
        {
            Console.WriteLine("Call / recieve using Telkomsel network");
        }
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            SIMCARD sim;
            Console.WriteLine("1. XL");
            Console.WriteLine("2. Telkomsel");
            int ch = int.Parse(Console.ReadLine());
            if (ch == 1)
                sim = new Airtel();
            else
                sim = new Reliance();

            sim.call();
            sim.sms();
        }
    }
}
