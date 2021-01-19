using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstnumber = double.Parse(Console.ReadLine());
            double powerNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(PowerMetod(firstnumber,powerNumber));





        }

         private static double PowerMetod(double firstnumber, double powerNumber)
        {
            return  (double)Math.Pow(firstnumber,powerNumber);
            
        }
    }
}
