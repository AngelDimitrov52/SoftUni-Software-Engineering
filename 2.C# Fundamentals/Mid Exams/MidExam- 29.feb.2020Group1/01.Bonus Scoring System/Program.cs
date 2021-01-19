using System;

namespace _01.Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int studetnsCount = int.Parse(Console.ReadLine());
            int lectionCount = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());

            double totalBonus = 0;
            double maxBonus = 0;
            int lection = 0;

            for (int i = 0; i < studetnsCount; i++)
            {
                int atednCount = int.Parse(Console.ReadLine());
                if (atednCount == 0)
                {
                    continue;
                }
                totalBonus = ((atednCount * 1.0) / (lectionCount * 1.0)) * (5 + bonus * 1.0);
                totalBonus = Math.Ceiling(totalBonus);


                if (totalBonus >= maxBonus)
                {
                    maxBonus = totalBonus;
                    lection = atednCount;


                }

            }
            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {lection} lectures.");




        }
    }
}
