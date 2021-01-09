using System;
using System.Threading;

namespace _01.OldBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int bookNum = int.Parse(Console.ReadLine());

            int countTotal = 0;



            string book = Console.ReadLine() ;

            while (book != name)
            {
                if (countTotal == bookNum)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {countTotal} books.");
                    break;

                }
                countTotal++;
                book = Console.ReadLine();
                


            }
            if (book == name)
            {
            Console.WriteLine($"You checked {countTotal} books and found it.");

            }

        }
    }
}
