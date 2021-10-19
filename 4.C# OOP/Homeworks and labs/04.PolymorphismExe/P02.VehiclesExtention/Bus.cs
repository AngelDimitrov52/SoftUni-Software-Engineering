using System;
using System.Collections.Generic;
using System.Text;

namespace P02.VehiclesExtention
{
    public class Bus : Vehicle
    {
        private const double AirConsumption = 1.4;
        public Bus(double fuelQuantity, double litersPerKm, double tank)
            : base(fuelQuantity, litersPerKm, AirConsumption, tank)
        {

        }
        public  string DriveEmpty(double distance)
        {
            double needFuel = FuelConsumption  * distance;

            if (FuelQuantity < needFuel)
            {
                throw new InvalidOperationException($"{this.GetType().Name} needs refueling");
            }

            FuelQuantity -= needFuel;
            return $"{this.GetType().Name} travelled {distance} km";
        }
    }
}
