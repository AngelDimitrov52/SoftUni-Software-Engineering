using System;

namespace _04.HourMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine())*60;
            int minutes = int.Parse(Console.ReadLine()) + 30;
            int sum = hours + minutes;

            hours = sum / 60;
            minutes = sum % 60;
            if (hours == 24)
            {
                hours = 0;
            }
           
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
