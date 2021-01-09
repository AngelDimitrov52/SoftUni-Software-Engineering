using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.NeedForSpeed3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> carsDic = new Dictionary<string, List<int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<int> milAndFuel = new List<int>();

                string[] carsArgs = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string carName = carsArgs[0];
                int carMileage = int.Parse(carsArgs[1]);
                int carFuel = int.Parse(carsArgs[2]);

                milAndFuel.Add(carMileage);
                milAndFuel.Add(carFuel);

                carsDic.Add(carName, milAndFuel);
            }
            string comand;
            while ((comand = Console.ReadLine()) != "Stop")
            {
                string[] comandArgs = comand.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string cmd = comandArgs[0];
                string car = comandArgs[1];

                if (cmd == "Drive")
                {
                    int distance = int.Parse(comandArgs[2]);
                    int fuel = int.Parse(comandArgs[3]);

                    if (fuel > carsDic[car][1])
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        carsDic[car][0] += distance;
                        carsDic[car][1] -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }
                    if (carsDic[car][0] >= 100000)
                    {
                        Console.WriteLine($"Time to sell the {car}!");
                        carsDic.Remove(car);
                    }
                }
                else if (cmd == "Refuel")
                {
                    int fuel = int.Parse(comandArgs[2]);
                    int midFuel = carsDic[car][1];
                    carsDic[car][1] += fuel;
                    if (carsDic[car][1] > 75)
                    {
                        carsDic[car][1] = 75;
                        fuel = 75 - midFuel;
                    }
                    Console.WriteLine($"{car} refueled with {fuel} liters");
                }
                else if (cmd == "Revert")
                {
                    int kilometers = int.Parse(comandArgs[2]);
                    carsDic[car][0] -= kilometers;
                    if (carsDic[car][0] < 10000)
                    {
                        carsDic[car][0] = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                }
            }
            foreach (var item in carsDic.OrderByDescending(x=> x.Value[0]).ThenBy(k=>k.Key))
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value[0]} kms, Fuel in the tank: {item.Value[1]} lt.");
            }
        }
    }
}
