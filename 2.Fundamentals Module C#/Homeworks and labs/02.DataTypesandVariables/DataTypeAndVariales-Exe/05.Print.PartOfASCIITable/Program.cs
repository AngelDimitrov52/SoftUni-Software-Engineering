using System;

namespace _05.Print.PartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int from = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            
            for (int i = from; i <= end; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
