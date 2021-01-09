using System;

namespace AlcoholExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double rakia = double.Parse(Console.ReadLine());
            double wwhiskey = double.Parse(Console.ReadLine());

            double rakiaprice = whiskeyPrice * (1 - 0.50);
            double wineprice = rakiaprice * (1 - 0.40);
            double beerPrice = rakiaprice * (1 - 0.80);

            double bill = whiskeyPrice * wwhiskey + rakia * rakiaprice + wine * wineprice + beer * beerPrice;

            Console.WriteLine($"{bill:f2}");
        }
    }
}
