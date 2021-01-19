using System;

namespace _04.ReversString
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversString = Console.ReadLine();

            for (int i = reversString.Length - 1; i >= 0; i--)
            {
                Console.Write(reversString[i]);
            }


        }
    }
}
