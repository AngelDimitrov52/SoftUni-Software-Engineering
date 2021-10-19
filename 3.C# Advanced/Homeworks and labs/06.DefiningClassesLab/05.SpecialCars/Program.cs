using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<List<double>> tiresYear = new List<List<double>>();
            List<List<double>> tiresPressor = new List<List<double>>();

            string comand;
            while ((comand = Console.ReadLine()) != "No more tires")
            {
                double[] tiresArray = comand
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                tiresYear.Add(tiresArray.Where((n, i) => i % 2 == 0).ToList());
                tiresPressor.Add(tiresArray.Where((n, i) => i % 2 != 0).ToList());
            }

            List<int> housePowers = new List<int>();
            List<double> cubicCapacitys = new List<double>();

            while ((comand = Console.ReadLine()) != "Engines done")
            {
                double[] engineArray = comand
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(double.Parse)
                   .ToArray();
                housePowers.Add((int)engineArray[0]);
                cubicCapacitys.Add(engineArray[1]);
            }

            List<Car> cars = new List<Car>();

            while ((comand = Console.ReadLine()) != "Show special")
            {
                string[] carArray = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = carArray[0];
                string model = carArray[1];
                int year = int.Parse(carArray[2]);
                double fuelQuantity = double.Parse(carArray[3]);
                double fuelConsumption = double.Parse(carArray[4]);
                int engineIndex = int.Parse(carArray[5]);
                int tiresIndex = int.Parse(carArray[6]);

                int horsePower = housePowers[engineIndex];
                double tirePressure = tiresPressor[tiresIndex].Sum();

                Car car = new Car(make, model, year, fuelQuantity,
                    fuelConsumption, horsePower, tirePressure);

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                if (car.Year >= 2017 && car.HorsePower > 330 && car.Pressure > 9 && car.Pressure < 10)
                {
                    car.FuelQuantity -= (car.FuelConsumption / 100) * 20;

                    Console.WriteLine($"Make: {car.Make}\n" +
                        $"Model: { car.Model}\n" +
                        $"Year: {car.Year}\n" +
                        $"HorsePowers: {car.HorsePower}\n" +
                        $"FuelQuantity: {car.FuelQuantity}");
                }
            }
        }
    }
}
