using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int sh = int.Parse(Console.ReadLine());

            int sumCake = d * sh;

            while (sumCake >= 0)
            {
                string part = Console.ReadLine();
                if (part == "STOP")
                {
                    Console.WriteLine($"{sumCake} pieces are left.");
                    break;
                }
                sumCake -= int.Parse(part);
            }
            if (sumCake<0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(sumCake)} pieces more.");
            }
        }
    }
}
