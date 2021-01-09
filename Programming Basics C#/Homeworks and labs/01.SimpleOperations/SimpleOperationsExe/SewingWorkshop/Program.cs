using System;

namespace SewingWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double dul = double.Parse(Console.ReadLine());
            double sh = double.Parse(Console.ReadLine());


            double sm = 30.0 / 100;
            double tableCloud = (dul + sm * 2) * (sh + sm * 2) * number;
            double kareCloud = (dul / 2) *(dul / 2) * number;
            

            double dolar = tableCloud * 7 + kareCloud * 9;
            double leva = dolar * 1.85;

            Console.WriteLine($"{dolar:f2} USD");
            Console.WriteLine($"{leva:F2} BGN");
            
        }
    }
}
