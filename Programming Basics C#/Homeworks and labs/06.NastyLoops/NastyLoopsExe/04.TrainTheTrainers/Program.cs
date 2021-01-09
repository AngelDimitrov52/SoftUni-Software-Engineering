using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string comand = Console.ReadLine();
            int totalCaundet = 0;
            double totalsum = 0;
            while (comand != "Finish")
            {
                totalCaundet++;
                double sum = 0.0;
                int counter = 0;
                for (int i = 1; i <= n; i++)
                {
                    double ocenka = double.Parse(Console.ReadLine());
                    sum += ocenka;
                    counter++;
                }
                
                double a = sum / counter;
                totalsum += a;
                Console.WriteLine($"{comand} - {a:f2}.");
                comand = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {totalsum/totalCaundet:f2}.");
        }
    }
}
