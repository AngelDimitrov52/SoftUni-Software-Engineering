using System;
using System.Collections.Generic;
using System.Text;

namespace P02.VehiclesExtention
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        protected Vehicle(double fuelquantity, double feulConsumption, double airCondition, double tankCapasity)
        {
            TankCapasity = tankCapasity;
            FuelQuantity = fuelquantity;
            FuelConsumption = feulConsumption;
            AirCondition = airCondition;
        }

        public double FuelQuantity
        {
            get => fuelQuantity;
            set
            {
                if (value > TankCapasity)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
            }
        }
        public double FuelConsumption { get; private set; }
        public double AirCondition { get; private set; }
        public double TankCapasity { get; private set; }

        public virtual string Drive(double distance)
        {
            double needFuel = (FuelConsumption + AirCondition) * distance;

            if (FuelQuantity < needFuel)
            {
                throw new InvalidOperationException($"{this.GetType().Name} needs refueling");
            }

            FuelQuantity -= needFuel;
            return $"{this.GetType().Name} travelled {distance} km";
        }
        public virtual void Refuel(double fuelLiters)
        {
            if (fuelLiters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (fuelLiters > TankCapasity - fuelQuantity)
            {
                throw new InvalidOperationException($"Cannot fit {fuelLiters} fuel in the tank");
            }
            FuelQuantity += fuelLiters;
        }

    }
}
