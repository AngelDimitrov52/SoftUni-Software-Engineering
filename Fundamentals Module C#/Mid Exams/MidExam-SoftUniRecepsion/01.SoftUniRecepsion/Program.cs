using System;

namespace _03.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int trurt = int.Parse(Console.ReadLine());
            int totalwork = first + second + trurt;

            int people = int.Parse(Console.ReadLine());
            int cout = 0;
            int pochivka = 0;
            while (people > 0)
            {
                people -= totalwork;
                cout++;
                if (cout % 3 == 0)
                {
                    if (people <= 0)
                    {
                        continue;
                    }
                    pochivka++;
                }
            }
            Console.WriteLine($"Time needed: {cout + pochivka}h.");





        }
    }
}
