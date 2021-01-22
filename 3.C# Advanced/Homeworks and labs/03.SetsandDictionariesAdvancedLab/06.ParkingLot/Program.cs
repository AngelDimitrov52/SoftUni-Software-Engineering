using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            string comand;
            while ((comand = Console.ReadLine()) != "END")
            {
                string[] comandArgs = comand.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string cmd = comandArgs[0];
                string carNum = comandArgs[1];

                if (cmd == "IN")
                {
                    cars.Add(carNum);
                }
                else
                {
                    cars.Remove(carNum);
                }
            }
            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine , cars));
            }
        }
    }
}
