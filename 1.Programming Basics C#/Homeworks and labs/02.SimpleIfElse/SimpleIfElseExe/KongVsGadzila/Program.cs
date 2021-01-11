using System;

namespace KongVsGadzila
{
    class Program
    {
        static void Main(string[] args)
        {
            double butget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double decor = butget *  0.10;
           

            if (extras > 150)
            {
                price = price * 0.9;
            }
            double totalPrice = extras * price + decor;

            if (totalPrice <= butget)
            {
                Console.WriteLine("Action!");
                double ost = butget - totalPrice;
                Console.WriteLine($"Wingard starts filming with {ost:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                double a = totalPrice - butget;
                Console.WriteLine($"Wingard needs {a:F2} leva more.");
            }
        }
    }
}
