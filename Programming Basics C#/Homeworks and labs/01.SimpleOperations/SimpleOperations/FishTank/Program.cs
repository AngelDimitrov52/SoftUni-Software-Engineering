using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int sh = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double pro = double.Parse(Console.ReadLine());
            int fullTank = d* sh *h ;
            double fullLiter = fullTank * 0.001;
            double procent = pro * 0.01;
            double done = fullLiter * (1 - procent);
            Console.WriteLine($"{done:f3}");


        }
    }
}
