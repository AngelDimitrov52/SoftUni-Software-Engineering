using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionFor1km = double.Parse(carInfo[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);
                cars.Add(car);
            }

            string comand;
            while ((comand = Console.ReadLine()) != "End")
            {
                string[] drive = comand
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = drive[1];
                double amoutOfKm = double.Parse(drive[2]);

                Car curentCar = cars.Where(c => c.Model == model).ToList().First();
                curentCar.IsCanMoveDistace(amoutOfKm);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} { car.TravelledDistance}");
            }
        }
    }
}
