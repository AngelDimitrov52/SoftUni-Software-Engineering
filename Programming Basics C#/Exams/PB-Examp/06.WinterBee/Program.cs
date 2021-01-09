using System;

namespace _06.WinterBee
{
    class Program
    {
        static void Main(string[] args)
        {
            double honeyNeed = double.Parse(Console.ReadLine());

            string comand = Console.ReadLine();
            double totalhoney = 0;

            while (comand != "Winter has come")
            {
                double totalbeeWork = 0;
                for (int i = 1; i <= 6; i++)
                {
                    double workBee = Math.Round(double.Parse(Console.ReadLine()),2);
                    totalbeeWork += workBee;
                    totalbeeWork = Math.Round(totalbeeWork,2);
                }

                totalhoney += totalbeeWork;
                totalhoney = Math.Round(totalhoney, 2);
                if (totalbeeWork < 0)
                {
                    Console.WriteLine($"{comand} was banished for gluttony");
                }
                if (totalhoney >= honeyNeed)
                {
                    break;
                }
                comand = Console.ReadLine();
            }
            if (honeyNeed <= totalhoney)
            {
                Console.WriteLine($"Well done! Honey surplus {totalhoney - honeyNeed:f2}.");
            }
            else
            {
                Console.WriteLine($"Hard Winter! Honey needed {honeyNeed - totalhoney:f2}.");
            }


        }
    }
}
