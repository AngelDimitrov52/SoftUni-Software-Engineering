using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arr = Console.ReadLine().Split().Where(n => n.Length % 2 == 0).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine,arr));

        }
    }
}
