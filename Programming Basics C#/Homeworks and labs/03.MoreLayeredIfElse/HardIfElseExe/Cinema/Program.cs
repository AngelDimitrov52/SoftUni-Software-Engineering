using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string project = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            double a = 0.0;
       
            if (project == "Premiere")
            {
                a = 12.00;
            }
            else if (project == "Normal")
            {
                a = 7.50;
            }
            else if (project == "Discount")
            {
                a = 5;
            }
            double total = row * col * a;
            Console.WriteLine($"{total:f2} leva");



        }
    }
}
