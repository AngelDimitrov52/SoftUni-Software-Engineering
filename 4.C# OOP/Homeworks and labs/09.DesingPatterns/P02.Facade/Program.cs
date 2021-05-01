using System;

namespace P02.Facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new CarBuilderFacade()
                .Info
                .WhitColor("Blue")
                .WhitType("Audi")
                .WhitNumberOfDoors(5)
                .Address
                .AtAddress("Marica 5")
                .InCity("Samokov")
                .Build();

            Console.WriteLine(car);
        }
    }
}
