using System;

namespace _01.Smallerof3Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int seconNum = int.Parse(Console.ReadLine());
            int thurdNum = int.Parse(Console.ReadLine());
            int a = Math.Min(firstNum,seconNum);
            Console.WriteLine( Math.Min(a,thurdNum));
        }
    }
}
