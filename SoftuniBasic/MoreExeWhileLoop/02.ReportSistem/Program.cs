using System;

namespace _02.ReportSistem
{
    class Program
    {
        static void Main(string[] args)
        {
            int ochakvaneSuma = int.Parse(Console.ReadLine());

            int coutner = 0;
            string darenie = Console.ReadLine();
            int totalSumKash = 0;
            int totalSumCard = 0;
            int counterKash = 0;
            int couterCard = 0;
            while (darenie != "End")
            {
                coutner++;
                if (coutner%2==0)
                {
                    if ( int.Parse(darenie) <10)
                    {
                        Console.WriteLine("Error in transaction!");
                        
                    }
                    else
                    {

                    totalSumCard += int.Parse(darenie);
                    Console.WriteLine("Product sold!");
                        couterCard++;
                    }
                }
                else
                {
                    if (int.Parse(darenie) >100 )
                    {
                        Console.WriteLine("Error in transaction!");
                        
                    }
                    else
                    {

                    totalSumKash += int.Parse(darenie);
                    Console.WriteLine("Product sold!");
                        counterKash++;
                    }

                }
                if (ochakvaneSuma <= totalSumCard + totalSumKash)
                {

                    Console.WriteLine($"Average CS: {totalSumKash*1.0/counterKash:f2}");
                    Console.WriteLine($"Average CC: {totalSumCard*1.0/couterCard:f2}");
                    break;
                }

                darenie = Console.ReadLine();
            }

            if (ochakvaneSuma > totalSumCard + totalSumKash)
            {
            Console.WriteLine("Failed to collect required money for charity.") ;

            }

        }
    }
}
