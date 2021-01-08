using System;

namespace _03.GameTime
{
    class Program
    {
        static void Main(string[] args)
        {
            double butgettotal = double.Parse(Console.ReadLine());
            double price = 0;
            double allgames = 0;
            string comand = Console.ReadLine();

            while (comand != "Game Time")
            {
                price = 0;
                string game = string.Empty;
                if (comand == "OutFall 4")
                {
                    game = "Bought OutFall 4";
                    price = 39.99;
                    butgettotal -= price;

                }
                else if (comand == "CS: OG")
                {
                    game = "Bought CS: OG";

                    price = 15.99;
                    butgettotal -= price;

                }
                else if (comand == "Zplinter Zell")
                {
                    game = "Bought Zplinter Zell";
                    price = 19.99;
                    butgettotal -= price;

                }
                else if (comand == "Honored 2")
                {
                    game = "Bought Honored 2";
                    price = 59.99;
                    butgettotal -= price;

                }
                else if (comand == "RoverWatch")
                {
                    game = "Bought RoverWatch";
                    price = 29.99;
                    butgettotal -= price;

                }
                else if (comand == "RoverWatch Origins Edition")
                {
                    game = "Bought RoverWatch Origins Edition";
                    price = 39.99;
                    butgettotal -= price;
                }
                else
                {
                    game = "Not Found";
                }
                
              
                allgames += price;
                if (butgettotal<0)
                {
                    butgettotal += price;
                    game = "Too Expensive";
                    

                }
                if (butgettotal == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                Console.WriteLine(game);
                comand = Console.ReadLine();
             

            }
            if (butgettotal>0)
            {
            Console.Write($"Total spent: ${allgames:f2}. ");
            Console.Write($"Remaining: ${butgettotal:f2}");

            }

        }
    }
}
