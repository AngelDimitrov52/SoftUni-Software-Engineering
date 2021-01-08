using System;

namespace Fir_
{
    class Program
    {
        static void Main(string[] args)
        {
            double houerNeeded = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine()) ;
            double numbers = double.Parse(Console.ReadLine()) *2 * days;

            double daysOff = days * 8 * 0.9;
            double totalHours = Math.Floor(daysOff + numbers);

            if (totalHours >= houerNeeded)
            {
                double a = Math.Floor(totalHours - houerNeeded);
                Console.WriteLine($"Yes!{a} hours left.");
            }
            else
            {
                double a = Math.Floor(houerNeeded - totalHours);
                Console.WriteLine($"Not enough time!{a} hours needed.");
            }
        }
    }
}
