using System;

namespace _01.Change
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoin = double.Parse(Console.ReadLine());
            double iona = double.Parse(Console.ReadLine());
            double komisionna = double.Parse(Console.ReadLine());

            double leva1 = bitcoin * 1168;
            double dolur1 = iona * 0.15;
            double leva2 = dolur1 * 1.76;
            double euro = (leva1 + leva2) / 1.95;

            double total = euro * (1 - komisionna*0.01);
            Console.WriteLine($"{total:f2}");
        }
    }
}
