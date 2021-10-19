using System;
using System.Collections.Generic;
using System.Text;

namespace P02.VehiclesExtention
{
    public class Truck : Vehicle
    {
        private const double AirConsumption = 1.6;
        public Truck(double fuelQuantity, double litersPerKm)
            : base(fuelQuantity, litersPerKm, AirConsumption)
        {

        }
        public override void Refuel(double fuelLiters)
        {
            Fuelquantity += (fuelLiters * 0.95);
        }
    }
}
