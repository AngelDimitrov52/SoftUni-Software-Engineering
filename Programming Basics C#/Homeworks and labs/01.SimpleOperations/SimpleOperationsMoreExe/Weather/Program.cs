using System;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();

            if (a == "sunny") 
            {
                Console.WriteLine($"It's warm outside!");
            }

           else
            {
                Console.WriteLine($"It's cold outside!");
            }


        }
    }
}
