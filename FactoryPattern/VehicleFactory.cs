using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class VehicleFactory
    {
        internal static IVehicle GetVehicle(string numWheels)
        {
            IVehicle newVehicle;
            switch (numWheels.ToLower())
            {
                case "4":
                    newVehicle = new Car();
                    break;
                case "2":
                    newVehicle = new Motorcycle();
                    break;
                default:
                    newVehicle = new Car();
                    break;
            }

            return newVehicle;
        }
    }
}
