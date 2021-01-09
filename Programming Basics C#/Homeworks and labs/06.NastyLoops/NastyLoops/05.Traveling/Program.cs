using System;

namespace _05.Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destinatin = Console.ReadLine();

            while (destinatin != "End")
            {
                double budget = double.Parse(Console.ReadLine());

               
                double number = double.Parse(Console.ReadLine());
                while (number < budget)
                {
                    number = double.Parse(Console.ReadLine());
                    
                }


                Console.WriteLine($"Going to {destinatin}!");

                destinatin = Console.ReadLine();
            }
        }
    }
}
