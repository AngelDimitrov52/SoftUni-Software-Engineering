using System;

namespace ChekForExcellentRating
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());

            if (a >= 5.50 && a<=6.00)
            {
                Console.WriteLine("Excellent!");
            }

           

        }
    }
}
