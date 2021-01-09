using System;

namespace _03.CharInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            PrintAllChars(first,second);



        }

        private static void PrintAllChars(char first, char second)
        {
            if (first > second)
            {
                char x = first;
                first = second;
                second = x;
            }
            for (int i = first + 1; i < second; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
