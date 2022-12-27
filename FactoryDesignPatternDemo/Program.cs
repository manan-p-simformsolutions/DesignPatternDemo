using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputFromConsole = null;
            Console.WriteLine("Enter Vehicle Type : ");
            inputFromConsole = Console.ReadLine();
            IVehicle Type = VehicleFactory.getVehicle(inputFromConsole);
            Console.WriteLine("Vehicle Type is :" + Type.VehicleType());
            Console.WriteLine("Number of wheels is :" + Type.NumberOfWheels());
            Console.ReadKey();
        }
    }
}