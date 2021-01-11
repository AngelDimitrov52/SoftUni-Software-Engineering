using System;

namespace _03.Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayMoney = double.Parse(Console.ReadLine());
            double haveMoney = double.Parse(Console.ReadLine());
            int couter = 0;
            int couterTwo = 0;

            while (haveMoney < holidayMoney)
            {
                string action = Console.ReadLine();
                double actionMoney = double.Parse(Console.ReadLine());
                couterTwo++;
                if (action == "save")
                {
                    couter = 0;
                    haveMoney += actionMoney;
                }
                else
                {
                    couter++;
                    haveMoney -= actionMoney;
                        if (haveMoney < 0)
                    {
                        haveMoney = 0;
                    }
                    if (couter == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{couterTwo}");
                        break;
                    }
                }

                if (haveMoney >= holidayMoney)
                {
                    Console.WriteLine($"You saved the money for {couterTwo} days.");
                }

            }



        }
    }
}
