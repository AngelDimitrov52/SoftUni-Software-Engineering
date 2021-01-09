using System;

namespace Time_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine()) + 15;

            if (min>=60)
            {
                min = min - 60;
                hour = hour + 1;
            }
            if (hour == 24)
            {
                hour =  0;
                

            }
            Console.WriteLine($"{hour}:{min:D2}");

        }
    }
}
