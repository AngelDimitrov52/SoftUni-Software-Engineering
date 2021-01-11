using System;

namespace vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForVacantion = double.Parse(Console.ReadLine());
            double spendMoney = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int spendingCounter = 0;

            while (true)
            {
                string comand = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                daysCounter++;

                if (comand == "save")
                {
                    spendMoney += sum;
                    
                    spendingCounter =0 ;


                }
                else if (comand == "spend")
                {
                    spendMoney -= sum;
                    spendingCounter++;

                }
                if (spendingCounter == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(daysCounter);
                    return;
                }
                daysCounter++;

            }
        }
    }
}