using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int neOcenki = int.Parse(Console.ReadLine());

            string exeName = "";
            int counter = 0;
            int sum = 0;
            string a = "";
            int counteTwo = 0;
            while (exeName != "Enough")
            {
                a = exeName;
                exeName = Console.ReadLine();
               
                if (exeName == "Enough")
                {
                    continue;
                }
                int ocenka = int.Parse(Console.ReadLine());
                sum += ocenka;
                counteTwo++;

                if (ocenka <=4)
                {
                    counter++;
                    if (counter ==neOcenki)
                    {
                        Console.WriteLine($"You need a break, {counter} poor grades.");
                        break;
                    }
                }
            }
            if (exeName == "Enough")
            {

                Console.WriteLine($"Average score: {sum*1.0/counteTwo:f2}");
                Console.WriteLine($"Number of problems: {counteTwo}");
                Console.WriteLine($"Last problem: {a}");
            }

        }
    }
}
