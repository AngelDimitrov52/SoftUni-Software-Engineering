using System;

namespace _10.Rage
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            headsetPrice = (lostGames / 2) * headsetPrice;
            mousePrice = (lostGames / 3) * mousePrice;
            keyboardPrice = (lostGames / 6) * keyboardPrice;
            displayPrice = (lostGames / 12) * displayPrice;
            double totalSum = headsetPrice + mousePrice + keyboardPrice + displayPrice;

            Console.WriteLine($"Rage expenses: {totalSum:f2} lv.");

           
        }
    }
}
