using System;

namespace _02.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int divisionNum = 0;

            if (number % 10 == 0)
            {
                divisionNum = 10;
            }
            else if (number % 7 == 0)
            {
                divisionNum = 7;
            }
            else if (number % 6 == 0)
            {
                divisionNum = 6;
            }
            else if (number % 3 == 0)
            {
                divisionNum = 3;
            }
            else if (number % 2 == 0)
            {
                divisionNum = 2;
            }

            if (divisionNum != 0 )
            {
                Console.WriteLine($"The number is divisible by {divisionNum}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }


        }
    }
}
