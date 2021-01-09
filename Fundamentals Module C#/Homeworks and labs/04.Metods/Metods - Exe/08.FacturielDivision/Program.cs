using System;

namespace _08.FacturielDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double firtstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            double result = GetFacturelOfNum(firtstNum) / GetFacturelOfNum(secondNum);
            Console.WriteLine($"{result:f2}");


        }

        private static double GetFacturelOfNum(double firtstNum)
        {
            if (firtstNum == 1)
                return 1;
            else
                return firtstNum * GetFacturelOfNum(firtstNum - 1);
        }
    }
}
