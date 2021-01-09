using System;

namespace _06.Tornir
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalMoney = 0;
            int counterwinTotal = 0;
            int counterloseTotal = 0;
            for (int i = 1; i <= n; i++)
            {
                double winGames = 0;
                string comand = Console.ReadLine();
                int counterWin = 0;
                int counterLose = 0;
                while (comand != "Finish")
                {
                    string rezult = Console.ReadLine();
                    if (rezult == "win")
                    {
                        winGames += 20;
                        counterWin++;
                    }
                    else
                    {
                        counterLose++;
                    }
                   


                    comand = Console.ReadLine();
                }
                if (counterWin > counterLose)
                {
                    winGames *= 1.10;
                    counterwinTotal++;
                }
                else
                {
                    counterloseTotal++;
                }

                totalMoney += winGames;

            }
            if (counterwinTotal > counterloseTotal)
            {

                totalMoney *= 1.20;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
            }




        }
    }
}
