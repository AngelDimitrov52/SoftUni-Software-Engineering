using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberDay = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dog = double.Parse(Console.ReadLine()) * numberDay;
            double cat = double.Parse(Console.ReadLine()) * numberDay;
            double kostenurka = double.Parse(Console.ReadLine()) * 0.001;

            double total = dog + cat + (kostenurka*numberDay);

            if (total <= food)
            {
                double a = Math.Floor(food - total); 
                Console.WriteLine($"{a} kilos of food left.");
            }
            else
            {
                double a = Math.Ceiling(total - food);
                Console.WriteLine($"{a} more kilos of food are needed.");
            }
        }
    }
}
