using System;

namespace _06.Sumary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumary = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string site = Console.ReadLine();

                if (site == "Facebook")
                {
                    sumary -= 150;
                }
                else if (site == "Instagram")
                {
                    sumary -= 100;
                }
                else if (site == "Reddit")
                {
                    sumary -= 50;
                }

                if (sumary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (sumary > 0)
            {
                Console.WriteLine(sumary);
            }
            

        }
    }
}
