using System;

namespace _01.BackInThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            int a = 19;
            for (int i = 1800; i <= age; i++)
            {
                if (i%2==0)
                {
                    cash -= 12000;
                }
                else
                { 
                    cash -= (12000 + (50 * a));
                    a+=2;
                }
            }
            if (cash>=0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {cash:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(cash):f2} dollars to survive.");
            }

        }
    }
}
