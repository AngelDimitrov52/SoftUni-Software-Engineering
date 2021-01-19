using System;

namespace _04.CalculatTheMinets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int years = n * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int min = hours * 60;
            Console.WriteLine($"{n} centuries = {years} years = {days} days =" +
                $" {hours} hours = {min} minutes");

        }
    }
}
