using System;

namespace TrakingPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int raztoqnie = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            if (raztoqnie >= 100)
            {
                double a = raztoqnie * 0.06;
                Console.WriteLine($"{a:f2}");
            }

            else if (raztoqnie >= 20)
            {
                double a = raztoqnie * 0.09;
                Console.WriteLine($"{a:f2}");
            }

            else
            {
                if (time == "day")
                {
                    double a = raztoqnie * 0.79+0.70;
                    Console.WriteLine($"{a:f2}");
                }
                else if (time == "night")
                {
                    double a = raztoqnie * 0.90+0.70;
                    Console.WriteLine($"{a:f2}");
                }
            }
        }
    }
}
