
using System;

namespace _01.CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            string comand;
            int count = 0;
            while ((comand = Console.ReadLine()) != "End of battle")
            {
                int power = int.Parse(comand);

                if (power > energy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {count}" +
                        $" won battles and {energy} energy");
                    return;
                }

                energy -= power;

                count++;
                    if (count % 3 == 0)
                {
                    energy += count;
                }



            }
            Console.WriteLine($"Won battles: {count}. Energy left: {energy}");




        }
    }
}
