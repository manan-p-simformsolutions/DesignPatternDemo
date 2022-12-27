using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternDemo
{
    class VehicleFactory
    {
        public static IVehicle getVehicle(string Type)
        {
            IVehicle ObjectType = null;
            if (Type.ToLower().Equals("bike"))
            {
                ObjectType = new Bike();
            }
            else if (Type.ToLower().Equals("car"))
            {
                ObjectType = new Car();
            }
            else if (Type.ToLower().Equals("rickshaw"))
            {
                ObjectType = new Rickshaw();
            }
            return ObjectType;

        }
    }
}
