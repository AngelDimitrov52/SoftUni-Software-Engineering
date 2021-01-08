using System;

namespace _06.Bulding
{
    class Program
    {
        static void Main(string[] args)
        {
            int flor = int.Parse(Console.ReadLine());
            int room = int.Parse(Console.ReadLine());
            string indeks = "";
            for (int i = flor; i >= 1; i--)
            {
                for (int j = 0; j < room; j++)
                {
                    if (i == flor)
                    {
                        indeks = "L";
                    }
                    else if (i % 2 == 0)
                    {
                        indeks = "O";
                    }
                    else
                    {
                        indeks = "A";
                    }
                    Console.Write($"{indeks}{i}{j} ");
                }
                Console.WriteLine("");

            }

        }
    }
}
