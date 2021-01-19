using System;

namespace _06.Aea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int area = CaoculateArea(width,height);

            Console.WriteLine(area);


        }

        private static int CaoculateArea(int width, int height)
        {
            return width * height;
        }
    }
}
