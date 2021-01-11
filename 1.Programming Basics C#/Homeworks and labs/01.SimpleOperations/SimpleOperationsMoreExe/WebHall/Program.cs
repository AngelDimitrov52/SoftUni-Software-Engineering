using System;

namespace WebHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine())*100;
            double h = double.Parse(Console.ReadLine()) * 100 - 100;

            double hTable =Math.Floor( h / 70.0);
            
            double wTable =Math.Floor( w / 120.0);
     

            double hall = hTable * wTable - 3;
            
            Console.WriteLine(hall);

        }
    }
}
