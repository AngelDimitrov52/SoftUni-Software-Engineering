using System;

namespace TreeGreen
{
    class Program
    {
        static void Main(string[] args)
        {
            double kvad = double.Parse(Console.ReadLine());
            double firstbill = kvad * 7.61;
            double otstupka = firstbill * 0.18;
            double lastbill = firstbill - otstupka;
            Console.WriteLine($"The final price is: {lastbill:f2} lv.");
            Console.WriteLine($"The discount is: {otstupka:f2} lv.");
        }
    }
}
