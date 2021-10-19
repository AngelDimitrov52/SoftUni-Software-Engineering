using System;
using System.Collections.Generic;
using System.Text;

namespace P02.VehiclesExtention
{
   public abstract class Vehicle
    {
        protected Vehicle(double fuelquantity, double feulConsumption, double airCondition)
        {
            Fuelquantity = fuelquantity;
            FuelConsumption = feulConsumption;
            AirCondition = airCondition;
        }

        public double Fuelquantity { get; set; }
        public double FuelConsumption { get;private set; }
        public double AirCondition { get;private set; }

        public virtual string Drive(double distance)
        {
            double needFuel = (FuelConsumption + AirCondition) * distance;

            if (Fuelquantity < needFuel)
            {
                throw new InvalidOperationException($"{this.GetType().Name} needs refueling");
            }

            Fuelquantity -= needFuel;
            return $"{this.GetType().Name} travelled {distance} km";
        }
        public abstract void Refuel(double fuelLiters);
       
    }
}
