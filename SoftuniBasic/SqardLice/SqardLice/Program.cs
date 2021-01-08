using System;

namespace SqardLice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
                Console.WriteLine("area={0}",area);
        }
    }
}
