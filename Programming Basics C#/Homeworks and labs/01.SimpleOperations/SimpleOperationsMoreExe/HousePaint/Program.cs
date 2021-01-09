using System;

namespace HousePaint
{
    class Program
    {
        static void Main(string[] args)
        {
            double xVisochina = double.Parse(Console.ReadLine());
            double yDuljina = double.Parse(Console.ReadLine());
            double hVisochina = double.Parse(Console.ReadLine());




            double prednaStena = xVisochina * xVisochina - (1.2 * 2);
            double zadnaStena = xVisochina * xVisochina;
            double stranachnaStena =xVisochina * yDuljina - (1.5 * 1.5) ;
            double drugaStena = xVisochina * yDuljina - (1.5 * 1.5);

            double pokriv = xVisochina * yDuljina * 2;
            double triugulnik = ((xVisochina * hVisochina) / 2) *2 ;

            double totalSteni = (prednaStena + zadnaStena + stranachnaStena + drugaStena) / 3.4;
            double totalPokriv = (pokriv + triugulnik) / 4.3;

            Console.WriteLine($"{totalSteni:f2}");
            Console.WriteLine($"{totalPokriv:f2}");


        }
    }
}
