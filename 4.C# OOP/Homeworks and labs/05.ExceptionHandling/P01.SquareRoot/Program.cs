using System;
using System.Linq;

namespace P01.SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0 )
                {
                    throw new IndexOutOfRangeException();
                }
                double root = Math.Sqrt(n);
                Console.WriteLine(root);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}

