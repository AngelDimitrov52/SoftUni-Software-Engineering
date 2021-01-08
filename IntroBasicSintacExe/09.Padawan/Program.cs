using System;

namespace _09.Padawan
{
    class Program
    {
        static void Main(string[] args)
        {
            double butget = double.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            double lightsabers = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());

            lightsabers *= (Math.Ceiling(countStudents * 1.10));
            int freeBelt = countStudents / 6;
            belts *= (countStudents - freeBelt);
            robes *= countStudents;

            double totalSum = lightsabers + belts + robes;

            if (totalSum<=butget)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(butget-totalSum):f2}lv more.");
            }

        }
    }
}
