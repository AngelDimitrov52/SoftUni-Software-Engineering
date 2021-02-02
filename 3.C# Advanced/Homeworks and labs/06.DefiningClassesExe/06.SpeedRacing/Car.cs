using System;
using System.Collections.Generic;
using System.Text;

namespace _06.SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionFor1km)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionFor1km;
            TravelledDistance = 0;

        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void IsCanMoveDistace(double distance)
        {

            double needFuel = distance * FuelConsumptionPerKilometer;
            if (FuelAmount >= needFuel)
            {
                FuelAmount -= needFuel;
                TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
