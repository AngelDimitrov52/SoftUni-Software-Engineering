using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CarSaverman
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Engine curenEngine = new Engine();
                string[] comandAgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                curenEngine.Model = comandAgs[0];
                curenEngine.Power = int.Parse(comandAgs[1]);

                if (comandAgs.Length == 3)
                {
                    if (char.IsLetter(comandAgs[2], 0))
                    {
                        curenEngine.Efficiency = comandAgs[2];
                    }
                    else
                    {
                        curenEngine.Displacement = comandAgs[2];
                    }
                }
                else if (comandAgs.Length == 4)
                {
                    curenEngine.Displacement = comandAgs[2];
                    curenEngine.Efficiency = comandAgs[3];
                }
                engines.Add(curenEngine);
            }

            List<Car> cars = new List<Car>();

            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] comandAgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car();
                car.Model = comandAgs[0];
                car.Engine = engines.Where(n => n.Model == comandAgs[1]).FirstOrDefault();
                if (comandAgs.Length == 3)
                {
                    if (char.IsLetter(comandAgs[2], 0))
                    {
                        car.Color = comandAgs[2];
                    }
                    else
                    {
                        car.Weight = comandAgs[2];
                    }
                }
                else if (comandAgs.Length == 4)
                {
                    car.Weight = comandAgs[2];
                    car.Color = comandAgs[3];
                }
                cars.Add(car);
            }


            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }


    }
}
