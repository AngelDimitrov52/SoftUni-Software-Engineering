using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string madel = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car vw = new Car();
            Car ford = new Car(make, madel, year);
            Car bmw = new Car(make, madel, year , fuelQuantity , fuelConsumption);

        }
    }
}
