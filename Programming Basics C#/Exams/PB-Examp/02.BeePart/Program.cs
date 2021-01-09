using System;

namespace _02.BeePart
{
    class Program
    {
        static void Main(string[] args)
        {
            int inrligent = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            string pol = Console.ReadLine();
            string bee = "";

            if (inrligent >= 80 && power >= 80 && pol == "female")
            {
                bee = "Queen Bee";
            }
            else if (inrligent >= 80)
            {
                bee = "Repairing Bee";
            }
            else if (inrligent >= 60)
            {
                bee = "Cleaning Bee";
            }
            else if (power >= 80 && pol == "male")
            {
                bee = "Drone Bee";
            }
            else if (power >= 60)
            {
                bee = "Guard Bee";
            }
            else
            {
                bee = "Worker Bee";
            }

            Console.WriteLine(bee);
        }
    }
}
