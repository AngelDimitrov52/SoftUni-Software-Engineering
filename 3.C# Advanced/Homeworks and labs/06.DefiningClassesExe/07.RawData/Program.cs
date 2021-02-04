using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.RawData
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = data[0];

                Engine engine = new Engine();
                engine.EngineSpeed = int.Parse(data[1]);
                engine.EnginePower = int.Parse(data[2]);

                Cargo cargo = new Cargo
                {
                    CargoWeight = int.Parse(data[3]),
                    CargoType = data[4]
                };

                Tire[] tires =
                {
                   new Tire  { Pressure = double.Parse(data[5]), TireYear = int.Parse(data[6])},
                    new Tire { Pressure = double.Parse(data[7]), TireYear = int.Parse(data[8]) },
                    new Tire { Pressure = double.Parse(data[9]), TireYear = int.Parse(data[10]) },
                    new Tire { Pressure = double.Parse(data[11]), TireYear = int.Parse(data[12]) }
                };

                Car curntCar = new Car(model, engine, cargo, tires);
                cars.Add(curntCar);
            }

            List<Car> filterCars = new List<Car>();
            string comand = Console.ReadLine();
            cars = cars.Where(n => n.Cargo.CargoType == comand).ToList();
            if (comand == "fragile")
            {  
                foreach (var item in cars)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (item.Tire[i].Pressure < 1)
                        {
                            filterCars.Add(item);
                            break;
                        }
                    }

                }
            }
            else if (comand == "flamable")
            {
                foreach (var item in cars)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (item.Engine.EnginePower > 250)
                        {
                            filterCars.Add(item);
                            break;
                        }
                    }

                }
            }

            foreach (var item in filterCars)
            {
                Console.WriteLine(item.Model);
            }
        }
    }
}
