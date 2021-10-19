using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public Car(string make,string model , int year )        
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public Car(string make, string model, int year,
            double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }
        public Car(string make, string model, int year,
            double fuelQuantity, double fuelConsumption,
            int engine , double tires )
            :this(make, model, year, fuelQuantity,fuelConsumption)
        {
            HorsePower = engine;
            Pressure = tires;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public int HorsePower { get; set; }
        public double Pressure { get; set; }

    }
}
