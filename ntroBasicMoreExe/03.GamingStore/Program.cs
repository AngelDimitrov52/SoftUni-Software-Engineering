using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double butget = double.Parse(Console.ReadLine());

            string comand = Console.ReadLine();
            double totalSumGame = 0;
            double oldButbet = butget;
            while (comand != "Game Time")

            {
                bool flag = true ;
                double gamePrice = 0;

                if (comand== "OutFall 4")
                {
                    gamePrice = 39.99;
                }
                else if (comand== "CS: OG")
                {
                    gamePrice = 15.99;
                }
                else if (comand == "Zplinter Zell")
                {
                    gamePrice = 19.99;
                }
                else if (comand == "Honored 2")
                {
                    gamePrice = 59.99;
                }
                else if (comand == "RoverWatch")
                {
                    gamePrice = 29.99;
                }
                else if (comand == "RoverWatch Origins Edition")
                {
                    gamePrice = 39.99;
                }
                else
                {
                    flag = false;
                    Console.WriteLine("Not Found");
                }

                if (butget>= gamePrice)
                {
                    if (flag==true)
                    {
                    butget -= gamePrice;
                        totalSumGame += gamePrice;
                    Console.WriteLine($"Bought {comand}");
                    }
                }
                
                else
                {
                    Console.WriteLine("Too Expensive");
                }
                if (butget == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }


                comand = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${totalSumGame:f2}. Remaining: ${oldButbet - totalSumGame:f2}");
            
        }
    }
}
