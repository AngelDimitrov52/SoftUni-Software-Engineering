using System;

namespace LiceNaPravougulnikVRavnina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches = ");
            var a = double.Parse(Console.ReadLine());
            var area = a * 2.54;
            Console.WriteLine("Centimeter = {0}", area);
        }
    }
}
