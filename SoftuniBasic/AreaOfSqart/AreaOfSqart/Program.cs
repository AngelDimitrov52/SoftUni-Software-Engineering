using System;

namespace AreaOfSqart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            var a =   decimal.Parse(Console.ReadLine());

            Console.Write("b=");
            var b =  decimal.Parse(Console.ReadLine());
            var area = a * b;
            Console.WriteLine("area = {0}",area);
        }
    }
}
