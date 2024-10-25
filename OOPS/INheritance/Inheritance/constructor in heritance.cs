using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication33
{
    class Vehicle
    {
        public Vehicle()
        {
            Console.WriteLine("Petrol");
        }
        public Vehicle(string type)
        {
            Console.WriteLine("Vehicle init using " + type);
        }
    }
    class SportsVehicle : Vehicle
    {
        public SportsVehicle()
        {
            Console.WriteLine("Extra energy added to the vehicle");
        }
        public SportsVehicle( string type ) : base( type )
        {
            Console.WriteLine("Extra energy added to the vehicle");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SportsVehicle v = new SportsVehicle("Gas");
        }
    }
}
