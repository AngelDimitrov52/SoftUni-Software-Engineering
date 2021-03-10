using System;

namespace P02.VehiclesExtention
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));

            string[] truckInfo = Console.ReadLine().Split();
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] comand = Console.ReadLine().Split();
                string toDo = comand[0];
                string type = comand[1];
                double quantity = double.Parse(comand[2]);

                if (toDo == "Drive")
                {
                    try
                    {
                        Vehicle vehecle = IsCarOrTruck(type, car, truck);
                        Console.WriteLine(vehecle.Drive(quantity));
                    }
                    catch (InvalidOperationException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }
                else if (toDo == "Refuel")
                {
                    Vehicle vehecle = IsCarOrTruck(type, car, truck);
                   vehecle.Refuel(quantity);
                }
            }
            Console.WriteLine($"Car: {car.Fuelquantity:f2}");
            Console.WriteLine($"Truck: {truck.Fuelquantity:f2}");
        }

        private static Vehicle IsCarOrTruck(string type, Vehicle car, Vehicle truck)
        {
            if (type == "Car")
            {
                return car;
            }
            return truck;
        }
    }
}
