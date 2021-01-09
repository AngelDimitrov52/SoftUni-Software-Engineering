using System;

namespace _11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageLily = int.Parse(Console.ReadLine());
            double washPrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            int toyNum = 0;
            int money = 0;
            int a = 0;
            for (int i = 1; i <= ageLily; i+=2)
            {
                toyNum++;
                if (i!=ageLily)
                {


                    for (int j = 2; j <= ageLily; j += 2)
                    {
                        a += 10;
                        money += a - 1;
                        break;
                    }
                }
            }
            double totalMoney = toyNum * toyPrice + money;

            if (totalMoney >= washPrice)
            {
                Console.WriteLine($"Yes! {totalMoney - washPrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washPrice - totalMoney:f2}");
            }



        }
    }
}
