using System;

namespace _05.DataModifier
{
    public class Program
    {
        static void Main(string[] args)
        {
            string firstData = Console.ReadLine();
            string secondData = Console.ReadLine();

            int days = DateModifier.GetDaysOfTwoDates(firstData, secondData);

            Console.WriteLine(days);
        }
    }
}
