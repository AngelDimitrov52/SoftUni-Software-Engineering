using System;

namespace EuroCompilator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Leva = ");
            var leva = int.Parse(Console.ReadLine());
            Console.Write("Euro = ");
            var euro = leva / 1.95538;
            Console.WriteLine(euro);
        }
    }
}
