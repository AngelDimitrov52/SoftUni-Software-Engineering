using System;

namespace P02.VehiclesExtention
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));

            string[] truckInfo = Console.ReadLine().Split();
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));

            string[] busInfo = Console.ReadLine().Split();
            Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] comand = Console.ReadLine().Split();
                string toDo = comand[0];
                string type = comand[1];
                double quantity = double.Parse(comand[2]);
                try
                {
                    Vehicle vehecle = IsCarOrTruck(type, car, truck , bus);

                    if (toDo == "Drive")
                    {
                        Console.WriteLine(vehecle.Drive(quantity));
                    }
                    else if (toDo == "Refuel")
                    {
                        vehecle.Refuel(quantity);
                    }
                    else if (toDo == "DriveEmpty")
                    {
                        Console.WriteLine(((Bus)vehecle).DriveEmpty(quantity));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }

        private static Vehicle IsCarOrTruck(string type, Vehicle car, Vehicle truck , Vehicle bus)
        {
            if (type == nameof(Car))
            {
                return car;
            }
            else if(type == nameof(Bus))      
            {
                return bus;
            }
            return truck;
        }
    }
}
