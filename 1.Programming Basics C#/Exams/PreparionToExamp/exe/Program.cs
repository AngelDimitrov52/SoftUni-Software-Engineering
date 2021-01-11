using System;

class Program
{
    static void Main()
    {
        int numOfContestants = int.Parse(Console.ReadLine());

        int totalSoldGoods = 0;
        double totalMoney = 0;

        for (int i = 0; i < numOfContestants; i++)
        {
            string name = Console.ReadLine();

            int cakesCount = 0;
            int wafflesCount = 0;
            int cookiesCount = 0;

            string input = Console.ReadLine();

            while (input != "Stop baking!")
            {
                int num = int.Parse(Console.ReadLine()); // number of baked cookies/waffles/cakes

                switch (input)
                {
                    case "cookies":
                        cookiesCount += num;
                        break;
                    case "waffles":
                        wafflesCount += num;
                        break;
                    case "cakes":
                        cakesCount += num;
                        break;
                }

                input = Console.ReadLine();
            }

            totalSoldGoods += cakesCount + cookiesCount + wafflesCount;
            totalMoney += cakesCount * 7.80 + cookiesCount * 1.50 + wafflesCount * 2.30;

            Console.WriteLine($"{name} baked {cookiesCount} cookies, {cakesCount} cakes and {wafflesCount} waffles.");


        }

        Console.WriteLine($"All bakery sold: {totalSoldGoods}");
        Console.WriteLine($"Total sum for charity: {totalMoney:f2} lv.");
    }
}