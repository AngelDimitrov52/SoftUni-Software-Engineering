using System;

namespace _06.TriapleOfLatinLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 97; j < 97 + n; j++)
                {
                    for (int k = 97; k < 97 + n; k++)
                    {
                        Console.WriteLine($"{(char)('a'+i)}{(char)j}{(char)k}");
                    }
                }

            }




        }
    }
}
