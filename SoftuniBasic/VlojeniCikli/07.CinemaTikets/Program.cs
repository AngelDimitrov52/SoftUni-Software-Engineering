using System;

namespace _07.CinemaTikets
{
    class Program
    {
        static void Main(string[] args)
        {
            string moveName = Console.ReadLine();
            int totalcounter = 0;
            int studentcounter = 0;
            int kidcounter = 0;
            int standardcounter = 0;

            while (moveName!="Finish")
            {
                int sitsInMovi = int.Parse(Console.ReadLine());

                int counter = 0;
                string people = Console.ReadLine();
                while (people != "End")
                {
                    counter++;
                   
                    if (people == "kid")
                    {
                        kidcounter++;
                    }
                    else if (people == "standard")
                    {
                        standardcounter++;
                    }
                    else if (people == "student")
                    {
                        studentcounter++;
                    }
                    if (counter == sitsInMovi)
                    {
                        break;
                    }
                    people = Console.ReadLine();
                }
                Console.WriteLine($"{moveName} - {counter *1.0 / sitsInMovi *100 :f2}% full.");

                moveName = Console.ReadLine();
                totalcounter += counter;
            }
            Console.WriteLine($"Total tickets: {totalcounter}");
            Console.WriteLine($"{(studentcounter *1.0 / totalcounter)* 100:f2}% student tickets.");
            Console.WriteLine($"{(standardcounter * 1.0 / totalcounter) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(kidcounter * 1.0 / totalcounter) * 100:f2}% kids tickets.");

        }
    }
}
