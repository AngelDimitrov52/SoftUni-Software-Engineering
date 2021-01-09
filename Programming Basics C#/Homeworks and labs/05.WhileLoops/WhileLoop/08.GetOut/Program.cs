using System;

namespace _08.GetOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int sh = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int space = sh * d * h;
            string bagaj = Console.ReadLine();

            while (bagaj != "Done")
            {
                space -=int.Parse(bagaj);
                if (space<0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(space)} Cubic meters more.");
                    break;
                }
                bagaj = Console.ReadLine();
            }
            if (space >=0)
            {
                Console.WriteLine($"{space} Cubic meters left.");
            }

        }
    }
}
