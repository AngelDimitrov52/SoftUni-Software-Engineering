using System;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> cars = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] comandArgs = Console.ReadLine().Split();
                string comand = comandArgs[0];

                if (comand == "register")
                {
                    string userName = comandArgs[1];
                    string carNumber = comandArgs[2];
                    if (!cars.ContainsKey(userName))
                    {
                        cars.Add(userName, carNumber);
                        Console.WriteLine($"{ userName} registered { carNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number { carNumber}");
                    }
                }
                else
                {
                    string userName = comandArgs[1];
                    if (!cars.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{ userName} unregistered successfully");
                        cars.Remove(userName);
                    }
                }
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

        }
    }
}
