using System;

namespace _02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pass = Console.ReadLine();
            string input = input = Console.ReadLine();
            while (pass != input )
            {
                input = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
