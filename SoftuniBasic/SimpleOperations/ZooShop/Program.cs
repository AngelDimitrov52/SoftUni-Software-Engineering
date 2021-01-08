using System;

namespace ZooShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dog = int.Parse(Console.ReadLine());
            int noDog = int.Parse(Console.ReadLine());
            double dogFood = dog * 2.50;
            int noDogFood = noDog * 4;
            double biil = (dogFood + noDogFood);
            
            Console.Write($"{biil:f2}lv.");
            
            
        }
    }
}
