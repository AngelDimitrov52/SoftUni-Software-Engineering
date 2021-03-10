using System;
using System.Collections.Generic;
using System.Text;

namespace P02.VehiclesExtention
{
    public class Car : Vehicle
    {
        private const double AirConsumption = 0.9;
        public Car(double fuelQuantity, double litersPerKm)
            : base(fuelQuantity, litersPerKm, AirConsumption)
        {

        }
        public override void Refuel(double fuelLiters)
        {
            Fuelquantity += fuelLiters;
        }
    }
}
