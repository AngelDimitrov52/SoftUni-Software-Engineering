using System;
using System.Collections.Generic;
using System.Text;

namespace P02.VehiclesExtention
{
    public class Truck : Vehicle
    {
        private const double AirConsumption = 1.6;
        public Truck(double fuelQuantity, double litersPerKm, double tank)
            : base(fuelQuantity, litersPerKm, AirConsumption, tank)
        {

        }
        public override void Refuel(double fuelLiters)
        {
            if (fuelLiters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (fuelLiters + FuelQuantity > TankCapasity)
            {
                throw new InvalidOperationException($"Cannot fit {fuelLiters} fuel in the tank");
            }
            FuelQuantity += fuelLiters * 0.95;
        }
    }
}
