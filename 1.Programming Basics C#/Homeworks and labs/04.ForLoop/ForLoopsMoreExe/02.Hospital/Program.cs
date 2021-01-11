using System;

namespace _02.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int pregledani = 0;
            int a = 0;
            int propusnati = 0;

            int pregledaniNaDen = 7;
            for (int i = 1; i <= n; i++)
            {
                int pacientiNaDen = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    if (pregledani < propusnati)
                    {
                        pregledaniNaDen++;
                    }
                }
                if (pacientiNaDen <= pregledaniNaDen)
                {
                    pregledani += pacientiNaDen;
                }
                else
                {
                    pregledani += pregledaniNaDen;
                    a = pacientiNaDen - pregledaniNaDen;
                    propusnati += a;
                }
                


            }
            Console.WriteLine($"Treated patients: {pregledani}.");
            Console.WriteLine($"Untreated patients: {propusnati}.");
        }
    }
}
