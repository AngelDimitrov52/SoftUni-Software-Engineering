using System;

namespace _03.Couculation
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            if (comand == "add")
            {
                PrintAdd(first, second);

            }
            else if (comand == "multiply")
            {
                PrintMultiply(first, second);
            }
            else if (comand == "subtract")
            {
                PrintSubtract(first, second);
            }
            else if (comand == "divide")
            {
                PrintDivide(first,second);
            }



        }

        private static void PrintDivide(int first, int second)
        {
            Console.WriteLine(first / second); 
        }

        private static void PrintSubtract(int first, int second)
        {
            Console.WriteLine(first - second);
        }

        private static void PrintAdd(int first, int second)
        {
            Console.WriteLine(first + second);
        }
        static void PrintMultiply(int first, int second)
        {
            Console.WriteLine(first * second);
        }
    }
}
