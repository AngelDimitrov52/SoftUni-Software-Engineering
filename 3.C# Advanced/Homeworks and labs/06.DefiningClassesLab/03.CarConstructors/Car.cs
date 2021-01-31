using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;

        }
        public Car(string make,string model , int year )
            :this()
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            if (FuelQuantity - (distance * FuelQuantity) >= 0)
            {
                FuelQuantity -= distance * FuelQuantity;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }

        }
        public string WhoIAm()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: " +
                $"{this.Year}\nFuel: {this.FuelQuantity:F2}L";
        }
    }
}
