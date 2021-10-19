using System;

namespace _08.BeerKeg
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string bigerKeg = string.Empty;
            double bigerKegSum = double.MinValue;
            for (int i = 0; i < n; i++)
            {

                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double kegCalculate = Math.PI * radius*radius * height;
                if (kegCalculate > bigerKegSum)
                {
                    bigerKegSum = kegCalculate;
                    bigerKeg = model;
                }


            }
            Console.WriteLine(bigerKeg);



        }
    }
}
