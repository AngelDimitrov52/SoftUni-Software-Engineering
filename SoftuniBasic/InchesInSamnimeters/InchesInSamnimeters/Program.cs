using System;

namespace SqardLice
{
    class Program
    {
        static void Main(string[] args)
        {

            var first = Console.ReadLine();
            var last = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", first, last, age, town);
        }
    }
}