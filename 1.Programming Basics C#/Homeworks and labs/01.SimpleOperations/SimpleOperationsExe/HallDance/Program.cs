using System;

namespace HallDance
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine()) * 100 ;
            double sh = double.Parse(Console.ReadLine()) * 100;
            double wardrobe = double.Parse(Console.ReadLine()) * 100;

            double areaWardrobe = wardrobe * wardrobe;
            double bench = l * sh / 10.0;
            double areaHall = (l * sh - areaWardrobe - bench) ;

            double people = areaHall / 7040;

            Console.WriteLine(Math.Floor(people));
        }
    }
}
