using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();

            List<Car> carList = new List<Car>();
            bool flagCar = false;
            bool flagTrugs = false;
            while (comand != "end")
            {
                string[] comandArgs = comand.Split("/");
                string type = comandArgs[0];
                string brand = comandArgs[1];
                string model = comandArgs[2];
                string hp = comandArgs[3];
                if (type == "Car")
                {
                    flagCar = true;
                }
                if (type == "Truck")
                {
                    flagTrugs = true;
                }

                Car theCar = new Car(type, brand, model, hp);

                carList.Add(theCar);

                comand = Console.ReadLine();
            }

            List<Car> SortedList = carList.OrderBy(o => o.Brand).ToList();

            if (flagCar)
            {
                Console.WriteLine("Cars:");
            foreach (Car item in SortedList)
            {
                    if (item.Type == "Car")
                    {
                        Console.WriteLine($"{item.Brand}: {item.Model} - {item.HP}hp");
                    }
            }

            }
            if (flagTrugs)
            {
                Console.WriteLine("Trucks:");
                foreach (Car item in SortedList)
                {
                    if (item.Type == "Truck")
                    {
                        Console.WriteLine($"{item.Brand}: {item.Model} - {item.HP}kg");
                    }
                }

            }


        }
    }
    class Car
    {
        public Car(string type, string brand, string model, string hP)
        {
            Type = type;
            Brand = brand;
            Model = model;
            HP = hP;
        }

        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HP { get; set; }


    }
}
