using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Projects:");
            int progects = int.Parse(Console.ReadLine());
            int time = progects * 3;
            Console.WriteLine($"The architect {name} will need {time} hours to complete {progects} project/s.");
        }
    }
}
