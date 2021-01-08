using System;

namespace SimpleVar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("a=");
            var a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            var b = int.Parse(Console.ReadLine());
            var area = a * b;
            
            Console.Write("{2} * {1} = {0}",area , a , b );
        }
    }
}
