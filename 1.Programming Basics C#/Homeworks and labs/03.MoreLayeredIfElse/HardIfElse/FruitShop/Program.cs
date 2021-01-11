using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double kg = double.Parse(Console.ReadLine());

            double prise = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    prise = 2.50;
                }
                else if (fruit == "apple")
                {
                    prise = 1.20;
                }
                else if (fruit == "orange")
                {
                    prise = 0.85;
                }
                else if (fruit == "grapefruit")
                {
                    prise = 1.45;
                }
                else if (fruit == "kiwi")
                {
                    prise = 2.70;
                }
                else if (fruit == "pineapple")
                {
                    prise = 5.50;
                }
                else if (fruit == "grapes")
                {
                    prise = 3.85;
                }
               
               
           

            }
            if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    prise = 2.70;
                }
                else if (fruit == "apple")
                {
                    prise = 1.25;
                }
                else if (fruit == "orange")
                {
                    prise = 0.90;
                }
                else if (fruit == "grapefruit")
                {
                    prise = 1.60;
                }
                else if (fruit == "kiwi")
                {
                    prise = 3.00;
                }
                else if (fruit == "pineapple")
                {
                    prise = 5.60;
                }
                else if (fruit == "grapes")
                {
                    prise = 4.20;
                }
                
        
            }
            if (prise == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                double total = prise * kg;
                Console.WriteLine($"{total:f2}");
            }
         
        }
    }
}
