using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternDemo
{
    class Rickshaw : IVehicle
    {
        private readonly int Wheels;
        public Rickshaw()
        {
            this.Wheels = 3;
        }
        public int NumberOfWheels()
        {
            return this.Wheels;
        }
        public string VehicleType()
        {
            return "Rickshaw Class";
        }
    }
}
